using System;

namespace Infrastructure
{


    public interface IAnimalViewModel
    {
        string Family { get; set; }
        string Gender { get; set; }
        string Name { get; set; }
        bool IsFured { get; set; }
        bool IsHorned { get; set; }
        int? HornCount{ get; set; }
        string FurType{ get; set; }

    }

}