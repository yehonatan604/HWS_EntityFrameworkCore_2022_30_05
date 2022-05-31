namespace HWS_EntityFrameworkCore_2022_30_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CharacterCreator creator = new();

            while (true)
            {
                Console.WriteLine("please pick an option:\n");
                Console.WriteLine("1 - Craete a gladiator");
                Console.WriteLine("2 - Delete a gladiator");
                Console.WriteLine("3 - Update a gladiator");
                Console.WriteLine("4 - Get a gladiator details, or all gladiators");
                Console.WriteLine("5 - Quit\n");
                Console.Write(">>>");
                
                string? input = Console.ReadLine();
                if (input != null && Validator.ValidateNumber(input) == true)
                {
                    switch (Convert.ToInt32(input))
                    {
                        case 1: { creator.AddtoDB(); break; }
                        case 2: { creator.RemoveRecord(); break; }
                        case 3: { creator.UpdateRecord(); break; }
                        case 4: { creator.GetRecords(); break; }
                        case 5: { return; }
                        default: { Console.WriteLine("wrong number.\n"); continue; }
                    }
                }
            }
        }
    }
}
