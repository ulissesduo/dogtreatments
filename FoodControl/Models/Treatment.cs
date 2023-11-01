using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodControl.Models
{
    public class Treatment
    {
        public int Id { get; set; }
        public int Food { get; set; }
        public int MissingFood { get; set; }
        public int Water { get; set; }
        public int MissingWater { get; set; }
        public string Date { get; set; }

    }
}
