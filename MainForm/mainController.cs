using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OffersUC;
using ultimateLoginUC;
namespace MainForm {
    public partial class mainController : Form {
        public mainController() {
            InitializeComponent();
        }
        //
        //
        //
        private void switcher(String buttonText) {
            mainPnl.Visible = false;
            Point point = new Point(12, 128);
            switch (buttonText) {
                case "Companies":
                    /*companiesUC.offerUC companies = new companiesUC.offerUC();
                    this.Controls.Add(companies);
                    companies.Location = point;*/
                    break;
                case "Offers":
                    offerUC _offerUC = new offerUC();
                    this.Controls.Add(_offerUC);
                    _offerUC.Location = point;
                    _offerUC.BringToFront();
                    break;
                case "Login":
                    ultimatelogininUC loginUC = new ultimatelogininUC();
                    this.Controls.Add(loginUC);
                    loginUC.Location = point;
                    loginUC.BringToFront();
                    Debug.WriteLine("afdlkj;lakdfjs");
                    break;
                
            }
        }

        private void gunaPictureBox4_Click(object sender, EventArgs e) {

        }

        private void companiesBtn_Click(object sender, EventArgs e) {
            try {
                switcher(((GunaAdvenceButton)sender).Text);
            }
            catch (Exception ex) {
                Debug.WriteLine(ex.Message);
            }
        }

        private void offersBtn_Click(object sender, EventArgs e) {
            try {
                switcher(((GunaAdvenceButton)sender).Text);
            }
            catch (Exception ex) {
                Debug.WriteLine(ex.Message);
            }
        }

        private void loginBtn_Click(object sender, EventArgs e) {
            try {
                switcher(((GunaAdvenceButton)sender).Text);
            }
            catch (Exception ex) {
                Debug.WriteLine(ex.Message);
            }
        }
    }
}
