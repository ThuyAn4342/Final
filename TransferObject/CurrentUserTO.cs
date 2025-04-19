using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject
{
    public static class CurrentUserTO
    {
        public static TaiKhoanNDTO TaiKhoan { get; set; }

        public static string Email { get; set; }
    }
}
