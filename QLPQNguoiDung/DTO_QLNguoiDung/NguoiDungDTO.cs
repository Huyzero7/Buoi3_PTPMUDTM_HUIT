using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLNguoiDung
{
    public class NguoiDungDTO
    {
        private string user;
        private string pass;

        public string User { get => user; set => user = value; }
        public string Pass { get => pass; set => pass = value; }

        public NguoiDungDTO() 
        {
            User = string.Empty; ;
            Pass = string.Empty;
        }

        public NguoiDungDTO(string user, string pass)
        {
            User = user;   
            Pass = pass;
        }
    }
}
