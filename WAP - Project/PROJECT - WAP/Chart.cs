using PROJECT___WAP.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT___WAP
{
    public partial class Chart : Form
    {
		public List<Route> routeListfinal = new List<Route>();
		public Chart(List<Route> routeListfinal)
		{
			this.routeListfinal = routeListfinal;
			InitializeComponent();
			//redraws if resized
			ResizeRedraw = true;

			float cnt1 = 0;
			float cnt2 = 0;
			float cnt3 = 0;
			float cnt = 0;

			foreach (Route route in routeListfinal)
            {
				cnt++;

				if (route.StartingPoint == "Bucuresti")
					cnt1++;

				if (route.StartingPoint == "Focsani")
					cnt2++;

				if (route.StartingPoint == "Galati")
					cnt3++;
			}

			float ptg1 = cnt1/cnt*100;
			float ptg2 = cnt2/cnt*100;
			float ptg3 = cnt3/cnt*100;
			int rest = (int)ptg1+(int)ptg2+(int)ptg3;

			//Default data
			Data = new[]
			{
				new PieChart("Bucuresti", (int)ptg1, Color.Red),
				new PieChart("Focsani", (int)ptg2, Color.Blue),
				new PieChart("Galati", (int)ptg2, Color.Green),
				new PieChart("Others", 100-rest, Color.Yellow)
			};
		}

		protected override void OnPaint(PaintEventArgs pe)
		{
			base.OnPaint(pe);
		}
		private PieChart[] _data;
		public PieChart[] Data
		{
			get { return _data; }
			set
			{
				if (_data == value)
					return;

				_data = value;

				//trigger the Paint event
				Invalidate();
			}
		}

		private void Chart_Load(object sender, EventArgs e)
        {

            PieChart[] pieCategories = {
			new PieChart("Gold", 20, Color.Red),
			new PieChart("Stocks", 15, Color.Blue),
			new PieChart("Bonds", 35, Color.Magenta),
			new PieChart("ETFs", 15, Color.YellowGreen),
			new PieChart("Options", (float) 7.5, Color.Tomato),
			new PieChart("Cash", (float) 7.5, Color.Beige)
			};

            pieChartControl1.Data = pieCategories;
        }

        private void pieChartControl1_Paint(object sender, PaintEventArgs e)
        {
				//width reserved for displaying the legend
				int legendWidth = 150;

				//get the drawing context
				Graphics graphics = e.Graphics;
				//get the drqwing area
				Rectangle clipRectangle = e.ClipRectangle;

				//compute the maximum radius
				float radius = Math.Min(clipRectangle.Height, clipRectangle.Width - legendWidth) / (float)2;

				//determine the center of the pie
				int xCenter = (clipRectangle.Width - legendWidth) / 2;
				int yCenter = clipRectangle.Height / 2;

				//determine the x and y coordinate of the pie
				float x = xCenter - radius;
				float y = yCenter - radius;

				//determine the width and the height
				float width = radius * 2;
				float height = radius * 2;

				//draw the pie sectors
				float percent1 = 0;
				float percent2 = 0;
				for (int i = 0; i < Data.Length; i++)
				{
					if (i >= 1)
						percent1 += Data[i - 1].Percentage;

					percent2 += Data[i].Percentage;

					float angle1 = percent1 / 100 * 360;
					float angle2 = percent2 / 100 * 360;

					Brush b = new SolidBrush(Data[i].Color);

					graphics.FillPie(b, x, y, width, height, angle1, angle2 - angle1);
				}

				//draw the pie contour
				Pen pen = new Pen(Color.Black);
				graphics.DrawEllipse(pen, x, y, width, height);

				//draw the chart legend
				float xpos = x + width + 20;
				float ypos = y;
				for (int i = 0; i < Data.Length; i++)
				{
					Brush b = new SolidBrush(Data[i].Color);
					graphics.FillRectangle(b, xpos, ypos, 30, 30);
					graphics.DrawRectangle(pen, xpos, ypos, 30, 30);
					Brush b2 = new SolidBrush(Color.Black);
					graphics.DrawString(Data[i].Description + ": " + Data[i].Percentage + "%",
					Font, b2,
					xpos + 35, ypos + 12);
					ypos += 35;
				}
			
		}
    }
}
