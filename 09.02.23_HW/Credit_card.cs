using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._02._23_HW
{
    internal class Credit_card
    {
        public string NumCard { get; set; } = null;
        public string Name { get; set; } = null;
        public int? CVV { get; set; } = null;
        public string Date { get; set; } = null;
        public int Money { get; set; } = 0;
        public Credit_card() { }
        public Credit_card(string numCard, string name, int? cVV, string date, int money)
        {
            NumCard = numCard;
            Name = name;
            CVV = cVV;
            Date = date;
            Money = money;
        }

        public override string ToString()
        {
            return $"Fullname: {Name}\nCard number: {NumCard}\nDate: {Date}\nCVV: {CVV}\nMoney: {Money}";
        }
        public static Credit_card operator+(Credit_card a, int b)
        {
            a.Money += b;
            return a;
        }
        public static Credit_card operator -(Credit_card a, int b)
        {
            b *= -1;
            return a + b;
        }
        public static bool operator==(Credit_card a, int b)
        {
            if (a.CVV == b)
                return true;
            else
                return false;
        }
        public static bool operator !=(Credit_card a, int b) => !(a == b);
        public static bool operator >(Credit_card a, int b)
        {
            if (a.Money > b)
                return true;
            else
                return false;
        }
        public static bool operator <(Credit_card a, int b) => !(a > b);
    }
}
