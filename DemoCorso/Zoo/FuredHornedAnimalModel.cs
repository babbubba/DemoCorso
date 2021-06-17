using Infrastructure;

namespace Model
{
    public class FuredHornedAnimalModel : FuredAnimalModel, IHorned
    {
        public int HornCount { get; set; }
        public override string AnimalCall()
        {
            return "Sgront!";
        }
    }

}
