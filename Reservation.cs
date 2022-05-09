using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_WAP
{
    [Serializable]
    public class Reservation: ICloneable, IThisWeek
    {
        public string Nume { get; set; }
        public DateTime Data { get; set; }
        public int NoPersons { get; set; }

        public Reservation(string _Nume, DateTime _Data, int _NoPersons)
        {
            this.Nume = _Nume;
            this.Data = _Data;
            this.NoPersons = _NoPersons;
        }

        public Reservation()
        {
            this.Nume = "";
            this.Data = DateTime.Now;
            this.NoPersons = 145;
        }

        public object Clone()
        {
            Reservation reservation = (Reservation)this.MemberwiseClone();
            return reservation;
        }

        public bool IsThisWeek()
        {
            if(this.Data.Day <= DateTime.Now.Day+7)
            {
                return true;
            }
            return false;
        }
    }
}
