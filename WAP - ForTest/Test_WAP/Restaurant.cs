using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_WAP
{
    [Serializable]
    public class Restaurant : IComparable, ICloneable
    {
        public string Nume { get; set; }

        public string Locatie { get; set; }

        public List<Reservation> Reservations { get; set; }

        public Restaurant(string _nume, string _locatie, List<Reservation> _reservations)
        {
            this.Nume = _nume;
            this.Locatie = _locatie;
            this.Reservations = _reservations;
        }

        public int CompareTo(Restaurant obj)
        {
            if (this.Nume[0] < obj.Nume[0])
            {
                return 1;
            }
            return 0;
        }

        public int CompareTo(object? obj)
        {
            throw new NotImplementedException();
        }

        public object Clone()
        {
            Restaurant restaurant = (Restaurant)this.MemberwiseClone();

            List<Reservation> Reservations = new List<Reservation>();

            foreach(Reservation _reservation in Reservations)
            {
                Reservations.Add(_reservation);
            }

            restaurant.Reservations = Reservations;

            return restaurant;
        }
    }
}
