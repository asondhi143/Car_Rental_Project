using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace CarRentalProject
{
    public partial class FormCarInfo : Form
    {
        private string selectedCar;

        public FormCarInfo(string selectedCar)
        {
            InitializeComponent();
            this.selectedCar = selectedCar;
        }
        private void FormCarInfo_Load(object sender, EventArgs e)
        {
            pictureBoxCars.SizeMode = PictureBoxSizeMode.Zoom;

            string constr = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=ProjectTables.accdb";
            string sqlstr = $"SELECT * FROM CarsData WHERE CarModel='{selectedCar}'";
            OleDbDataAdapter da = new OleDbDataAdapter(sqlstr, constr);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Dispose();

            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                lblCarName.Text = dr["CarType"].ToString() + " - " + dr["CarModel"].ToString();
                lblPrice.Text = "Rent Price: $" + dr["CostPerDay"].ToString() + "/Day";
            }
            else
            {
                MessageBox.Show("No records found.");
            }

            switch (selectedCar)
            {
                case "Challenger2022":
                    challenger();
                    break;
                case "Supra2015":
                    supra();
                    break;
                case "Mustang2019":
                    mustang();
                    break;
                case "Camaro2023":
                    camaro();
                    break;
                case "Aventador2020":
                    aventador();
                    break;
                case "GWagon2017":
                    gwagon();
                    break;
                default:
                    break;
            }
        }
        private void challenger()
        {
            pictureBoxCars.Image = Properties.Resources.Challenger;
            lblFeatures.Text = "Engine: V6 or V8\n\nHorsepower: 303-717\n\nTransmission: 6-speed manual or 8-speed automatic\n\n0-60 mph time: 3.6-6.2 seconds\n\nFuel economy: 13-19 mpg (city), 21-30 mpg (highway)\n\nExtras:\n\n   + Rear-wheel drive\n   + Sport-tuned suspension\n   + Touchscreen infotainment system\n   + Backup camera\n   + Blind-spot monitoring\n   + Parking sensors";                

        }
        private void mustang()
        {
            pictureBoxCars.Image = Properties.Resources.Mustang;
            lblFeatures.Text = "Engine: 5.2-liter V8\n\nHorsepower: 526 hp\n\nTransmission: 6-speed manual \n\n0-60 mph time: 3.5 seconds\n\nFuel economy: 14 mpg (city), 21 mpg (highway)\n\nExtras:\n\n   + Rear-wheel drive\n   + Sport-tuned suspension\n   + 12-inch digital instrument cluster\n   + 8-inch touchscreen Infotainment system\n   + Apple CarPlay/Android Auto\n   + Adaptive cruise control\n   + Blind-spot monitoring";
        }
        private void gwagon()
        {
            pictureBoxCars.Image = Properties.Resources.GWagon;
            lblFeatures.Text = "Engine: Turbocharged 4.0-liter V8\n\nHorsepower: 416 hp\n\nTransmission: 9-speed automatic \n\n0-60 mph time: 5.7 seconds\n\nFuel economy: 13 mpg (city), 17 mpg (highway)\n\nExtras:\n\n   + All-wheel drive\n   + Adaptive suspension\n   + 12.3-inch Digital Instrument Cluster\n   + Touchscreen Infotainment System\n   + Apple CarPlay/Android Auto\n   + Adaptive Cruise Control\n   + Blind-spot monitoring";
        }
        private void aventador()
        {
            pictureBoxCars.Image = Properties.Resources.Aventador;
            lblFeatures.Text = "Engine: 6.5-liter V12\n\nHorsepower: 770 hp\n\nTransmission: 7-speed automatic \n\n0-60 mph time: 2.8 seconds\n\nFuel economy:  9 mpg (city), 16 mpg (highway)\n\nExtras:\n\n   + All-wheel drive\n   + Adaptive Suspension\n   + Digital cluster\n   + 8.4-inch Touchscreen Infotainment system\n   + Apple CarPlay\n   + Collision and Lane-Departure Warning\n   + Adaptive Cruise Control";
        }
        private void camaro()
        {
            pictureBoxCars.Image = Properties.Resources.Camaro;
            lblFeatures.Text = "Engine: Turbocharged 3.6-liter V6\n\nHorsepower: 550 hp\n\nTransmission: 6-speed manual\n\n0-60 mph time: 5.3 seconds\n\nFuel economy:  22 mpg (city), 31 mpg (highway)\n\nExtras:\n\n   + Rear-Wheel Drive\n   + Magnetic Ride Control Suspension\n   + Touchscreen Infotainment System\n   + Backup Camera\n   + Forward-Collision Warning\n   + Rear Cross-Traffic Alert";
        }
        private void supra()
        {
            pictureBoxCars.Image = Properties.Resources.Supra;
            lblFeatures.Text = "Engine: 3.0-liter turbocharged inline-six\n\nHorsepower: 335 hp\n\nTransmission:  8-speed automatic\n\n0-60 mph time: 4.1 seconds\n\nFuel economy:  22 mpg (city), 30 mpg (highway)\n\nExtras:\n\n   + Rear-wheel drive\n   + Adaptive Suspension\n   + 8.8-inch Touchscreen Tnfotainment system\n   + Apple CarPlay/Android Auto\n   + Collision warning and Lane-departure Warning\n   + Adaptive Cruise Control.";
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form = new Form1();
            form.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            this.Close();
            FormBooking form3 = new FormBooking(selectedCar);
            form3.Show();
        }

        private void btnNextImage_Click(object sender, EventArgs e)
        {
            switch (selectedCar)
            {
                case "Challenger2022":
                    pictureBoxCars.Image = Properties.Resources.Challenger2;
                    break;
                case "Supra2015":
                    pictureBoxCars.Image = Properties.Resources.Supra2;
                    break;
                case "Mustang2019":
                    pictureBoxCars.Image = Properties.Resources.Mustang2;
                    break;
                case "Camaro2023":
                    pictureBoxCars.Image = Properties.Resources.Camaro2;
                    break;
                case "Aventador2020":
                    pictureBoxCars.Image = Properties.Resources.Aventador2;
                    break;
                case "GWagon2017":
                    pictureBoxCars.Image = Properties.Resources.GWagon2;
                    break;
                default:
                    break;
            }

        }
        private void btnPreviousImage_Click(object sender, EventArgs e)
        {
            switch (selectedCar)
            {
                case "Challenger2022":
                    pictureBoxCars.Image = Properties.Resources.Challenger;
                    break;
                case "Supra2015":
                    pictureBoxCars.Image = Properties.Resources.Supra;
                    break;
                case "Mustang2019":
                    pictureBoxCars.Image = Properties.Resources.Mustang;
                    break;
                case "Camaro2023":
                    pictureBoxCars.Image = Properties.Resources.Camaro;
                    break;
                case "Aventador2020":
                    pictureBoxCars.Image = Properties.Resources.Aventador;
                    break;
                case "GWagon2017":
                    pictureBoxCars.Image = Properties.Resources.GWagon;
                    break;
                default:
                    break;
            }
        }
    }
}
