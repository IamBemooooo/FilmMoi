using FilmMoi.Application.DataTransferObj.Users.Utilities;
using FilmMoi.Application.Interface.Utilities;
using FilmMoi.Application.ValueObj.Extentions;
using FilmMoi.Domain.Models;
using MailKit.Security;
using Microsoft.EntityFrameworkCore;
using MimeKit;
using MailKit.Net.Smtp;
using System.Net.Mail;

namespace FilmMoi.Infrastracture.Implement.Repository.Utilities
{
    public class UsersUtilitiesRepository : IUsersUtilitiesRepository
    {
        private readonly FilmMoiContext _db;
        private string ConfirmEmail = "";

        public UsersUtilitiesRepository(FilmMoiContext db)
        {
            _db = db;
        }
        public async Task<bool> BanAcc(Guid id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }


        public async Task<bool> ChangePassword(ChangePasswordRequest request, CancellationToken cancellationToken)
        {
            var obj = await _db.Users.AsNoTracking().FirstOrDefaultAsync(x => x.Id == request.Id);
            if (obj != null)
            {
                if (Hash.DecryptPassword(obj.PasswordHash) == request.OldPassword)
                {
                    obj.PasswordHash = Hash.EncryptPassword(request.NewPassword);
                    _db.Users.Update(obj);
                    await _db.SaveChangesAsync();
                    return true;
                }
                return false;
            }
            return false;
        }

        public async Task<bool> ConfirmCode(ConfirmCodeRequest request, CancellationToken cancellationToken)
        {
            var Obj = await _db.Users.FirstOrDefaultAsync(x => x.Id == request.ID);
            if ((Obj!.ConfirmCode == request.Code) && (DateTime.UtcNow.AddMinutes(-5) < Obj.SentTime))
            {
                return true;
            }
            return false;
        }

        public async Task<bool> ForgotPassword(ForgotPasswordRequest request, CancellationToken cancellationToken)
        {
            var Obj = await _db.Users.FirstOrDefaultAsync(x => x.Id == request.Id);
            if (request.NewPassword != request.ConfirmPW)
            {
                return false;
            }
            Obj.PasswordHash = Hash.EncryptPassword(request.NewPassword);
            _db.Users.Update(Obj);
            await _db.SaveChangesAsync();
            return true;
        }

        public Task<bool> Login(LoginRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<bool> LogOut(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> SeedGmail(SeedMailRequest request)
        {
            var user = await _db.Users.FirstOrDefaultAsync(x => x.Email == request.email);
            if (user != null)
            {
                var mail = "dangnguyen300708@gmail.com";
                var appPassword = "fkab oshv bwin jyay"; // Mã xác thực một lần tạo từ tài khoản Gmail của bạn
                var emailMessage = new MimeMessage();
                if (request.type)
                {
                    
                    Random rand = new Random();
                    var message = rand.Next(10000, 99999);

                   
                    emailMessage.From.Add(new MailboxAddress("Mei", mail));
                    emailMessage.To.Add(new MailboxAddress("Recipient Name", request.email));
                    emailMessage.Subject = "Xác nhận thay đổi mật khẩu";
                    var bodyBuilder = new BodyBuilder();
                    bodyBuilder.HtmlBody = $@"
                <p>Xin chào,</p>
                <p>Bạn đã tạo tài khoản thành công. Vui lòng nhấp vào nút bên dưới để kích hoạt tài khoản:</p>
                <a href=""https://example.com/confirm-password?code={message.ToString()}"">
                <button style=""background-color: #4CAF50; color: white; padding: 10px 20px; border: none; font-size: 16px;"">Kích Hoạt</button>
                </a>";

                    emailMessage.Body = bodyBuilder.ToMessageBody();

                }
                else
                {
                    Random rand = new Random();
                    var message = rand.Next(10000, 99999);

                    
                    emailMessage.From.Add(new MailboxAddress("Mei", mail));
                    emailMessage.To.Add(new MailboxAddress("Recipient Name", request.email));
                    emailMessage.Subject = "Xác nhận thay đổi mật khẩu";
                    var bodyBuilder = new BodyBuilder();
                    bodyBuilder.HtmlBody = $@"
                <p>Xin chào,</p>
                <p>Bạn đã yêu cầu thay đổi mật khẩu. Dưới đây là mã xác nhận tài khoản của bạn:</p>
                <a>
                   {message.ToString()}
                </a>
                <p>Mã sẽ có hiệu lực trong vòng 5 phút!</p>
                <p>Vui lòng không chia sẻ cho ai khác!</p>
                ";

                    emailMessage.Body = bodyBuilder.ToMessageBody();

                    user.ConfirmCode = message.ToString();
                    user.SentTime = DateTime.UtcNow.AddMinutes(2);
                    _db.Users.Update(user);
                    await _db.SaveChangesAsync();
                }


                using (var client = new MailKit.Net.Smtp.SmtpClient())
                {
                    client.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
                    client.Authenticate(mail, appPassword);
                    client.Send(emailMessage);
                    client.Disconnect(true);
                }
                return true;
            }
            return false;
        }

    }
}
