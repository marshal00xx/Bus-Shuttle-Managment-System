namespace ClientMakeOfferUC
{
    partial class clientMakeOfferUC
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(clientMakeOfferUC));
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.placeOrderLbl = new Guna.UI.WinForms.GunaLabel();
            this.placeOrderBTN = new Guna.UI.WinForms.GunaAdvenceButton();
            this.loginLbl = new Guna.UI.WinForms.GunaLabel();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(116)))), ((int)(((byte)(212)))));
            this.gunaLabel1.Location = new System.Drawing.Point(47, 52);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(479, 28);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "There are no offers that meet your requirements,";
            // 
            // placeOrderLbl
            // 
            this.placeOrderLbl.AutoSize = true;
            this.placeOrderLbl.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.placeOrderLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(116)))), ((int)(((byte)(212)))));
            this.placeOrderLbl.Location = new System.Drawing.Point(18, 80);
            this.placeOrderLbl.Name = "placeOrderLbl";
            this.placeOrderLbl.Size = new System.Drawing.Size(550, 28);
            this.placeOrderLbl.TabIndex = 0;
            this.placeOrderLbl.Text = "but you can place an order by clicking the button bellow";
            // 
            // placeOrderBTN
            // 
            this.placeOrderBTN.AnimationHoverSpeed = 0.07F;
            this.placeOrderBTN.AnimationSpeed = 0.03F;
            this.placeOrderBTN.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(116)))), ((int)(((byte)(212)))));
            this.placeOrderBTN.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(116)))), ((int)(((byte)(212)))));
            this.placeOrderBTN.BorderSize = 1;
            this.placeOrderBTN.CheckedBaseColor = System.Drawing.Color.Gray;
            this.placeOrderBTN.CheckedBorderColor = System.Drawing.Color.Black;
            this.placeOrderBTN.CheckedForeColor = System.Drawing.Color.White;
            this.placeOrderBTN.CheckedImage = ((System.Drawing.Image)(resources.GetObject("placeOrderBTN.CheckedImage")));
            this.placeOrderBTN.CheckedLineColor = System.Drawing.Color.DimGray;
            this.placeOrderBTN.DialogResult = System.Windows.Forms.DialogResult.None;
            this.placeOrderBTN.FocusedColor = System.Drawing.Color.Empty;
            this.placeOrderBTN.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.placeOrderBTN.ForeColor = System.Drawing.Color.White;
            this.placeOrderBTN.Image = null;
            this.placeOrderBTN.ImageSize = new System.Drawing.Size(20, 20);
            this.placeOrderBTN.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.placeOrderBTN.Location = new System.Drawing.Point(454, 130);
            this.placeOrderBTN.Name = "placeOrderBTN";
            this.placeOrderBTN.OnHoverBaseColor = System.Drawing.Color.White;
            this.placeOrderBTN.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(116)))), ((int)(((byte)(212)))));
            this.placeOrderBTN.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(116)))), ((int)(((byte)(212)))));
            this.placeOrderBTN.OnHoverImage = null;
            this.placeOrderBTN.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.placeOrderBTN.OnPressedColor = System.Drawing.Color.Black;
            this.placeOrderBTN.Size = new System.Drawing.Size(114, 42);
            this.placeOrderBTN.TabIndex = 1;
            this.placeOrderBTN.Text = "Place Order";
            this.placeOrderBTN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.placeOrderBTN.Click += new System.EventHandler(this.placeOrderBTN_Click);
            // 
            // loginLbl
            // 
            this.loginLbl.AutoSize = true;
            this.loginLbl.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.loginLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(116)))), ((int)(((byte)(212)))));
            this.loginLbl.Location = new System.Drawing.Point(174, 80);
            this.loginLbl.Name = "loginLbl";
            this.loginLbl.Size = new System.Drawing.Size(228, 28);
            this.loginLbl.TabIndex = 2;
            this.loginLbl.Text = "login to place an order";
            // 
            // clientMakeOfferUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.loginLbl);
            this.Controls.Add(this.placeOrderBTN);
            this.Controls.Add(this.placeOrderLbl);
            this.Controls.Add(this.gunaLabel1);
            this.Name = "clientMakeOfferUC";
            this.Size = new System.Drawing.Size(578, 190);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        public Guna.UI.WinForms.GunaLabel loginLbl;
        public Guna.UI.WinForms.GunaAdvenceButton placeOrderBTN;
        public Guna.UI.WinForms.GunaLabel placeOrderLbl;
    }
}
