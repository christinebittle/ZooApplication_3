using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZooApplication.Models.ViewModels
{
    public class DetailsSpecies
    {
        //the species itself that we want to display
        public SpeciesDto SelectedSpecies { get; set; }

        //all of the related animals to that particular species
        public IEnumerable<AnimalDto> RelatedAnimals { get; set; }
    }
}