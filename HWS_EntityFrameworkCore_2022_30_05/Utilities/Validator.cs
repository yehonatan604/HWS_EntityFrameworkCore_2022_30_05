using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWS_EntityFrameworkCore_2022_30_05
{
    public static class Validator
    {
        public static bool ValidateNumber(string s)
        {
            try
            {
                Convert.ToInt32(s);
            }
            catch (FormatException)
            {
                Console.WriteLine("enter numbers only.");
                return false;
            }
            return true;
        }
        public static bool validateAddtoDB(params string[] data)
        {
            foreach (string s in data)
            {
                if (s == null)
                {
                    Console.WriteLine("please enter all fields.");
                    return false;
                }
            }
            try
            {
                Convert.ToInt32(data.Length);
            }
            catch (FormatException)
            {
                Console.WriteLine("enter a number only for proffesion.");
                return false;
            }
            return true;
        }
    }
}
