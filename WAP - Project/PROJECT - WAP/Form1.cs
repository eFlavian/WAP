using PROJECT___WAP.Entities;
using System.ComponentModel;
using System.Runtime.Serialization.Formatters.Binary;

namespace PROJECT___WAP
{

    public partial class HOTLAP : Form
    {
        RouteContext rtx;
        DriverContext dtx;
        ShippingContext stx;
        public enum VehicleType { Sprinter_100Kg, Minivan_300Kg, Truck_500Kg, HeavyCargo_5000Kg }
        public List<string> SelectHrs = new List<string>();
        public List<Route> routeListinitial = new List<Route>();
        public List<Route> routeListfinal = new List<Route>();

        public HOTLAP()
        {
            InitializeComponent();
            rtx=new RouteContext();
            dtx=new DriverContext();
            stx=new ShippingContext();
            menuStrip1.Renderer = new NewColourRenderer();

            for(int i=1;i<9;i++)
            SelectHrs.Add(i+" Hours");

            Driver_MaxHours_combox.DataSource = SelectHrs;
            Driver_Vehicle_ComboBox.DataSource = Enum.GetValues(typeof(VehicleType)); // fill the combobox

        }

        private void x_untap_MouseEnter(object sender, EventArgs e)
        {
            x_tap.Visible=true;
            x_tap.BringToFront();
        }

        private void x_tap_MouseLeave(object sender, EventArgs e)
        {
            x_untap.Visible=true;
            x_untap.BringToFront();
        }


        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void HOTLAP_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void min_tap_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState= FormWindowState.Minimized;
        }

        private void x_tap_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void min_untap_MouseEnter(object sender, EventArgs e)
        {
            min_tap.Visible=true;
            min_tap.BringToFront();
        }

        private void min_tap_MouseLeave(object sender, EventArgs e)
        {

            min_untap.Visible=true;
            min_untap.BringToFront();
        }

        public class MyColorTable : ProfessionalColorTable
        {
            private Color menuItemSelectedColor;
            public MyColorTable(Color color) : base()
            {
                menuItemSelectedColor = color;
            }
            public override Color MenuItemSelected
            {
                get { return menuItemSelectedColor; }
            }
        }

        //private void importToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        //{
        //    importToolStripMenuItem.ForeColor=Color.White;
            
        //}

        //private void importToolStripMenuItem_EnabledChanged(object sender, EventArgs e)
        //{
        //    importToolStripMenuItem.BackColor = Color.White;
        //}

