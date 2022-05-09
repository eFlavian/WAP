using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_WAP
{
    public partial class Form3 : Form
    {
        // rezervation list
        new List<Reservation> Reservations;
        // index la care modif valoarea in rezervation list
        public int index=0;
        public Form3(List<Reservation> Reservations, int index)
        {
            this.Reservations = Reservations;
            this.index = index;
            InitializeComponent();
        }

        private void EDITEAZA_Click(object sender, EventArgs e)
        {

            int local = 0;
            foreach (Reservation r in Reservations)
            {
                local++;
                if (local == index)
                {
                    r.Nume = nume_txt.Text;
                    r.Data = dateTimePicker.Value;
                    r.NoPersons = Int32.Parse(No_Persons_txt.Text);
                }
            }
            Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            int local = 0;
            foreach (Reservation r in Reservations)
            {
                local++;
                if (local == index)
                {
                    nume_txt.Text = r.Nume.ToString();
                    dateTimePicker.Value = r.Data;
                    No_Persons_txt.Text = r.NoPersons.ToString();
                }
            }
        }
    }
}
