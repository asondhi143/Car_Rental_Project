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
    public partial class Form1 : Form
    {
        DataTable vt = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }
        public void dbfun(string str)
        {
            string constr = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=ProjectTables.accdb";
            string sqlstr = str;
            OleDbDataAdapter da = new OleDbDataAdapter(sqlstr, constr);
            da.Fill(vt);
            da.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int x = 50;
            this.dbfun("SELECT CarModel FROM CarsData WHERE StockQuantity > 0");
            foreach (DataRow row in vt.Rows)
            {

                Button btnCar = new Button();
                btnCar.Text = row["CarModel"].ToString();
                btnCar.Name = "btn" + row["CarModel"].ToString();
                btnCar.Location = new Point(x, 530);
                btnCar.Size = new Size(145, 50);
                btnCar.BackColor = Color.Black;
                btnCar.ForeColor = Color.White;
                btnCar.Click += new EventHandler(carModelBtn_Click);
                this.Controls.Add(btnCar);
                x += 155;
            }
        }
        private void carModelBtn_Click(object sender, EventArgs e)
        {
            Button clickedBtn = (Button)sender;
            string selectedCar = clickedBtn.Text;
            this.Hide();
            FormCarInfo form2 = new FormCarInfo(selectedCar);
            form2.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
