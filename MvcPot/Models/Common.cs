using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcPot.Models
{
    public class Common
    {
        public static List<Answer> GetAnswers()
        {
            List<Answer> list = new List<Answer>();
            list.Add(new Answer() { Id = 1, Name = "Çok iyi", Css = "check w3" });
            list.Add(new Answer() { Id = 2, Name = "İyi", Css = "check w3ls" });
            list.Add(new Answer() { Id = 3, Name = "Doğal", Css = "check wthree" });
            list.Add(new Answer() { Id = 4, Name = "Zayıf", Css = "check w3_agileits" });
            return list;
        }
    }
}