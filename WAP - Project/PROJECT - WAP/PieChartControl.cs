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
    public partial class PieChartControl : Control
    {
        public PieChartControl()
        {
            InitializeComponent();
            //redraws if resized
            ResizeRedraw = true;

            //Default data
            Data = new[]
            {
                new PieChart("Category 1", 20, Color.Red),
                new PieChart("Category 2", 80, Color.Blue)
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


	}
}
