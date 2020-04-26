using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genel_Muhasebe.DataBase
{
    public class AdminKutuphane
    {
        string idAdmin, pwdAdmin;
        public string GetId() { return idAdmin; }
        public string GetPwd() { return pwdAdmin; }
        public void SetId(string id) { idAdmin = id; }
        public void SetPwd(string pwd) { pwdAdmin = pwd; }
    }
}
