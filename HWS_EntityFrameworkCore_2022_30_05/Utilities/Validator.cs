namespace HWS_EntityFrameworkCore_2022_30_05
{
    public static class Validator
    {
        //validates that a string is a number
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
        //validates if record is valid
        public static bool validateData(params string[] data)
        {
            foreach (string s in data)
            {
                if (s == null)
                {
                    Console.WriteLine("please enter all fields.");
                    return false;
                }
            }
            if (!ValidateNumber(data[data.Length]))
            {
                return false;
            }
            return true;
        }
    }
}
