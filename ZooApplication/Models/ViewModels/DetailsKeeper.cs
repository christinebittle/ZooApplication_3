using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZooApplication.Models.ViewModels
{
    public class DetailsKeeper
    {
        //What is the information I need on the keeper details page?
        public KeeperDto SelectedKeeper { get; set; }
        public IEnumerable<AnimalDto> KeptAnimals { get; set; }
    }
}