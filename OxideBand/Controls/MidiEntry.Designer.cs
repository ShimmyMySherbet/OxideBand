namespace OxideBand.Controls
{
    partial class MidiEntry
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
            this.pbIcon = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblViews = new System.Windows.Forms.Label();
            this.lblPlays = new System.Windows.Forms.Label();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnDownload = new System.Windows.Forms.Button();
            this.pgDownload = new System.Windows.Forms.ProgressBar();
            this.lblDownloadFinished = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pbIcon
            // 
            this.pbIcon.Location = new System.Drawing.Point(4, 5);
            this.pbIcon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.Size = new System.Drawing.Size(258, 159);
            this.pbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIcon.TabIndex = 0;
            this.pbIcon.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(269, 5);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(167, 29);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "TRACK TITLE";
            // 
            // lblViews
            // 
            this.lblViews.AutoSize = true;
            this.lblViews.Location = new System.Drawing.Point(270, 44);
            this.lblViews.Name = "lblViews";
            this.lblViews.Size = new System.Drawing.Size(68, 20);
            this.lblViews.TabIndex = 2;
            this.lblViews.Text = "Views: 0";
            // 
            // lblPlays
            // 
            this.lblPlays.AutoSize = true;
            this.lblPlays.Location = new System.Drawing.Point(372, 44);
            this.lblPlays.Name = "lblPlays";
            this.lblPlays.Size = new System.Drawing.Size(63, 20);
            this.lblPlays.TabIndex = 3;
            this.lblPlays.Text = "Plays: 0";
            // 
            // btnCopy
            // 
            this.btnCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopy.Location = new System.Drawing.Point(697, 136);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(145, 34);
            this.btnCopy.TabIndex = 4;
            this.btnCopy.Text = "Copy Command";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnDownload
            // 
            this.btnDownload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownload.Location = new System.Drawing.Point(593, 136);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(100, 34);
            this.btnDownload.TabIndex = 5;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // pgDownload
            // 
            this.pgDownload.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pgDownload.Location = new System.Drawing.Point(270, 138);
            this.pgDownload.Name = "pgDownload";
            this.pgDownload.Size = new System.Drawing.Size(313, 28);
            this.pgDownload.TabIndex = 6;
            this.pgDownload.Visible = false;
            // 
            // lblDownloadFinished
            // 
            this.lblDownloadFinished.AutoSize = true;
            this.lblDownloadFinished.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDownloadFinished.Location = new System.Drawing.Point(349, 115);
            this.lblDownloadFinished.Name = "lblDownloadFinished";
            this.lblDownloadFinished.Size = new System.Drawing.Size(148, 20);
            this.lblDownloadFinished.TabIndex = 7;
            this.lblDownloadFinished.Text = "Download Finished!";
            this.lblDownloadFinished.Visible = false;
            // 
            // MidiEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblDownloadFinished);
            this.Controls.Add(this.pgDownload);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.lblPlays);
            this.Controls.Add(this.lblViews);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pbIcon);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MidiEntry";
            this.Size = new System.Drawing.Size(845, 173);
            this.Load += new System.EventHandler(this.MidiEntry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbIcon;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblViews;
        private System.Windows.Forms.Label lblPlays;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.ProgressBar pgDownload;
        private System.Windows.Forms.Label lblDownloadFinished;
    }
}
