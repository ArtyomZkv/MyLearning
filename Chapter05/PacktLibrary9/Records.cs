using System;

namespace Packt.Shared
{
    public class ImmutablePerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    public record ImmutableVehicle
    {
        public int Wheels { get; init; }
        public string Color { get; init; }
        public string Brand { get; init; }
    }
    public record ImutableAnimal
    {
        string Name;
        string Species;

        public ImutableAnimal(string name, string species)
        {
            Name = name;
            Species = species;
        }
        public void Deconstruct(out string name, out string species)
        {
            name = Name;
            species = Species;
        }
    }
}