namespace Zoolandia.Animals
{
    public class Leoparduspardalis: Animal
    {
        public string furcolor {get; set;}
        public Leoparduspardalis ()
        {
            this.petname = "Claw";
        }
        public Leoparduspardalis(string petname)
        {
            this.petname = petname;
        }
        public override string description()
        {
            return $"This is {petname} \n{base.description()}, his fur color is {this.furcolor}";
        }
    }
}