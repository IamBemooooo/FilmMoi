using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmMoi.Domain.Models.Enum
{
    public enum FilmStatus
    {
        Upcoming, // Sắp ra mắt
        Released, // Đã phát hành
        OnHold, // Đang tạm dừng
        Discontinued // Đã ngừng phát triển
    }
}
