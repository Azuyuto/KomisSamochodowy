using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomisSamochodowy.Model
{
    public class SavedCar
    {
        public int ID { get; set; }
        public string Brand { get; set; }
        public string CarModel { get; set; }
        public string Engine { get; set; }
        public string Color { get; set; }
        public List<string> Additionals { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string UserData { get; set; }
    }
}
