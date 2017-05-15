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
            this.ctlClock1 = new CtlClockLibrary.CtlClock();
            this.ctlClock2 = new CtlClockLibrary.CtlClock();
            this.SuspendLayout();
            // 
            // ctlClock1
            // 
            this.ctlClock1.BackColor = System.Drawing.Color.White;
            this.ctlClock1.Location = new System.Drawing.Point(13, 3);
            this.ctlClock1.Name = "ctlClock1";
            this.ctlClock1.Size = new System.Drawing.Size(129, 58);
            this.ctlClock1.TabIndex = 0;
            // 
            // ctlClock2
            // 
            this.ctlClock2.BackColor = System.Drawing.Color.White;
            this.ctlClock2.Location = new System.Drawing.Point(34, 97);
            this.ctlClock2.Name = "ctlClock2";
            this.ctlClock2.Size = new System.Drawing.Size(117, 39);
            this.ctlClock2.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.ctlClock2);
            this.Controls.Add(this.ctlClock1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private CtlClockLibrary.CtlClock ctlClock1;
        private CtlClockLibrary.CtlClock ctlClock2;
    }
}

