using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EDP_Activity4
{
    public static class UserSession
    {
        public static string LoggedInUsername { get; private set; }
        public static string UserType { get; private set; }

        public static string name { get; private set; }
    }
}
