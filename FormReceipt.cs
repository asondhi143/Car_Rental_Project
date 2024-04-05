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
    public partial class FormReceipt : Form
    {
        DataTable BookingTable = new DataTable();
        DataTable CarTable = new DataTable();
        DataTable CustomerTable = new DataTable();
        private string BookingID, customerID, carID, firstName, lastName, telephone, carType, model, pickup, dropoff, totalcost, cardnumber;
        public FormReceipt(string BookingID)
        {
            InitializeComponent();
            this.BookingID = BookingID;
        }
        private void FormReceipt_Load(object sender, EventArgs e)
        {
            this.dbfun($"SELECT * FROM Bookings WHERE BookingID = {BookingID}", BookingTable);
            DataRow bookingRow = BookingTable.Rows[0];
            this.customerID = bookingRow["CustomerID"].ToString();
            this.carID = bookingRow["CarID"].ToString();
            this.pickup = bookingRow["PickupDate"].ToString();
            this.dropoff = bookingRow["DropOffDate"].ToString();
            this.totalcost = bookingRow["TotalCost"].ToString();
            this.dbfun($"SELECT * FROM CarsData WHERE CarID ={this.carID}",CarTable);
            DataRow carRow = CarTable.Rows[0];
            this.carType = carRow["CarType"].ToString();
            this.model = carRow["CarModel"].ToString();
            this.dbfun($"SELECT * FROM CustomerInfo WHERE CustomerID = {this.customerID}",CustomerTable);
            DataRow customerRow = CustomerTable.Rows[0];
            this.firstName = customerRow["FirstName"].ToString();
            this.lastName = customerRow["LastName"].ToString();
            this.telephone = customerRow["TelephoneNumber"].ToString();
            this.cardnumber = customerRow["CardNumber"].ToString();

            lblPickupDate.Text = pickup;
            lblDropOffDate.Text = dropoff;
            lblBookingID.Text = BookingID;
            lblCarID.Text = carID;
            lblCarModel.Text = model;
            lblCarType.Text = carType;
            lblFName.Text = firstName;
            lblLName.Text = lastName;
            lblPhNumber.Text = telephone;
            lblCost.Text = "$" +  totalcost;

            if (cardnumber.Length >= 4)
            {
                string lastFourChars = cardnumber.Substring(cardnumber.Length - 4);
                string maskedText = new string('X', cardnumber.Length - 4) + lastFourChars;
                lblCardNumber.Text = maskedText;
            }
            else
            {
                string maskedText = new string('X', cardnumber.Length);
                lblCardNumber.Text = maskedText;
            }
        }
        public void dbfun(string str,DataTable table)
        {
            string constr = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=ProjectTables.accdb";
            string sqlstr = str;
            OleDbDataAdapter da = new OleDbDataAdapter(sqlstr, constr);
            da.Fill(table);
            da.Dispose();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
