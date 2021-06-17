using Model;

namespace Infrastructure
{
    //Animale Generico
    public interface IAnimal
    {
        string Name { get; set; }
        string Family { get; set; }
        Gender Gender { get; set; }

        string AnimalCall();
    }

}