using System.Text.Json;

namespace HWS_EntityFrameworkCore_2022_30_05
{
    public class Gladiator
    {
        public int GladiatorId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int Level { get; set; }
        public string? Proffesion { get; set; }

        public Gladiator(string? firstName, string? lastName, string? proffesion)
        {
            FirstName = firstName;
            LastName = lastName;
            Level = 1;
            Proffesion = proffesion;
        }
        public override string ToString()
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            return JsonSerializer.Serialize(this, options);
        }
    }
}
