﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace MvcPot.Models
{
    public class Encrypt
    {
        public static string GetMD5Hash(string input)
        {
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] b = Encoding.UTF8.GetBytes(input);
                b = md5.ComputeHash(b);
                StringBuilder sb = new StringBuilder();
                foreach (byte item in b)
                {
                    sb.Append(item.ToString("x2"));
                }
                return sb.ToString();
            }
        }

    }
}