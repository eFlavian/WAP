using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT___WAP.Entities
{
	[Serializable]
	public class Route
    {
        public int ID { get; set; }
		public String Destination { get; set; }
		public String StartingPoint { get; set; }
		public float Length { get; set; }
		public int CostPerKM { get; set; }
		public float Payment { get; set; }
		public float TotalWeight { get; set; }

		public Route()
        {
			this.Destination = "";
			this.StartingPoint ="";
			this.ID=0;
        }

		public float ProfitabilityIndex()
        {
			return this.Payment-(this.CostPerKM*this.Length);
        }

	}
}
