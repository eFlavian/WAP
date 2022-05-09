using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Test_WAP
{
    public partial class Form1 : Form
    {

        public List<Reservation> Reservations = new List<Reservation>();
        public List<Restaurant> Restaurante = new List<Restaurant>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2(Reservations);
            frm2.Show();
        }

        public void refresh_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            dataGridView1.Rows.Clear();
            comboBox1.Items.Clear();

            //listview
            listView1.Items.Clear();
            foreach (Reservation r in Reservations)
            {
                ListViewItem item = new ListViewItem(r.Nume.ToString());
                item.SubItems.Add(r.Data.ToString());
                item.SubItems.Add(r.NoPersons.ToString());

                listView1.Items.Add(item);
            }


            //grid
            dataGridView1.Rows.Clear();
            foreach (Reservation r in Reservations)
            {
                string[] row = new string[] { r.Nume.ToString(), r.Data.ToString(), r.NoPersons.ToString()};
                dataGridView1.Rows.Add(row);
            }

            //combox
            comboBox1.Items.Clear();
            foreach (Reservation r in Reservations)
            {
                comboBox1.Items.Add(r.Data.ToString());
            }

        }

        private void wselected_Click(object sender, EventArgs e)
        {

            foreach (Reservation r in Reservations)
            {
                if(listView1.SelectedItems[0].Text == r.Nume)
                    MessageBox.Show("Clientul " + r.Nume + " are o rezervare la data de " + r.Data + " pentru " + r.NoPersons +" persoane.");
            }
        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            int index = 0;
            
                foreach (Reservation r in Reservations)
                {
                    index++;
                    if (listView1.FocusedItem.Text == r.Nume)
                    {
                       Form3 frm3 = new Form3(Reservations, index);
                       frm3.Show();
                    }
                }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            dataGridView1.Rows.Clear();


            foreach (Reservation r in Reservations)
            {
                ListViewItem item = new ListViewItem(r.Nume.ToString());
                item.SubItems.Add(r.Data.ToString());
                item.SubItems.Add(r.NoPersons.ToString());

                listView1.Items.Add(item);
            }

            int cnt = 0;

            foreach (Reservation r in Reservations)
            {
                string[] row = new string[] { r.Nume.ToString(), r.Data.ToString(), r.NoPersons.ToString() };
                dataGridView1.Rows.Add(row);
                cnt++;
            }
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void serializeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SaveFileDialog dlg = new SaveFileDialog();

            dlg.Filter = "(*.dat)|*.dat";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream fs = new FileStream(dlg.FileName, FileMode.Create, FileAccess.Write);

                bf.Serialize(fs, Reservations.Count);

                foreach (Reservation r in Reservations)
                {
                    bf.Serialize(fs, r.Nume.ToString());
                    bf.Serialize(fs, r.Data.ToString());
                    bf.Serialize(fs, r.NoPersons.ToString());
                }

                fs.Close();
            }
        }

        private void deserializeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "(*.dat)|*.dat";


            if (dlg.ShowDialog() == DialogResult.OK)
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream fs = new FileStream(dlg.FileName, FileMode.Open, FileAccess.Read);

                int nrRezervari = Convert.ToInt32(bf.Deserialize(fs));

                listView1.Items.Clear();
                for (int i = 0; i < nrRezervari; i++)
                {

                    ListViewItem item = new ListViewItem(Convert.ToString(bf.Deserialize(fs)));
                    item.SubItems.Add((Convert.ToString(bf.Deserialize(fs))));
                    item.SubItems.Add((Convert.ToString(bf.Deserialize(fs))));

                    listView1.Items.Add(item);
                }

                fs.Close();
            }
        }

        private void serializeToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            SaveFileDialog dlg = new SaveFileDialog();

            dlg.Filter = "(*.xml)|*.xml";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                XmlSerializer serializer = new XmlSerializer(typeof(string));
                FileStream fs = new FileStream(dlg.FileName, FileMode.Create, FileAccess.Write);

                serializer.Serialize(fs, Reservations.Count.ToString());

                foreach (Reservation r in Reservations)
                {
                    serializer.Serialize(fs, r.Nume.ToString());
                    serializer.Serialize(fs, r.Data.ToString());
                    serializer.Serialize(fs, r.NoPersons.ToString());
                }

                fs.Close();
            }
        }

        private void deserializeToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "(*.xml)|*.xml";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Reservation>));
                FileStream fs = new FileStream(dlg.FileName, FileMode.Open, FileAccess.Read);

                int nrRezervari = Convert.ToInt32(serializer.Deserialize(fs));

                listView1.Items.Clear();
                for (int i = 0; i < nrRezervari; i++)
                {
                    ListViewItem item = new ListViewItem(Convert.ToString(serializer.Deserialize(fs)));
                    item.SubItems.Add((Convert.ToString(serializer.Deserialize(fs))));
                    item.SubItems.Add((Convert.ToString(serializer.Deserialize(fs))));

                    listView1.Items.Add(item);
                }

                fs.Close();
            }
        }
    }
}



/*
 BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream stream = File.Create("serialized.bin"))
            {
                formatter.Serialize(stream, _participants);
            }
BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream stream = File.OpenRead("serialized.bin"))
            {
                _participants = (List<Participant>)formatter.Deserialize(stream);
                DisplayParticipants();
            }
Type type = typeof(List<Participant>);
            XmlSerializer serializer = new XmlSerializer(type);

            using (FileStream stream = File.Create("serialized.xml"))
            {
                serializer.Serialize(stream, _participants);
            }
XmlSerializer serializer = new XmlSerializer(typeof(List<Participant>));

            using (FileStream stream = File.OpenRead("serialized.xml"))
            {
                _participants = (List<Participant>)serializer.Deserialize(stream);
                DisplayParticipants();
            }
*/