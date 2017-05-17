namespace CtlClockTest
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.ctlClock1 = new CtlClockLibrary.CtlClock();
            this.ctlClock2 = new CtlClockLibrary.CtlClock();
            this.ctlClock3 = new CtlClockLibrary.CtlClock();
            this.ctlClock4 = new CtlClockLibrary.CtlClock();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(51, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ctlClock1
            // 
            this.ctlClock1.BackColor = System.Drawing.Color.White;
            this.ctlClock1.Location = new System.Drawing.Point(12, 12);
            this.ctlClock1.Name = "ctlClock1";
            this.ctlClock1.Size = new System.Drawing.Size(174, 174);
            this.ctlClock1.TabIndex = 4;
            // 
            // ctlClock2
            // 
            this.ctlClock2.BackColor = System.Drawing.Color.White;
            this.ctlClock2.Location = new System.Drawing.Point(253, 25);
            this.ctlClock2.Name = "ctlClock2";
            this.ctlClock2.Size = new System.Drawing.Size(174, 174);
            this.ctlClock2.TabIndex = 5;
            // 
            // ctlClock3
            // 
            this.ctlClock3.BackColor = System.Drawing.Color.White;
            this.ctlClock3.Location = new System.Drawing.Point(457, 25);
            this.ctlClock3.Name = "ctlClock3";
            this.ctlClock3.Size = new System.Drawing.Size(174, 174);
            this.ctlClock3.TabIndex = 6;
            // 
            // ctlClock4
            // 
            this.ctlClock4.BackColor = System.Drawing.Color.White;
            this.ctlClock4.Location = new System.Drawing.Point(665, 126);
            this.ctlClock4.Mode = CtlClockLibrary.CtlClock.ClockMode.Digital;
            this.ctlClock4.Name = "ctlClock4";
            this.ctlClock4.Size = new System.Drawing.Size(174, 174);
            this.ctlClock4.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.ctlClock4);
            this.Controls.Add(this.ctlClock3);
            this.Controls.Add(this.ctlClock2);
            this.Controls.Add(this.ctlClock1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private CtlClockLibrary.CtlClock ctlClock1;
        private CtlClockLibrary.CtlClock ctlClock2;
        private CtlClockLibrary.CtlClock ctlClock3;
        private CtlClockLibrary.CtlClock ctlClock4;
    }
}

