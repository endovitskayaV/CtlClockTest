namespace CtlClockLibrary
{
    partial class CtlClock
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.OptionsMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSpanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alarmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopwatchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.OptionsMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // OptionsMenuStrip
            // 
            this.OptionsMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modeToolStripMenuItem,
            this.addSpanToolStripMenuItem});
            this.OptionsMenuStrip.Name = "contextMenuStrip1";
            this.OptionsMenuStrip.Size = new System.Drawing.Size(106, 48);
            this.OptionsMenuStrip.Text = "Options";
            // 
            // modeToolStripMenuItem
            // 
            this.modeToolStripMenuItem.Name = "modeToolStripMenuItem";
            this.modeToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.modeToolStripMenuItem.Text = "Mode";
            // 
            // addSpanToolStripMenuItem
            // 
            this.addSpanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.spanToolStripMenuItem,
            this.alarmToolStripMenuItem,
            this.timerToolStripMenuItem,
            this.stopwatchToolStripMenuItem});
            this.addSpanToolStripMenuItem.Name = "addSpanToolStripMenuItem";
            this.addSpanToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.addSpanToolStripMenuItem.Text = "Add";
            // 
            // spanToolStripMenuItem
            // 
            this.spanToolStripMenuItem.Name = "spanToolStripMenuItem";
            this.spanToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.spanToolStripMenuItem.Text = "span";
            // 
            // alarmToolStripMenuItem
            // 
            this.alarmToolStripMenuItem.Name = "alarmToolStripMenuItem";
            this.alarmToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.alarmToolStripMenuItem.Text = "Alarm";
            // 
            // timerToolStripMenuItem
            // 
            this.timerToolStripMenuItem.Name = "timerToolStripMenuItem";
            this.timerToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.timerToolStripMenuItem.Text = "Timer";
            // 
            // stopwatchToolStripMenuItem
            // 
            this.stopwatchToolStripMenuItem.Name = "stopwatchToolStripMenuItem";
            this.stopwatchToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.stopwatchToolStripMenuItem.Text = "Stopwatch";
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(265, 180);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // CtlClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBox);
            this.Name = "CtlClock";
            this.Size = new System.Drawing.Size(285, 196);
            this.OptionsMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip OptionsMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem modeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addSpanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alarmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopwatchToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}
