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
                }
                return false;
            }
            return false;

        }

        public async Task<bool> ForgotPassword(ForgotPasswordRequest request, CancellationToken cancellationToken)
        {
            /* if (request.EmailConfirm == ConfirmEmail)
             {
                 var obj = await _db.Users.AsNoTracking().FirstOrDefaultAsync(x => x.Email == request.Email);
                 obj.PasswordHash = Hash.EncryptPassword(request.NewPassword);
                 _db.Users.Update(obj);
                 await _db.SaveChangesAsync();
                 return true;
             }*/
            return false;

        }

        public Task<bool> Login(LoginRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<bool> LogOut(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> SeedGmail(string email)
        {
            var user = await _db.Users.FirstOrDefaultAsync(x => x.Email == email);
            if (user != null)
            {
                var mail = "dangnguyen300708@gmail.com";
                var appPassword = "fkab oshv bwin jyay"; // Mã xác thực một lần tạo từ tài khoản Gmail của bạn
                Random rand = new Random();
                var message = rand.Next(10000, 99999);

                var emailMessage = new MimeMessage();
                emailMessage.From.Add(new MailboxAddress("Mei", mail));
                emailMessage.To.Add(new MailboxAddress("Recipient Name", email));
                emailMessage.Subject = "Xác nhận thay đổi mật khẩu";
                emailMessage.Body = new TextPart("plain")
                {
                    Text = message.ToString()
                };

                user.ConfirmCode = message.ToString();
                user.SentTime = DateTime.UtcNow.AddMinutes(2);
                _db.Users.Update(user);
                await _db.SaveChangesAsync();

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
