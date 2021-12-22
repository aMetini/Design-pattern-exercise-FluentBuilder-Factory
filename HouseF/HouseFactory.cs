using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HouseF
{
    public class HouseFactory
    {
        private Dictionary<string, Type> _houses;

        public HouseFactory()
        {
            _houses = LoadHouseByReflection();
        }

        public House CreateHouse(string houseTypeName)
        {
            return GetHouseFromDictionary(houseTypeName.ToLower());
        }

        private Dictionary<string, Type> LoadHouseByReflection()
        {
            IEnumerable<Type> availableHouseTypes = Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .Where(t => t.IsClass && t.IsSubclassOf(typeof(House)));

            Dictionary<string, Type> availableHouses = new Dictionary<string, Type>();

            foreach (Type t in availableHouseTypes)
            {
                availableHouses.Add(t.Name.ToLower(), t);
            }
            return availableHouses;
        }

        private House GetHouseFromDictionary(string houseTypeName)
        {
            Type type = _houses[houseTypeName];
            if (type == null)
            {
                throw new ArgumentException($"Unable to find house type with name {houseTypeName}");
            }
            return (House)Activator.CreateInstance(type);
        }

    }
}
