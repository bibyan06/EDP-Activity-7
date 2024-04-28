using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDP_Activity4
{
   public static class LoggedSession
    {
        public static string LoggedInUsername { get; private set; }
        public static string UserType { get; private set; }

        public static void SetLoggedInUser(string username, string userType)
        {
            LoggedInUsername = username;
            UserType = userType;
        }

        public static void ClearLoggedInUser()
        {
            LoggedInUsername = null;
            UserType = null;
        }
    }

}
