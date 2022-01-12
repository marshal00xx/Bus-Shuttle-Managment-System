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
using ClientsBoardUC;
using loginCompanyClientUC;
using ultimateLoginUC;
namespace MainForm {
    public partial class mainController : Form {
        public mainController() {
            InitializeComponent();
        }
        private void mainController_Load(object sender, EventArgs e) {

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
                    point = new Point(2, 61);
                    Panel panel = new Panel();
                    panel.Location = point;
                    Size size = new Size(988, 490);
                    panel.Size = size;
                    panel.Controls.Add(loginUC);
                    loginUC.Dock = DockStyle.Fill;
                    this.Controls.Add(panel);
                    panel.BringToFront();
                    break;
                case "Gallery":
                    clientBoardUC clientBoard = new clientBoardUC();
                    this.Controls.Add(clientBoard);
                    Point point2 = new Point(3, 71);
                    clientBoard.Location = point;
                    clientBoard.Location = point;
                    clientBoard.BringToFront();
                    break;
            }
        }

        private void Btns_Click(object sender, EventArgs e) {
            try {
                switcher(((GunaAdvenceButton)sender).Text);
            }
            catch (Exception ex) {
                Debug.WriteLine(ex.Message);
            }
        }

        private void logo_Click(object sender, EventArgs e) {
            mainController_Load(null, EventArgs.Empty);

        }
    }
}
