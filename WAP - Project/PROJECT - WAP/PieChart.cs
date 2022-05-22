using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT___WAP
{
    public class PieChart
    {
		public string Description { get; set; }

		public float Percentage { get; set; }

		public Color Color { get; set; }

		public PieChart(string description, float percent, Color color)
		{
			Description = description;
			Percentage = percent;
			Color = color;
		}
	}
}
