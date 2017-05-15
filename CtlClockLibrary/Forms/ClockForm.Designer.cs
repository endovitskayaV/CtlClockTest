namespace WatchPatterns
{
    partial class ClockForm
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
            this.changeModeBtn = new System.Windows.Forms.Button();
            this.constDataLbl = new System.Windows.Forms.Label();
            this.dateLbl = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.eventsBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // changeModeBtn
            // 
            this.changeModeBtn.Location = new System.Drawing.Point(197, 84);
            this.changeModeBtn.Name = "changeModeBtn";
            this.changeModeBtn.Size = new System.Drawing.Size(75, 23);
            this.changeModeBtn.TabIndex = 0;
            this.changeModeBtn.UseVisualStyleBackColor = true;
            this.changeModeBtn.Click += new System.EventHandler(this.changeModeBtn_Click);
            // 
            // constDataLbl
            // 
            this.constDataLbl.AutoSize = true;
            this.constDataLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.constDataLbl.Location = new System.Drawing.Point(207, 9);
            this.constDataLbl.Name = "constDataLbl";
            this.constDataLbl.Size = new System.Drawing.Size(48, 20);
            this.constDataLbl.TabIndex = 1;
            this.constDataLbl.Text = "Date:";
            // 
            // dateLbl
            // 
            this.dateLbl.AutoSize = true;
            this.dateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateLbl.Location = new System.Drawing.Point(194, 38);
            this.dateLbl.Name = "dateLbl";
            this.dateLbl.Size = new System.Drawing.Size(0, 17);
            this.dateLbl.TabIndex = 2;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(12, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(163, 163);
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            // 
            // eventsBtn
            // 
            this.eventsBtn.Location = new System.Drawing.Point(197, 133);
            this.eventsBtn.Name = "eventsBtn";
            this.eventsBtn.Size = new System.Drawing.Size(75, 23);
            this.eventsBtn.TabIndex = 4;
            this.eventsBtn.Text = "Events";
            this.eventsBtn.UseVisualStyleBackColor = true;
            this.eventsBtn.Click += new System.EventHandler(this.EventsBtn_Click);
            // 
            // ClockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(284, 196);
            this.Controls.Add(this.eventsBtn);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.dateLbl);
            this.Controls.Add(this.constDataLbl);
            this.Controls.Add(this.changeModeBtn);
            this.MaximumSize = new System.Drawing.Size(300, 235);
            this.MinimumSize = new System.Drawing.Size(300, 235);
            this.Name = "ClockForm";
            this.Text = "Clock";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button changeModeBtn;
        private System.Windows.Forms.Label constDataLbl;
        private System.Windows.Forms.Label dateLbl;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button eventsBtn;
    }
}

