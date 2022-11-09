using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HousesProject
{
    internal class House
    {
        [Required]
        private string adress;
        public string? Nickname { get; set; }
        public string Adress
        {
            get => adress;
            init
            {
                setAdress(value);
            }
        }

        public House(string adress)
        {
            this.adress = adress;
        }
        public House()
        {
            this.adress = "Unknown";
        }

        public void setAdress(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return;
            }
            if (value.Length <= 5)
            {
                return;
            }
            adress = value;
        }
        public override string ToString()
        {
            if (!string.IsNullOrWhiteSpace(Nickname))
            {
                return $"{Nickname}"; ;
            }
            return $"{adress}";
        }
        public override bool Equals(object obj)
        {
            if (obj is House house)
            {
                return house.Adress == Adress;
            }
            return false;
        }

         public override int GetHashCode() => HashCode.Combine(Adress);

        public static bool operator == (House h, House h2) => h.Equals(h2);

        public static bool operator !=(House h, House h2) => !h.Equals(h2);
    }
}
