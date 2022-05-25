using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelApi
{
    public class UserApi : ApiBaseType
    {
        
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string TypeUser { get; set; }
    }
}
