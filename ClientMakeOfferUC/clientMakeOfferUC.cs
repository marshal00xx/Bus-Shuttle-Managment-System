using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientMakeOfferUC
{
    public partial class clientMakeOfferUC: UserControl
    {
        
        public clientMakeOfferUC()
        {
            InitializeComponent();
        }
        private static Dictionary<String, String> _dico = new Dictionary<string, string>();
        public Dictionary<String, String> dico { set { _dico = value; } }
        public int lk;
        private void placeOrderBTN_Click(object sender, EventArgs e) {

        }
    }
}
