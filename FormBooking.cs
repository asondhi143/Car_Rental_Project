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
    public partial class FormBooking : Form
    {
        bool submitted = false;
        private string selectedCar;
        private const string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=ProjectTables.accdb";

        DataTable table = new DataTable();
        public void dbfun(string str)
        {
            string constr = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=ProjectTables.accdb";
            string sqlstr = str;
            OleDbDataAdapter da = new OleDbDataAdapter(sqlstr, constr);
            da.Fill(table);
            da.Dispose();
        }
        public FormBooking(string selectedCar)
        {
            InitializeComponent();
            this.selectedCar = selectedCar;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string telephoneNumber = txtPhnNmbr.Text;
            string cardNumber = txtCardNmbr.Text;
            DateTime pickupDate = datePickFrom.Value;
            DateTime dropOffDate = datePickTo.Value;
            long phoneNum;
            long cardNum;
            bool allConditionsMet = true;

            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(telephoneNumber) || string.IsNullOrEmpty(cardNumber))
            {
                MessageBox.Show("Please fill out all fields.");
                allConditionsMet = false;
            }

            if (!long.TryParse(txtPhnNmbr.Text, out phoneNum) )
            {
                MessageBox.Show("Please enter valid phone number.");
                allConditionsMet = false;
            }

            if (!long.TryParse(txtCardNmbr.Text, out cardNum))
            {
                MessageBox.Show("Please enter valid card number.");
                allConditionsMet = false;
            }

            if (telephoneNumber.Length != 10)
            {
                MessageBox.Show("Please enter a 10-digit phone number.");
                allConditionsMet = false;
            }

            if (cardNumber.Length != 16)
            {
                MessageBox.Show("Please enter a 16-digit card number.");
                allConditionsMet = false;
            }

            if (pickupDate < DateTime.Now.Date)
            {
                MessageBox.Show("Invalid pickup date. Please select a date on or after today's date.");
                allConditionsMet = false;
            }

            if (allConditionsMet)
            {
                try
                {

                    using (OleDbConnection connection = new OleDbConnection(connectionString))
                    {
                        connection.Open();
                        int carID = GetCarID(connection, selectedCar);

                        OleDbCommand command = new OleDbCommand("INSERT INTO Bookings (CarID, CustomerID, PickupDate, DropOffDate, TotalCost) VALUES (@carID, @customerID, @pickupDate, @dropOffDate, @totalCost)", connection);
                        command.Parameters.AddWithValue("@carID", carID);
                        command.Parameters.AddWithValue("@customerID", GetLatestCustomerID(connection));
                        command.Parameters.AddWithValue("@pickupDate", pickupDate.Date);
                        command.Parameters.AddWithValue("@dropOffDate", dropOffDate.Date);
                        command.Parameters.AddWithValue("@totalCost", CalculateTotalCost(carID, pickupDate, dropOffDate));
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Booking data has been saved successfully.");
                        }

                        OleDbCommand command2 = new OleDbCommand("UPDATE CarsData SET StockQuantity = @stockQuantity WHERE CarID = @carID", connection);
                        command2.Parameters.AddWithValue("@stockQuantity", GetStockQuantity(connection, carID) - 1);
                        command2.Parameters.AddWithValue("@carID", carID);
                        command2.ExecuteNonQuery();

                        OleDbCommand command3 = new OleDbCommand("INSERT INTO CustomerInfo (FirstName, LastName, TelephoneNumber, CardNumber) VALUES (@firstName, @lastName, @telephoneNumber, @cardNumber)", connection);
                        command3.Parameters.AddWithValue("@firstName", firstName);
                        command3.Parameters.AddWithValue("@lastName", lastName);
                        command3.Parameters.AddWithValue("@telephoneNumber", telephoneNumber);
                        command3.Parameters.AddWithValue("@cardNumber", cardNumber);
                        int rowsAffected2 = command3.ExecuteNonQuery();
                        if (rowsAffected2 > 0)
                        {
                            MessageBox.Show("Customer data has been saved successfully.");
                            submitted = true;
                        }
                        btnSubmit.Enabled = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while saving customer data: " + ex.Message);
                }
            }

        }
        private int GetCarID(OleDbConnection connection, string carModel)
        {
            OleDbCommand command4 = new OleDbCommand("SELECT CarID FROM CarsData WHERE CarModel = @selectedCar", connection);
            command4.Parameters.AddWithValue("@selectedCar", carModel);
            object result = command4.ExecuteScalar();
            if (result != DBNull.Value && result != null)
            {
                return Convert.ToInt32(result);
            }
            else
            {
                throw new Exception("Invalid car model.");
            }
        }
        private int GetLatestCustomerID(OleDbConnection connection)
        {
            OleDbCommand command5 = new OleDbCommand("SELECT MAX(CustomerID) FROM CustomerInfo", connection);
            object result = command5.ExecuteScalar();
            if (result != DBNull.Value && result != null)
            {
                return Convert.ToInt32(result) + 1;
            }
            else
            {
                return 1;
            }
        }
        private int GetStockQuantity(OleDbConnection connection, int carID)
        {
            OleDbCommand command6 = new OleDbCommand("SELECT StockQuantity FROM CarsData WHERE CarID = @carID", connection);
            command6.Parameters.AddWithValue("@carID", carID);
            object result = command6.ExecuteScalar();
            if (result != DBNull.Value && result != null)
            {
                return Convert.ToInt32(result);
            }
            else
            {
                return 0;
            }
        }
        private decimal CalculateTotalCost(int carID, DateTime pickupDate, DateTime dropOffDate)
        {
            decimal costPerDay;
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                OleDbCommand command7 = new OleDbCommand("SELECT CostPerDay FROM CarsData WHERE CarID = @carID", connection);
                command7.Parameters.AddWithValue("@carID", carID);
                object result = command7.ExecuteScalar();
                if (result != DBNull.Value && result != null)
                {
                    costPerDay = Convert.ToDecimal(result);
                }
                else
                {
                    throw new Exception("Invalid car ID.");
                }
                int numDays = (int)(dropOffDate - pickupDate).TotalDays;
                if (numDays <= 0)
                {
                    throw new Exception("Invalid pickup and drop off dates.");
                }
                Decimal total = costPerDay * numDays;
                return total * Convert.ToDecimal(1.13);

            }
        }
        private void btnViewBooking_Click(object sender, EventArgs e)
        {
            if(submitted == true)
            {
                this.dbfun("SELECT * FROM Bookings ORDER BY BookingID DESC");
                DataRow dr = table.Rows[0];
                string BookingID = dr["BookingID"].ToString();
                this.Close();
                FormReceipt form4 = new FormReceipt(BookingID);
                form4.Show();
            }
        }


    }
}
 