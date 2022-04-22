using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomisSamochodowy.Model
{
    public class SavedCarUtils
    {
        public static string file = @"savedCarDB.json";

        public static void AddCar(SavedCar entity)
        {
            var cars = GetCars();
            entity.ID = cars.Count + 1;
            cars.Add(entity);
            File.WriteAllText(GetFilePath(), JsonConvert.SerializeObject(cars));
        }

        public static List<SavedCar> GetCars()
        {
            var items = new List<SavedCar>();
            using (var r = new StreamReader(GetFilePath()))
            {
                var json = r.ReadToEnd();
                if (!String.IsNullOrEmpty(json))
                {
                    items.AddRange(JsonConvert.DeserializeObject<List<SavedCar>>(json));
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

        public static SavedCar GetByID(int id)
        {
            return GetCars().Where(a => a.ID == id).FirstOrDefault();
        }

        public static void UpdateSavedCar(SavedCar savedCar)
        {
            var cars = GetCars();
            var car = cars.Where(a => a.ID == savedCar.ID).FirstOrDefault();
            car.StartDate = savedCar.StartDate;
            car.EndDate = savedCar.EndDate;
            car.UserData = savedCar.UserData;
            File.WriteAllText(GetFilePath(), JsonConvert.SerializeObject(cars));
        }
    }
}
