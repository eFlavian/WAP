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
    public partial class Form2 : Form
    {

        public List<Reservation> Reservations;

        public Form2(List<Reservation> Reservations)
        {
            this.Reservations = Reservations;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            string nume = nume_txt.Text;
            DateTime dateselected = dateTimePicker.Value;
            int nrpers = 0;
            if (No_Persons_txt.Text != "")
            nrpers = Int32.Parse(No_Persons_txt.Text);

            if (nume_txt.Text != "")
            {
                if (nume.Length <= 2)
                {
                    errorProvider1.SetError(nume_txt, "Numele este prea mic");
                }
                else
                {
                    if (nrpers > 0)
                    {

                        Reservation res1 = new Reservation(nume, dateselected, nrpers);
                        //Nume_selected.Text = res1.Nume;
                        //Date_selected.Text = res1.Data.ToString();
                        //Nr_Persoane_Selected.Text = res1.NoPersons.ToString();
                        Reservations.Add(res1);

                        if(res1.IsThisWeek() == true)
                            MessageBox.Show("Rezervarea este facuta pentru urmatoarele 7 zile.");
                        else
                            MessageBox.Show("Rezervarea NU este facuta pentru urmatoarele 7 zile.");

                        //Reservation res2 = (Reservation)res1.Clone();
                        //Reservations.Add(res2);


                        var mainForm = Application.OpenForms.OfType<Form1>().Single();
                        mainForm.refresh_Click(sender, e);

                        Close();
                    }
                    else
                    {
                        errorProvider1.SetError(No_Persons_txt, "Nu poti rezerva o masa pentru nimeni");
                    }
                }
            }
        }

    }
}
