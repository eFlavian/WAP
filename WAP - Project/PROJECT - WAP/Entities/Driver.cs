using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT___WAP.Entities
{
	public enum VehicleType { Sprinter, Minivan, Truck, HeavyCargo}

	[Serializable]
	public class Driver
	{
		public int ID { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public int Age { get; set; }
		public int MaxHours { get; set; }
		public VehicleType Vehicle { get; set; }
		public String Destination { get; set; }
		public String StartingPoint { get; set; }
		public float Payment { get; set; }


	}
}
