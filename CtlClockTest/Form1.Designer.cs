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
            ((System.ComponentModel.ISupportInitialize)(this.ctlClock1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctlClock2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctlClock3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctlClock4)).BeginInit();
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
            this.ctlClock1.Location = new System.Drawing.Point(51, 12);
            this.ctlClock1.Name = "ctlClock1";
            this.ctlClock1.Size = new System.Drawing.Size(174, 174);
            this.ctlClock1.TabIndex = 4;
            this.ctlClock1.TabStop = false;
            // 
            // ctlClock2
            // 
            this.ctlClock2.BackColor = System.Drawing.Color.White;
            this.ctlClock2.Location = new System.Drawing.Point(247, 12);
            this.ctlClock2.Name = "ctlClock2";
            this.ctlClock2.Size = new System.Drawing.Size(174, 174);
            this.ctlClock2.TabIndex = 5;
            this.ctlClock2.TabStop = false;
            // 
            // ctlClock3
            // 
            this.ctlClock3.BackColor = System.Drawing.Color.White;
            this.ctlClock3.Location = new System.Drawing.Point(427, 12);
            this.ctlClock3.Name = "ctlClock3";
            this.ctlClock3.Size = new System.Drawing.Size(174, 174);
            this.ctlClock3.TabIndex = 6;
            this.ctlClock3.TabStop = false;
            // 
            // ctlClock4
            // 
            this.ctlClock4.BackColor = System.Drawing.Color.White;
            this.ctlClock4.Location = new System.Drawing.Point(607, 12);
            this.ctlClock4.Mode = CtlClockLibrary.CtlClock.ClockMode.Digital;
            this.ctlClock4.Name = "ctlClock4";
            this.ctlClock4.Size = new System.Drawing.Size(174, 174);
            this.ctlClock4.TabIndex = 7;
            this.ctlClock4.TabStop = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.ctlClock1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctlClock2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctlClock3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctlClock4)).EndInit();
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

