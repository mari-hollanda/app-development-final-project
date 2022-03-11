using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Util
    {
        public static bool adminValidation(string password)
        {
            if (password == "admin")
            {
                return true;
            }
            return false;
        }
    }
}
