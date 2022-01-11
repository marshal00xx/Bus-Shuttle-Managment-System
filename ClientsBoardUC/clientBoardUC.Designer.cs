namespace ClientsBoardUC
{
    partial class clientBoardUC
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
            this.searchNdBookPanel = new Guna.UI.WinForms.GunaPanel();
            this.SuspendLayout();
            // 
            // searchNdBookPanel
            // 
            this.searchNdBookPanel.Location = new System.Drawing.Point(3, 3);
            this.searchNdBookPanel.Name = "searchNdBookPanel";
            this.searchNdBookPanel.Size = new System.Drawing.Size(981, 414);
            this.searchNdBookPanel.TabIndex = 0;
            // 
            // clientBoardUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.searchNdBookPanel);
            this.Name = "clientBoardUC";
            this.Size = new System.Drawing.Size(987, 421);
            this.Load += new System.EventHandler(this.clientBoardUC_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel searchNdBookPanel;
    }
}
