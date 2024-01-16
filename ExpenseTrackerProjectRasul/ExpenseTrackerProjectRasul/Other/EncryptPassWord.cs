using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTrackerProjectRasul
{
    public static class EncryptPassWord
    {

        public static string GeneratePassWord(string passWord)
        {
            var md5 = MD5.Create();

            return Encoding.UTF8.GetString(md5.ComputeHash(Encoding.UTF8.GetBytes(passWord)));
        }
    }
}
