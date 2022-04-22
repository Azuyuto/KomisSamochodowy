using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomisSamochodowy.Model
{
    public class CarUtils
    {
        public static string file = @"carDB.json";

        public static void AddCar(Car entity)
        {
            var cars = GetCars();
            cars.Add(entity);
            File.WriteAllText(GetFilePath(), JsonConvert.SerializeObject(cars));
        }

        public static List<Car> GetCars()
        {
            var items = new List<Car>();
            using (var r = new StreamReader(GetFilePath()))
            {
                var json = r.ReadToEnd();
                if(!String.IsNullOrEmpty(json))
                {
                    items.AddRange(JsonConvert.DeserializeObject<List<Car>>(json));
                }
            }

            return items;
        }

        private static string GetFilePath()
        {
            var enviroment = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(enviroment).Parent.FullName;
            return String.Format(@"{0}\Database\{1}", projectDirectory, file);
        }

        public static List<string> GetBrands()
        {
            return GetCars().Select(a => a.Brand).Distinct().ToList();
        }

        public static List<string> GetCarModels(string brand = null)
        {
            return GetCars().Where(a => String.IsNullOrEmpty(brand) || a.Brand == brand).Select(a => a.CarModel).Distinct().ToList();
        }

        public static List<string> GetEngines(string brand = null, string carModel = null)
        {
            return GetCars().Where(a => (String.IsNullOrEmpty(brand) || a.Brand == brand) && (String.IsNullOrEmpty(carModel) || a.CarModel == carModel))
                .SelectMany(a => a.Engines.Select(c => c)).Distinct().ToList();
        }

        public static List<string> GetColors(string brand = null, string carModel = null)
        {
            return GetCars().Where(a => (String.IsNullOrEmpty(brand) || a.Brand == brand) && (String.IsNullOrEmpty(carModel) || a.CarModel == carModel))
                .SelectMany(a => a.Colors.Select(c => c)).Distinct().ToList();
        }

        public static List<string> GetAdditionals(string brand = null, string carModel = null)
        {
            return GetCars().Where(a => (String.IsNullOrEmpty(brand) || a.Brand == brand) && (String.IsNullOrEmpty(carModel) || a.CarModel == carModel))
                .SelectMany(a => a.Additionals.Select(c => c)).Distinct().ToList();
        }
    }
}
