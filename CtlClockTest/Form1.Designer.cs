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
            this.SuspendLayout();
            // 
            // ctlClock1
            // 
            this.ctlClock1.BackColor = System.Drawing.Color.White;
            this.ctlClock1.Location = new System.Drawing.Point(44, 50);
            this.ctlClock1.Name = "ctlClock1";
            this.ctlClock1.Size = new System.Drawing.Size(285, 196);
            this.ctlClock1.Stopped = true;
            this.ctlClock1.TabIndex = 0;
            this.ctlClock1.TimeOffset = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(372, 343);
            this.Controls.Add(this.ctlClock1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private CtlClockLibrary.CtlClock ctlClock1;
    }
}

