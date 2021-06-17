using System.Collections.Generic;
using System.Linq;
using Infrastructure;
using Model;

namespace Repository
{
    public class AnimalsRepository
    {
        public IEnumerable<IAnimal> GetAllAnimals()
        {
            // Inizializza la lista
            var result = new List<IAnimal>();

            // Popola la lista con gli animali
            result.Add(new FuredAnimalModel
            {
                Family = "Ursidae",
                Gender = Gender.Male,
                Name = "Yogi",
                HairType = HairType.Medium
            });

            result.Add(new FuredHornedAnimalModel
            {
                Family = "Suidi",
                Gender = Gender.Female,
                Name = "Ursula",
                HairType = HairType.Short,
                HornCount = 2
            });

            // Restituisci la lista
            return result;
        }

        public IEnumerable<IAnimal> GetAllAnimalsByFamily(string family)
        {
            // Inizializza la lista
            var result = GetAllAnimals().Where(animal => animal.Family == family);

            // Restituisci la lista
            return result;
        }

        public IEnumerable<IAnimal> GetAllAnimalsByName(string name)
        {
            // Inizializza la lista
            var result = GetAllAnimals().Where(animal => animal.Name == name);

            // Restituisci la lista
            return result;
        }
    }
}
