using Infrastructure;

namespace Model
{
    public abstract class AnimalModel : IAnimal
    {
        public string Family { get; set; }

        public Gender Gender { get; set; }
        public bool IsCarnivoro { get; set; }
        public string Name { get; set; }

        public abstract string AnimalCall();

    }

}
