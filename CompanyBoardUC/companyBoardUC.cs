using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;
using Guna.UI2.WinForms;

namespace CompanyBoardUC
{
    public partial class companyBoardUC : UserControl {
        public companyBoardUC() {
            InitializeComponent();
        }
        private static String _companyId;
        private String _autocarType;
        public String companyid { set { _companyId = value; } }
        public static String connectionString = ConfigurationManager.ConnectionStrings["busShuttleLab"].ConnectionString;
        SqlCommand command = new SqlCommand();

        private void companyBoardUC_Load(object sender, EventArgs e) {
            try {
                command.CommandType = CommandType.StoredProcedure;
                loadCities();
                loadCars();
                loadClinetOffers();
                addVehiculPanel.Hide();
                clientOffersPanel.Hide();
                startDate.MinDate = DateTime.Now;
                endDate.MinDate = DateTime.Now.AddDays(1);
                departTime.Format = DateTimePickerFormat.Custom;
                departTime.CustomFormat = "hh:mm";
                departTime.ShowUpDown = true;

                arrivalTime.Format = DateTimePickerFormat.Custom;
                arrivalTime.CustomFormat = "hh:mm";
                arrivalTime.ShowUpDown = true;
            }
            catch (Exception ex) {
                Debug.WriteLine(ex.Message);
            }
        }
        private void AddAutocarBtn_Click(object sender, EventArgs e) {
            try {
                if (_autocarType != null) {
                    using (SqlConnection connection = new SqlConnection(connectionString)) {
                        connection.Open();
                        command.Connection = connection;
                        command.CommandText = "usp_insertAutocar";
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@companyId", _companyId);
                        command.Parameters.AddWithValue("@autocarTypeName", _autocarType);
                        command.Parameters.AddWithValue("@autocarWifi", wifiCB.Checked ? "1" : "0");
                        command.Parameters.AddWithValue("@autocarAirConditionaire ", airCB.Checked ? "1" : "0");
                        command.ExecuteNonQuery();
                        MessageBox.Show("Vehicul Added Successfuly");
                        loadCars();
                    }
                }
                else
                    MessageBox.Show("pick a type");
            }
            catch (Exception ex) {
                Debug.WriteLine(ex.Message);
            }
        }
        private void addOfferBTN_Click(object sender, EventArgs e) {
            try {
                using (SqlConnection connection = new SqlConnection(connectionString)) {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = "usp_validateCompanyOffer";
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@offerStartDate", startDate.Value);
                    command.Parameters.AddWithValue("@offerEndDate", endDate.Value);
                    command.Parameters.AddWithValue("@origineCity", OriginCityCB.Text);
                    command.Parameters.AddWithValue("@destCity ", destCityCB.Text);
                    command.Parameters.AddWithValue("@offerDepartureTimeGmt ", departTime.Value);
                    command.Parameters.AddWithValue("@offerArrivalTimeGmt ", arrivalTime.Value);
                    command.Parameters.AddWithValue("@offerNumberOfSubscribers ", 0);
                    command.Parameters.AddWithValue("@autocarId ", autoCarCB.Text);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Offer Added Successfuly");

                }
            }
            catch(Exception ex) {
                Debug.WriteLine(ex.Message);
            }
        }
        private void typeRadioBtns_ckeckedChanged(object sender, EventArgs e) {
            _autocarType = ((Guna2RadioButton)sender).Text;
        }

        public void loadCities() {
            try {
                using (SqlConnection connection = new SqlConnection(connectionString)) {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand()) {
                        command.Connection = connection;
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = "usp_getCities";
                        using (SqlDataReader reader = command.ExecuteReader()) {
                            DataTable table = new DataTable();
                            table.Clear();
                            table.Load(reader);
                            OriginCityCB.DataSource = table;
                            OriginCityCB.DisplayMember = "cityName";
                            OriginCityCB.Text = "Origne City";
                            destCityCB.BindingContext = new BindingContext();
                            destCityCB.DataSource = table;
                            destCityCB.DisplayMember = "cityName";
                            OriginCityCB.Text = "Destination City";
                        }
                    }
                }
            }
            catch (Exception ex) {
                Debug.WriteLine(ex.Message);
            }
        }
        private void loadCars() {
            try {
                using (SqlConnection connection = new SqlConnection(connectionString)) {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand()) {
                        command.Connection = connection;
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = "usp_getFreeAutocars";
                        command.Parameters.AddWithValue("@companyId", _companyId);
                        using (SqlDataReader reader = command.ExecuteReader()) {
                            DataTable table = new DataTable();
                            table.Load(reader);
                            autoCarCB.DataSource = table;
                            autoCarCB.DisplayMember = "autocarId";
                        }
                    }
                }
            }
            catch (Exception ex) {
                Debug.WriteLine(ex.Message);
            }
        }
        private void loadClinetOffers() {
            try {
                using (SqlConnection connection = new SqlConnection(connectionString)) {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand()) {
                        command.Connection = connection;
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = "usp_getClinetOffers";
                        using (SqlDataReader reader = command.ExecuteReader()) {
                            DataTable table = new DataTable();
                            table.Load(reader);
                            dgv.DataSource = table;
                        }
                    }
                }
            }
            catch(Exception ex) {
                Debug.WriteLine(ex.Message);
            }
        }
        private void newOfferBtn_Click(object sender, EventArgs e) {
            newOfferPanel.Show();
            addVehiculPanel.Hide();
            clientOffersPanel.Hide();

        }

        private void newVehiculBTN_Click(object sender, EventArgs e) {
            addVehiculPanel.Show();
            newOfferPanel.Hide();
            clientOffersPanel.Hide();
        }

        private void clientOffersBTN_Click(object sender, EventArgs e) {
            clientOffersPanel.Show();
            loadClinetOffers();
            addVehiculPanel.Hide();
            newOfferPanel.Hide();
        }

        private void dgv_MouseClick(object sender, MouseEventArgs e) {
            try{
                if(MessageBox.Show("You wan't to take accept this offer?","Verification", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                    using (SqlConnection connection = new SqlConnection(connectionString)) {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand()) {
                            command.Connection = connection;
                            command.CommandType = CommandType.StoredProcedure;
                            command.CommandText = "usp_getClinetOffers";
                            command.Parameters.AddWithValue("@clientOfferId", dgv.CurrentRow.Cells[0].Value);
                            command.Parameters.AddWithValue("@companyId", _companyId);
                            command.ExecuteNonQuery();
                            MessageBox.Show("Transaction Validated Successfully");
                            loadClinetOffers();
                        }
                    }
                }
            }
            catch(Exception ex) {
                Debug.WriteLine(ex.Message);
            }
        }
    }
}
