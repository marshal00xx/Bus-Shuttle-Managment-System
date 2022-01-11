using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OffersUC;
using System.Diagnostics;

namespace ClientsBoardUC
{
    public partial class clientBoardUC: UserControl
    {
        public clientBoardUC()
        {
            InitializeComponent();
        }

        private void clientBoardUC_Load(object sender, EventArgs e) {
            try {
                offerUC offerUc = new offerUC();
                //offerUc.signedIn = true;
                searchNdBookPanel.Controls.Add(offerUc);
                offerUc.Dock = DockStyle.Fill;
            }
            catch(Exception ex) {
                Debug.WriteLine(ex.Message);
            }
        }
    }
}
