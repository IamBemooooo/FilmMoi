using FilmMoi.Application.DataTransferObj.Users.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmMoi.Application.Interface.Utilities
{
    public interface IUsersUtilitiesRepository
    {
        //Đổi mật khẩu
        Task<bool> ChangePassword(ChangePasswordRequest request, CancellationToken cancellationToken);
        //Quên mật khẩu
        Task<bool> ForgotPassword(ForgotPasswordRequest request,CancellationToken cancellationToken);
        //Đăng nhập
        Task<bool> Login(LoginRequest request, CancellationToken cancellationToken);
        //Ban Acc
        Task<bool> BanAcc(Guid id,CancellationToken cancellationToken);
        Task<bool> LogOut(CancellationToken cancellationToken);
        Task<bool> SeedGmail(string email);

    }
}
