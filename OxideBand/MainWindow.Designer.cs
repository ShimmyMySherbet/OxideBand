namespace OxideBand
{
    partial class MainWindow
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.flowMidis = new System.Windows.Forms.FlowLayoutPanel();
            this.LblCentreScreen = new System.Windows.Forms.Label();
            this.lblResults = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(3, 5);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(912, 26);
            this.txtSearch.TabIndex = 0;
            // 
            // flowMidis
            // 
            this.flowMidis.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowMidis.AutoScroll = true;
            this.flowMidis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowMidis.Location = new System.Drawing.Point(3, 39);
            this.flowMidis.Name = "flowMidis";
            this.flowMidis.Size = new System.Drawing.Size(912, 457);
            this.flowMidis.TabIndex = 1;
            // 
            // LblCentreScreen
            // 
            this.LblCentreScreen.AutoSize = true;
            this.LblCentreScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCentreScreen.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.LblCentreScreen.Location = new System.Drawing.Point(374, 40);
            this.LblCentreScreen.Name = "LblCentreScreen";
            this.LblCentreScreen.Size = new System.Drawing.Size(169, 25);
            this.LblCentreScreen.TabIndex = 2;
            this.LblCentreScreen.Text = "Nothing but dust";
            // 
            // lblResults
            // 
            this.lblResults.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblResults.AutoSize = true;
            this.lblResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResults.Location = new System.Drawing.Point(2, 497);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(59, 16);
            this.lblResults.TabIndex = 3;
            this.lblResults.Text = "Found: 0";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 517);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.LblCentreScreen);
            this.Controls.Add(this.flowMidis);
            this.Controls.Add(this.txtSearch);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainWindow";
            this.Text = "Oxide Band";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.FlowLayoutPanel flowMidis;
        private System.Windows.Forms.Label LblCentreScreen;
        private System.Windows.Forms.Label lblResults;
    }
}