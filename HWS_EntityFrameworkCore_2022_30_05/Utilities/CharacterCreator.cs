namespace HWS_EntityFrameworkCore_2022_30_05
{
    public class CharacterCreator
    {
        private ArenaContext Context { get; set; }
        public CharacterCreator()
        {
            Context = new();
        }
        public void AddtoDB()
        {
            Console.WriteLine("please enter first name:");
            Console.Write(">>>");
            string? firstName = Console.ReadLine();
            Console.WriteLine("please enter last name:");
            Console.Write(">>>");
            string? lastName = Console.ReadLine();
            while (true)
            {
                Console.WriteLine("please pick a proffesion 1-barbarian, 2-rogue, 3-mage:");
                Console.Write(">>>");
                string? proffesion = Console.ReadLine();
                if (Validator.validateAddtoDB(firstName, lastName, proffesion))
                {
                    proffesion = proffesion switch
                    {
                        "1" => "Barbarian",
                        "2" => "Rogue",
                        "3" => "Mage",
                        _ => string.Empty
                    };

                    var gladiator = new Gladiator(firstName, lastName, proffesion);
                    Context.Gladiators.Add(gladiator);
                    Context.SaveChanges();
                    break;
                }
            }
        }
        public void RemoveRecord()
        {
            while (true)
            {
                Console.WriteLine("please pick a record id to remove:");
                Console.Write(">>>");
                string id = Console.ReadLine();
                if (id != null & Validator.ValidateNumber(id))
                {
                    int record = Convert.ToInt32(id);
                    try
                    {
                        Context.Gladiators.Remove(Context.Gladiators.SingleOrDefault(x => x.GladiatorId == record));
                    }
                    catch (Exception)
                    {

                        Console.WriteLine("no such id.");
                        continue;
                    }
                    Context.SaveChanges();
                    break;
                }
            }
        }

        public void UpdateRecord()
        {
            while (true)
            {
                Console.WriteLine("please pick a record id to update:");
                Console.Write(">>>");
                string id = Console.ReadLine();
                if (id != null & Validator.ValidateNumber(id))
                {
                    int record1 = Convert.ToInt32(id);
                    try
                    {
                        var record = Context.Gladiators.SingleOrDefault(x => x.GladiatorId == Convert.ToInt32(id));
                        Console.WriteLine("please enter new first name:");
                        Console.Write(">>>");
                        record.FirstName = Console.ReadLine();
                        Console.WriteLine("please enter new last name:");
                        Console.Write(">>>");
                        record.LastName = Console.ReadLine();
                        Console.WriteLine("please pick new proffesion 1-barbarian, 2-rogue, 3-mage:");
                        Console.Write(">>>");
                        record.Proffesion = Console.ReadLine();
                    }
                    catch (Exception)
                    {

                        Console.WriteLine("no such id.");
                        continue;
                    }
                    Context.SaveChanges();
                    break;
                }
            }
        }
        public void GetRecords()
        {
            Console.WriteLine("please pick a record id to update or 0 for all:");
            string? s = Console.ReadLine();
            if (s != null && Validator.ValidateNumber(s))
            {
                int id = int.Parse(s);
                var record = Context.Gladiators.SingleOrDefault(x => x.GladiatorId == id);
                switch (id)
                {
                    case 0:
                        {
                            foreach (var item in Context.Gladiators)
                            {
                                Console.WriteLine(item);
                            }
                            break;
                        }
                    default:
                        {
                            Console.WriteLine(record);
                            break;
                        }
                }
            }
        }
    }
}
