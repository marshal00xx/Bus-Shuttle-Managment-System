using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Diagnostics;

namespace VallidateSubscriptionUC
{
    public partial class validateNewSubscription: UserControl
    {
        public static String connectionString = ConfigurationManager.ConnectionStrings["busShuttleLab"].ConnectionString;
        SqlConnection connection = new SqlConnection(connectionString);

        private static String _companyId;
        private static decimal _costPerSeat;
        private static int _nbrPassengers;
        private static String _clientId;
        private static Label _label;
        private static String _paymentOption;
        public String clientId { set { _clientId = value; } }
        public String companyId { set { _companyId = value; } }
        public decimal costPerSeat { set { _costPerSeat = value; } }
        public int nbrPassengers { set { _nbrPassengers = value; } }
        public Label label { set { _label = value; } }
        public validateNewSubscription()
        {
            InitializeComponent();
        }
        private void validateNewSubscription_Load(object sender, EventArgs e) {
            _label.Visible = false;
            loadData();
        }
        private void subscribeBtn_Click(object sender, EventArgs e) {
            if (_paymentOption != null) {
                try {
                    using (SqlConnection connection = new SqlConnection(connectionString)) {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand()) {
                            command.Connection = connection;
                            command.CommandText = "usp_insertSubscription";
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@numSubscribres", _nbrPassengers);
                            command.Parameters.AddWithValue("@clientId", _clientId);
                            command.Parameters.AddWithValue("@companyOfferId", _companyId);
                            command.Parameters.AddWithValue("@paymentOption", _paymentOption);
                            command.ExecuteNonQuery();
                            MessageBox.Show("You Subscribed successfully");
                            this.Hide();
                        }
                    }
                }
                catch (Exception ex) {
                    Debug.WriteLine(ex.Message);
                }
            }
            else
                MessageBox.Show("Chose a paymenet option");
        }
        private void loadData() {
            try {
                using (SqlConnection connection = new SqlConnection(connectionString)) {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand()) {
                        command.Connection = connection;
                        command.CommandText = "usp_offerAllDetails";
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@companyOfferId", _companyId);
                        Debug.WriteLine(_companyId);
                        using (SqlDataReader reader = command.ExecuteReader()) {
                            if (reader.Read()) {
                                airconditionerCB.Checked = Convert.ToInt32(reader[0]) == 0 ? false : true;
                                wifiCB.Checked = Convert.ToInt32(reader[1]) == 0 ? false : true;
                                placesLeftLbl.Text += reader[2].ToString();
                            }
                        }
                    }
                    connection.Close();
                }
                //amountLbl.Text += $"{_costPerSeat} * {_nbrPassengers} = {_costPerSeat * _nbrPassengers}";
            }
            catch (Exception ex) {
                Debug.WriteLine(ex.Message);
            }
        }

        private void GoBackBtn_Click(object sender, EventArgs e) {
            this.Hide();
        }

        private void EbtRB_Click(object sender, EventArgs e) {
            _paymentOption = ((RadioButton)sender).Text == "EBT" ? "Electronic bank transfer" : ((RadioButton)sender).Text;
        }
    }
}
