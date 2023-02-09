using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._02._23_HW
{
    public class City
    {
        private string name;
        private string country;
        private int count;
        private string key;
        private string areas;

        public City() { }
        public City(string n, string c, int co, string k, string ar)
        {
            name = n;
            country = c;
            count = co;
            key = k;
            areas = ar;
        }
        public string Name { get { return name; } set { name = value; } }
        public string Country { get { return country; } set { country = value; } }
        public int Count { get { return count; } set { count = value; } }
        public string Key { get { return key; } set { key = value; } }
        public string Areas { get { return areas; } set { areas = value; } }

        public void Print()
        {
            Console.WriteLine($"City: {name}\nCountry: {country}\nPeoples: {count}\nNum key: {key}\nAreas: {areas}");
        }
        public override string ToString()
        {
            return $"City: {name}\nCountry: {country}\nPeoples: {count}\nNum key: {key}\nAreas: {areas}";
        }
        public static City operator+(City a, int b)
        {
            a.count += b;
            return a;
        }
        public static City operator-(City a, int b)
        {
            b *= -1;
            return a + b;
        }
        public static bool operator==(City a, int b)
        {
            if (a.count == b)
                return true;
            else
                return false;
        }
        public static bool operator!=(City a, int b) => !(a == b);
        public static bool operator>(City a, int b)
        {
            if (a.count > b)
                return true;
            else
                return false;
        }
        public static bool operator <(City a, int b) => !(a > b);
    }
}
