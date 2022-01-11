﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lookForTravelUC;
using ClientMakeOfferUC;

namespace OffersUC
{
    public partial class offerUC: UserControl
    {
        public offerUC()
        {
            InitializeComponent();
        }
        lookingForTravelUC shuttleFinderUC = new lookingForTravelUC();
        private static Boolean _signedIn;
        public Boolean signedIn { get { return _signedIn; } set { _signedIn = value; } }
        private void offerUC_Load(object sender, EventArgs e) {
            addShuttleFinderUC();
        }

        private void addShuttleFinderUC() {
            gunaLinePanel1.Controls.Add(shuttleFinderUC);
            Size size = new Size(334, 344);
            shuttleFinderUC.Size = size;
            Point point = new Point(0, 6);
            shuttleFinderUC.Location = point;
            shuttleFinderUC.dgv = dgv;
            shuttleFinderUC.picBox = pictureBox;
            shuttleFinderUC.signedIn = _signedIn;
            clientMakeOfferUC clientMakeOfferUC = shuttleFinderUC.clientMakeOfferUC;
            point = new Point(347, 39);
            this.Controls.Add(clientMakeOfferUC);
            clientMakeOfferUC.Location = point;
        }
    }
}
