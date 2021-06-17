using Infrastructure;

namespace Model
{
    public class FuredAnimalModel : AnimalModel, IFured
    {
        public HairType HairType { get; set; }

        public override string AnimalCall()
        {
            return "Grunt!";
        }
    }

}
