using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genel_Muhasebe.DataBase
{
    public class UserKutuphane
    {
        string userID, userPWD;
        public string GetUserID() { return userID; }
        public string GetUserPWD() { return userPWD; }
        public void SetUserID(string id) { userID = id; }
        public void SetUserPWD(string pwd) { userPWD = pwd; }
    }
}