        //private void importToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        //{
        //    importToolStripMenuItem.ForeColor = Color.Black;
        //}

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void driverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowRoute(false);
            ShowDriver(true);
            if (telluswasshown==1)
            {
                Route_tellusaboutyou.Visible=true;
                Route_tellusaboutyou.BringToFront();
            }
        }

        int telluswasshown = 0;

        private void Driver_Check_Click(object sender, EventArgs e)
        {
            
            string LastName = "";
            string FirstName = "";
            int Age = 33;
            int cnt = 0;
            telluswasshown=0;

            Route_tellusaboutyou.Visible=false;

            if (Driver_LastName_textbox.Text == "" || Driver_LastName_textbox.Text == " " || Driver_LastName_textbox.Text == null)
            {
                errorProvider_LastName.SetError(Driver_LastName_textbox, "You must have a.. first name?");
            }
            else
            {
                cnt++;
                LastName = Driver_LastName_textbox.Text;
                errorProvider_LastName.Clear();
            }




            if (Driver_FirstName_textbox.Text == "")
            {
                errorProvider_FirstName.SetError(Driver_FirstName_textbox, "You must have a.. last name?");
            }
            else
            {
                cnt++;
                FirstName = Driver_FirstName_textbox.Text;
                errorProvider_FirstName.Clear();
            }




            if (Driver_Age_textbox.Text == "" || Int32.Parse(Driver_Age_textbox.Text) < 18)
            {
                errorProvider_Age.SetError(Driver_Age_textbox, "You need to be over 18 years old.");
            }
            else
            {
                cnt++;
                Age = Int32.Parse(Driver_Age_textbox.Text);
                errorProvider_Age.Clear();
            }


            if (cnt == 3)
            {
                wasShown=1;
                int MaxHours = Driver_MaxHours_combox.SelectedIndex+1;

                VehicleType vt = (VehicleType)Driver_Vehicle_ComboBox.SelectedItem;

                //Driver driver = new Driver(LastName, FirstName, Age, MaxHours, (Entities.VehicleType)vt);

                //String msg = driver.LastName + driver.FirstName + driver.Age + driver.MaxHours + driver.Vehicle; // testing
                //MessageBox.Show(msg);

                if (NoMatchingResults_label.Visible==true)
                {
                    NoMatchingResults_label.Visible=false;
                    NoMatchingResults_label.SendToBack();
                }
                backgroundWorker1.RunWorkerAsync();
                dataGridView1.Visible=false; 
                Route_tellusaboutyou.Visible=false;
                loading_picturebox.BringToFront();
                loading_picturebox.Visible=true;

                loadbinding();



                routeListfinal.Clear();

                foreach (Route route in routeListinitial)
                {
                    int time = (int)route.Length/75;
                    int time_to_bepassed = 0;

                    if (Driver_MaxHours_combox.SelectedValue.Equals("1 Hours"))
                        time_to_bepassed = 1;
                    if (Driver_MaxHours_combox.SelectedValue.Equals("2 Hours"))
                        time_to_bepassed = 2;
                    if (Driver_MaxHours_combox.SelectedValue.Equals("3 Hours"))
                        time_to_bepassed = 3;
                    if (Driver_MaxHours_combox.SelectedValue.Equals("4 Hours"))
                        time_to_bepassed = 4;
                    if (Driver_MaxHours_combox.SelectedValue.Equals("5 Hours"))
                        time_to_bepassed = 5;
                    if (Driver_MaxHours_combox.SelectedValue.Equals("6 Hours"))
                        time_to_bepassed = 6;
                    if (Driver_MaxHours_combox.SelectedValue.Equals("7 Hours"))
                        time_to_bepassed = 7;
                    if (Driver_MaxHours_combox.SelectedValue.Equals("8 Hours"))
                        time_to_bepassed = 8;

                    if (Driver_Vehicle_ComboBox.SelectedValue.Equals(VehicleType.Sprinter_100Kg))
                    {
                        if (route.TotalWeight<100 && time<time_to_bepassed)
                            routeListfinal.Add(route);
                    }
                    if (Driver_Vehicle_ComboBox.SelectedValue.Equals(VehicleType.Minivan_300Kg))
                    {
                        if (route.TotalWeight<300 && time<time_to_bepassed)
                            routeListfinal.Add(route);
                    }
                    if (Driver_Vehicle_ComboBox.SelectedValue.Equals(VehicleType.Truck_500Kg))
                    {
                        if (route.TotalWeight<500 && time<time_to_bepassed)
                            routeListfinal.Add(route);
                    }
                    if (Driver_Vehicle_ComboBox.SelectedValue.Equals(VehicleType.HeavyCargo_5000Kg))
                    {
                        if (route.TotalWeight<5000 && time<time_to_bepassed)
                            routeListfinal.Add(route);
                    }
                }
                List<Route> RouteSortedListFinal = routeListfinal.OrderByDescending(o => o.Payment).ToList();// sortare lista finala si biding

                routeBindingSourceDriver.DataSource = RouteSortedListFinal;
                dataGridView1.Visible=false;
            }

        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            System.Threading.Thread.Sleep(2000);

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            loading_picturebox.SendToBack();
            loading_picturebox.Visible=false;


            if (dataGridView1.Rows.Count > 1)
            {
                dataGridView1.Visible=true;
                dataGridView1.BringToFront();
            }
            else
            {
                NoMatchingResults_label.Visible=true;
                NoMatchingResults_label.BringToFront();
            }
            updateRoutes1();
            updateRoutes2();
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            toolStripMenuItem8.DropDown.Show();
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Visible == true)
                wasShown = 1;
            if (Route_tellusaboutyou.Visible==true)
                telluswasshown=1;
            Route_tellusaboutyou.Visible=false;

            ShowDriver(false);
            ShowRoute(true);

            updateRoutes1();
            updateRoutes2();

        }

        int wasShown = 0;

        void ShowDriver(bool x)
        {
            updateRoutes1();
            updateRoutes1();
            if (wasShown == 1 && x==true)
            dataGridView1.Visible=true;

            if (wasShown == 0 && x==true)
                dataGridView1.Visible=false;

            Driver_Overlay.Visible=x;
            Driver_LastName_label.Visible=x;
            Driver_LastName_textbox.Visible=x;
            Driver_FirstName_textbox.Visible=x; 
            Driver_FirstName_label.Visible =x;
            Driver_Age_label.Visible=x;
            Driver_Age_textbox.Visible=x;
            Driver_Vehicle_label.Visible=x;
            Driver_Vehicle_ComboBox.Visible=x;
            Driver_Check.Visible=x;
            Driver_Sign.Visible=x;
            Driver_Database_Overlay.Visible=x;
            Driver_MaxHours_label.Visible=x;
            Driver_MaxHours_combox.Visible=x;
            Driver_Overlay.Text="Driver";
            Driver_Database_Overlay.Text="Available Routes";
            NoMatchingResults_label.Visible=false;
            dataGridView3.Visible=false;
            pictureBox2.Visible=false;
            pictureBox3.Visible=false;
            clicktofire.Visible=false;

        }

        void ShowRoute(bool x)
        {
            if (dataGridView1.Visible==true)
                wasShown=1;
            dataGridView1.Visible=false;
            dataGridView2.Visible=x;
            Driver_Overlay.Visible=x;
            Driver_Database_Overlay.Visible=x;
            Route_Destination_textbox.Visible=x;
            Route_Destination_label.Visible=x;
            Route_StartingPoint_textbox.Visible=x;
            Route_StartingPoint_label.Visible=x;
            Route_Length_label.Visible=x;
            Route_length_textbox.Visible=x;
            Route_CostPerKM_textbox.Visible=x;
            Route_CostPerKM_label.Visible=x;
            Route_Payment_label.Visible=x;
            Route_Payment_textbox.Visible=x;
            Route_TotalWeight_label.Visible=x;
            Route_TotalWeight_textbox.Visible=x;
            Route_ADD.Visible=x;
            Route_DELETE.Visible=x;
            //Route_Refresh.Visible=x; 
            ExportOptions.Visible=x;
            toolStrip1.Visible=x;
            Driver_Overlay.Text="Route Data";
            Driver_Database_Overlay.Text="Routes";
            errorProvider_Age.Clear();
            errorProvider_FirstName.Clear();
            errorProvider_LastName.Clear();
            dataGridView3.Visible=false;
            pictureBox2.Visible=false;
            pictureBox3.Visible=false;
            clicktofire.Visible=false;

        }

        private void loadbinding() // sortare lista initiala si biding
        {

            routeListinitial = rtx.Routes.ToList();
            List<Route> RouteSortedListInitial = routeListinitial.OrderByDescending(o => o.Payment).ToList();//objListOrder.OrderBy(o => o.OrderDate).ToList();
            routeBindingSourceRoutes.DataSource = RouteSortedListInitial;

        }

        private void HOTLAP_Load(object sender, EventArgs e)
        {
            loadbinding();

            updateRoutes1();
            updateRoutes2();
            //SORT : this.dataGridView2.Sort(this.dataGridView2.Columns[5],System.ComponentModel.ListSortDirection.Descending);
        }

        private void Route_TotalWeight_label_Click(object sender, EventArgs e)
        {

        }

        private void Route_ADD_Click(object sender, EventArgs e)
        {
            int cnt = 0;

            if(Route_Destination_textbox.Text == "")
            {
            }
            else
            {
                cnt++;
            }
            if (Route_StartingPoint_textbox.Text == "")
            {

            }
            else
            {
                cnt++;
            }
            if (Route_length_textbox.Text == "")
            {

            }
            else
            {
                cnt++;
            }
            if (Route_CostPerKM_textbox.Text == "")
            {

            }
            else
            {
                cnt++;
            }
            if (Route_TotalWeight_textbox.Text == "")
            {

            }
            else
            {
                cnt++;
            }
            if (Route_Payment_textbox.Text == "")
            {
                
            }
            else
            {
                cnt++;
            }


            if (cnt == 6)
            {
                if (dataGridView2.SelectedRows.Count != 0)
                {
                    Route target = routeBindingSourceRoutes.Current as Route;
                    target.Destination=Route_Destination_textbox.Text;
                    target.StartingPoint=Route_StartingPoint_textbox.Text;
                    target.Length = float.Parse(Route_length_textbox.Text);
                    target.CostPerKM=Int32.Parse(Route_CostPerKM_textbox.Text);
                    target.Payment = float.Parse(Route_Payment_textbox.Text);
                    target.TotalWeight = float.Parse(Route_TotalWeight_textbox.Text);


                    rtx.Routes.Update(target);
                }
                else
                {
                    rtx.Routes.Add(new Route() { Destination=Route_Destination_textbox.Text, StartingPoint=Route_StartingPoint_textbox.Text, Length = float.Parse(Route_length_textbox.Text), CostPerKM=Int32.Parse(Route_CostPerKM_textbox.Text), Payment = float.Parse(Route_Payment_textbox.Text), TotalWeight = float.Parse(Route_TotalWeight_textbox.Text) });

                }
                rtx.SaveChanges();

                routeBindingSourceRoutes.DataSource = rtx.Routes.ToList();

                updateRoutes2();

            }
            else
            {
                MessageBox.Show("Please fill all the fields.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Route_DELETE_Click(object sender, EventArgs e)
        {

            if (dataGridView2.SelectedRows.Count != 0)
            {
                if (MessageBox.Show("Are you sure?", "Delete entry", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    rtx.Routes.Remove(routeBindingSourceRoutes.Current as Route);
                    rtx.SaveChanges();

                    routeBindingSourceRoutes.DataSource = rtx.Routes.ToList();
                }
            }
            else
            {

                MessageBox.Show("Please select a route (row).", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void updateRoutes2()
        {
            int cnt = 0;
            int totalnorows = dataGridView2.Rows.Count;
            try
            {
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    cnt++;
                    if (cnt < totalnorows)
                    {
                        if (Int32.Parse(row.Cells[5].Value.ToString()) > 2000)
                        {
                            row.DefaultCellStyle.BackColor = Color.LightGreen;
                            row.DefaultCellStyle.ForeColor = Color.Black;
                        }
                        if (Int32.Parse(row.Cells[5].Value.ToString()) > 4000)
                        {
                            row.DefaultCellStyle.BackColor = Color.LimeGreen;
                            row.DefaultCellStyle.ForeColor = Color.Black;
                        }
                        if (Int32.Parse(row.Cells[5].Value.ToString()) > 6000)
                        {
                            row.DefaultCellStyle.BackColor = Color.SeaGreen;
                            row.DefaultCellStyle.ForeColor = Color.Black;
                        }
                        if (Int32.Parse(row.Cells[5].Value.ToString()) > 8000)
                        {
                            row.DefaultCellStyle.BackColor = Color.Green;
                            row.DefaultCellStyle.ForeColor = Color.Black;
                        }
                        if (Int32.Parse(row.Cells[5].Value.ToString()) > 12000)
                        {
                            row.DefaultCellStyle.BackColor = Color.DarkGreen;
                            row.DefaultCellStyle.ForeColor = Color.Black;
                        }
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        public void updateRoutes1()
        {
            int cnt = 0;
            int totalnorows = dataGridView1.Rows.Count;
            try
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    cnt++;
                    if (cnt < totalnorows)
                    {
                        if (Int32.Parse(row.Cells[5].Value.ToString()) > 2000)
                        {
                            row.DefaultCellStyle.BackColor = Color.LightGreen;
                            row.DefaultCellStyle.ForeColor = Color.Black;
                        }
                        if (Int32.Parse(row.Cells[5].Value.ToString()) > 4000)
                        {
                            row.DefaultCellStyle.BackColor = Color.LimeGreen;
                            row.DefaultCellStyle.ForeColor = Color.Black;
                        }
                        if (Int32.Parse(row.Cells[5].Value.ToString()) > 6000)
                        {
                            row.DefaultCellStyle.BackColor = Color.SeaGreen;
                            row.DefaultCellStyle.ForeColor = Color.Black;
                        }
                        if (Int32.Parse(row.Cells[5].Value.ToString()) > 8000)
                        {
                            row.DefaultCellStyle.BackColor = Color.ForestGreen;
                            row.DefaultCellStyle.ForeColor = Color.Black;
                        }
                        if (Int32.Parse(row.Cells[5].Value.ToString()) > 10000)
                        {
                            row.DefaultCellStyle.BackColor = Color.Green;
                            row.DefaultCellStyle.ForeColor = Color.Black;
                        }
                        if (Int32.Parse(row.Cells[5].Value.ToString()) > 12000)
                        {
                            row.DefaultCellStyle.BackColor = Color.DarkGreen;
                            row.DefaultCellStyle.ForeColor = Color.Black;
                        }
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void dataGridView2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && dataGridView2.SelectedRows.Count != 0)
            {
                Route_Destination_textbox.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
                Route_StartingPoint_textbox.Text = dataGridView2.SelectedRows[0].Cells[2].Value.ToString();
                Route_length_textbox.Text = dataGridView2.SelectedRows[0].Cells[3].Value.ToString();
                Route_CostPerKM_textbox.Text = dataGridView2.SelectedRows[0].Cells[4].Value.ToString();
                Route_Payment_textbox.Text = dataGridView2.SelectedRows[0].Cells[5].Value.ToString();
                Route_TotalWeight_textbox.Text = dataGridView2.SelectedRows[0].Cells[6].Value.ToString();
            }
        }

        private void Route_Refresh_Click(object sender, EventArgs e)
        {

            updateRoutes2();
            updateRoutes1();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            int indextobeadded = dataGridView1.CurrentCell.RowIndex;

            if (MessageBox.Show("Do you want to be registered as a driver on this transport?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                MessageBox.Show("Drive safe!", "Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                /// salvez driver ul si ii atribui cursa respectiva

                string LastName = Driver_LastName_textbox.Text;
                string FirstName = Driver_FirstName_textbox.Text;
                int Age = Int32.Parse(Driver_Age_textbox.Text);
                //int MaxHours = Int32.Parse(Driver_MaxHours_combox.SelectedValue.ToString());
                Entities.VehicleType Vehicle = (Entities.VehicleType)Driver_Vehicle_ComboBox.SelectedValue;

                string Destination = dataGridView1.Rows[indextobeadded].Cells[1].Value.ToString();
                string StartingPoint = dataGridView1.Rows[indextobeadded].Cells[2].Value.ToString();
                int Payment = Int32.Parse(dataGridView1.Rows[indextobeadded].Cells[5].Value.ToString());



                stx.Shippings.Add(new Shipping() { LastName=LastName, FirstName=FirstName, Vehicle=Vehicle, Age=Age, Destination=Destination, StartingPoint=StartingPoint, Payment=Payment, Date=DateTime.Now });
                stx.SaveChanges();
                shippingBindingSource.DataSource = stx.Shippings.ToList();


            }
        }

        private void HOTLAP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.A)
            {
                this.toolStripMenuItem8_Click(sender,e);
            }

        }


        private void viewCurrentShippingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Route_tellusaboutyou.Visible==true)
                telluswasshown=1;
            Route_tellusaboutyou.Visible=false;
            routeBindingSourceRoutes.DataSource=rtx.Routes.ToList();
            //driverBindingSource.DataSource = dtx.Drivers.ToList();
            shippingBindingSource.DataSource = stx.Shippings.ToList();
            loadbinding();
            ShowRoute(false);
            ShowDriver(false);
            Driver_Database_Overlay.Visible=true;
            Driver_Database_Overlay.Text="Current shippings";
            dataGridView3.Visible=true;
            dataGridView3.BringToFront();
            Driver_Overlay.Visible=true;
            Driver_Overlay.FlatStyle=FlatStyle.Flat;
            Driver_Overlay.Text="";
            pictureBox2.Visible=true;
            pictureBox3.Visible=true;
            clicktofire.Visible=true;
            pictureBox2.BringToFront();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void driversThatLookedForJobsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm2 = new Chart(routeListinitial);
            frm2.ShowDialog();
            
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.Visible=true;
            pictureBox3.BringToFront();
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Visible=true;
            pictureBox2.BringToFront();
        }

        private void Driver_Sign_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                int indextobeadded = dataGridView1.CurrentCell.RowIndex;

                if (MessageBox.Show("Do you want to be registered as a driver on this transport?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    MessageBox.Show("Take care on the road!", "Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    /// salvez driver ul si ii atribui cursa respectiva

                    string LastName = Driver_LastName_textbox.Text;
                    string FirstName = Driver_FirstName_textbox.Text;
                    int Age = Int32.Parse(Driver_Age_textbox.Text);
                    //int MaxHours = Int32.Parse(Driver_MaxHours_combox.SelectedValue.ToString());
                    Entities.VehicleType Vehicle = (Entities.VehicleType)Driver_Vehicle_ComboBox.SelectedValue;

                    string Destination = dataGridView1.Rows[indextobeadded].Cells[1].Value.ToString();
                    string StartingPoint = dataGridView1.Rows[indextobeadded].Cells[2].Value.ToString();
                    int Payment = Int32.Parse(dataGridView1.Rows[indextobeadded].Cells[5].Value.ToString());



                    stx.Shippings.Add(new Shipping() { LastName=LastName, FirstName=FirstName, Vehicle=Vehicle, Age=Age, Destination=Destination, StartingPoint=StartingPoint, Payment=Payment, Date=DateTime.Now });
                    stx.SaveChanges();
                    shippingBindingSource.DataSource = stx.Shippings.ToList();



                }
            }
            else
            {
                MessageBox.Show("Please select a row with the route you want to take.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toTextToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text File | *.txt";
            saveFileDialog.Title = "Save as text file";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                {
                    sw.WriteLine("ID,Destination,StartingPoint,Length,CostPerKM,Payment,TotalWeight");

                    foreach (DataGridViewRow row in dataGridView2.Rows)
                    {
                        for (int i = 0; i < row.Cells.Count; i++)
                        {
                            sw.Write(row.Cells[i].Value + " ");
                        }
                        sw.WriteLine("");
                    }
                }
            }
        }

        private void toBinaryToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Binary File | *.bin";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                BinaryFormatter formatter = new BinaryFormatter();
                using (FileStream fs = File.Create(dialog.FileName))
                {
                    formatter.Serialize(fs, routeBindingSourceRoutes.DataSource);
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // delete record from shippings.

            if (dataGridView3.SelectedRows.Count != 0)
            {
                if (MessageBox.Show("Are you sure you want to.. fire him?", "Firing process", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    stx.Shippings.Remove(shippingBindingSource.Current as Shipping);
                    stx.SaveChanges();

                    shippingBindingSource.DataSource = stx.Shippings.ToList();
                }
            }
            else
            {
                MessageBox.Show("Please select an entire row.", "Selection problem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void printSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pageSetupDialogRoutes.PageSettings = printDocumentRoutes.DefaultPageSettings;

            if (pageSetupDialogRoutes.ShowDialog() == DialogResult.OK)
                printDocumentRoutes.DefaultPageSettings = pageSetupDialogRoutes.PageSettings;
        }

        private void printDocumentRoutes_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Initialize the font to be used for printing.
            Font font = new Font("Microsoft Sans Serif", 24);

            var pageSettings = e.PageSettings;

            // Initialize local variables that contain the bounds of the printing area rectangle.
            //var printAreaHeight = pageSettings.PaperSize.Height - pageSettings.Margins.Top - pageSettings.Margins.Bottom;
            //or
            var printAreaHeight = e.MarginBounds.Height;

            //var printAreaWidth = pageSettings.PaperSize.Width - pageSettings.Margins.Left - pageSettings.Margins.Right;
            //or
            var printAreaWidth = e.MarginBounds.Width;

            // Initialize local variables to hold margin values that will serve
            // as the X and Y coordinates for the upper left corner of the printing 
            // area rectangle.
            var marginLeft = pageSettings.Margins.Left;
            // X coordinate
            var marginTop = pageSettings.Margins.Top;
            // Y coordinate

            // If the user selected Landscape mode, swap the printing area height 
            // and width.
            if (pageSettings.Landscape)
            {
                var intTemp = printAreaHeight;
                printAreaHeight = printAreaWidth;
                printAreaWidth = intTemp;
            }

            const int rowHeight = 40;
            var columnWidth = printAreaWidth / 3;

            // Instantiate the StringFormat class, which encapsulates text layout 
            // information (such as alignment and line spacing), display manipulations 
            // (such as ellipsis insertion and national digit substitution) and OpenType 
            // features. Use of StringFormat causes MeasureString and DrawString to use
            // only an integer number of lines when printing each page, ignoring partial
            // lines that would otherwise likely be printed if the number of lines per 
            // page do not divide up cleanly for each page (which is usually the case).
            // See further discussion in the SDK documentation about StringFormatFlags.
            StringFormat fmt = new StringFormat(StringFormatFlags.LineLimit);
            fmt.Trimming = StringTrimming.EllipsisCharacter;

            var currentY = marginTop;

            foreach (Route ruta in routeListfinal)
            {
                //Reset the horizontal drawing coordinate
                var currentX = marginLeft;

                //Draw the border of the cell
                e.Graphics.DrawRectangle(
                    Pens.Black,
                    currentX,
                    currentY,
                    columnWidth,
                    rowHeight);
                //Draw the text in the cell
                /*e.Graphics.DrawString(
                    _participants[i].FirstName,
                    font,
                    Brushes.Black,
                    currentX,
                    currentY,
                    fmt);*/
                // By specifying a LayoutRectangle, we are forcing the text into a specific area, with automatic word wrapping and other features controllable through the StringFormat parameter
                e.Graphics.DrawString(
                    ruta.ID.ToString(),
                    font,
                    Brushes.Black,
                    new RectangleF(currentX, currentY, columnWidth, rowHeight),
                    fmt);
                //Update the horizontal drawing coordinate
                currentX += columnWidth;

                e.Graphics.DrawRectangle(
                    Pens.Black,
                    currentX,
                    currentY,
                    columnWidth,
                    rowHeight);

                e.Graphics.DrawString(
                    ruta.Destination,
                    font,
                    Brushes.Black,
                    currentX,
                    currentY,
                    fmt);
                currentX += columnWidth;

                e.Graphics.DrawRectangle(
                    Pens.Black,
                    currentX,
                    currentY,
                    columnWidth,
                    rowHeight);
                e.Graphics.DrawString(
                    ruta.StartingPoint.ToString(),
                    font,
                    Brushes.Black,
                    currentX,
                    currentY,
                    fmt);

                //Update the participant index
                //Update the vertifcal drawing coordinate
                currentY += rowHeight;

                // HasMorePages tells the printing module whether another PrintPage event should be fired.
                if (currentY + rowHeight > printAreaHeight)
                {
                    e.HasMorePages = true;
                    break;
                }
            }
        }

        private void printDocumentRoutes_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                printPreviewDialogRoutes.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("An error occurred while trying to load the document for Print Preview. Make sure you currently have access to a printer. A printer must be connected and accessible for Print Preview to work.");
            }
        }

        private void printToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            if (printDialogRoutes.ShowDialog() == DialogResult.OK)
                printDocumentRoutes.Print();
        }
    }

    public class MyColours : ProfessionalColorTable
    {
        public override Color MenuItemSelected
        {
            get { return Color.Gray; }
        }
        public override Color MenuItemSelectedGradientBegin
        {
            get { return Color.Gray; }
        }
        public override Color MenuItemSelectedGradientEnd
        {
            get { return Color.Gray; }
        }

        public override Color MenuItemPressedGradientBegin
        {
            get { return Color.Gray; }
        }

        public override Color MenuItemPressedGradientEnd
        {
            get { return Color.Gray; }
        }
        public override Color MenuItemBorder
        {
            get { return Color.DimGray; }
        }
    }
    public class NewColourRenderer : ToolStripProfessionalRenderer
    {
        public NewColourRenderer() : base(new MyColours()) { }
    }

}


// order by profitability index nu by payment.
// imparte length ul la 75km/h si vezi cate ore ia fiecare transport. in felul asta arati sau nu (ca la vehicletype) anumite row uri. in functie de cate ore e dispus sa lucreze.



// Resources
// Move the window random by dragging it : https://www.codeproject.com/Articles/11114/Move-window-form-without-Titlebar-in-C
// Colors of menustrip: https://stackoverflow.com/questions/33047004/how-do-i-change-the-default-back-colors-of-a-toolstripmenuitem-when-hovered-and
// Linq list sort: https://stackoverflow.com/questions/3309188/how-to-sort-a-listt-by-a-property-in-the-object