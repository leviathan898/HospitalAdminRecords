using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace andyCheung_B8IT117
{
    class HashCode
    {
        public string PassHash(string data)
        {
            //create sha class
            SHA1 sha = SHA1.Create();

            //takes individual chars and creates bytes from them, populating an array of type byte
            byte[] hashData = sha.ComputeHash(Encoding.Default.GetBytes(data));

            //stringbuilder class takes array values and builds one string
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < hashData.Length; i++)
            {
                sb.Append(hashData[i].ToString());
            }

            return sb.ToString();
        }
    }
}
