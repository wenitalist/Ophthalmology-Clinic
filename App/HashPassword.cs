using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Security.Cryptography;

namespace OphthalmologyClinic.App
{
    class HashPassword
    {
        public string hashPassword(HashAlgorithm hashAlgorithm, string password)
        {
            byte[] data = hashAlgorithm.ComputeHash(Encoding.UTF8.GetBytes(password));
            var sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }
    }
}
