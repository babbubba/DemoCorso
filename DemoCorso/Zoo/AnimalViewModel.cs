using Infrastructure;

namespace ViewModel
{
    public class AnimalViewModel : IAnimalViewModel
    {
        public string Family { get; set; }

        public string Gender { get; set; }
        public string Name { get; set; }
        public bool IsFured { get; set; }
        public bool IsHorned { get; set; }
        public int? HornCount { get; set; }
        public string FurType { get; set; }
        public string AnimalCall { get; set; }
    }
}
