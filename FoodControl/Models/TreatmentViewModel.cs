using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodControl.Models
{
    public class TreatmentViewModel
    {
        public int Food { get; set; }
        public int MissingFood { get; set; }
        public int Water { get; set; }
        public int MissingWater { get; set; }
    }
}
