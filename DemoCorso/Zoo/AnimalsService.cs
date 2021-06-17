using System.Collections.Generic;
using Infrastructure;
using Model;
using Repository;
using ViewModel;

namespace Service
{
    public class AnimalsService
    {
        private readonly AnimalsRepository animalsRepository;

        public AnimalsService(AnimalsRepository animalsRepository)
        {
            this.animalsRepository = animalsRepository;
        }

       
        public IEnumerable<IAnimalViewModel> GetAnimals()
        {
            var result = new List<IAnimalViewModel>();

            var modelsList = animalsRepository.GetAllAnimals();

            foreach (var animal in modelsList)
            {
                var furedObj = animal as FuredAnimalModel;
                var furedHornedObj = animal as FuredHornedAnimalModel;


                result.Add(new AnimalViewModel
                {
                    Family = animal.Family,
                    Gender = animal.Gender.ToString(),
                    Name = animal.Name,
                    IsFured = typeof(IFured).IsAssignableFrom(animal.GetType()),
                    IsHorned = typeof(IHorned).IsAssignableFrom(animal.GetType()),
                    FurType = furedObj?.HairType.ToString(),
                    HornCount = furedHornedObj?.HornCount,
                    AnimalCall = animal.AnimalCall()
                });
            }
            return result;
        }
    }
}
