using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomisSamochodowy.Model
{
    public class Car
    {
        public string Brand { get; set; }
        public string CarModel { get; set; }
        public List<string> Engines { get; set; }
        public List<string> Colors { get; set; }
        public List<string> Additionals { get; set; }
        public string ImageCarPath { get; set; }
    }
}
