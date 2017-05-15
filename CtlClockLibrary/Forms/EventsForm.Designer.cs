namespace WatchPatterns
{
    partial class EventsForm
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
            this.addBtn = new System.Windows.Forms.Button();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.showEventsBtn = new System.Windows.Forms.Button();
            this.removeEvent_Btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownH = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownM = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownS = new System.Windows.Forms.NumericUpDown();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.eventsListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownS)).BeginInit();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(24, 118);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 0;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "Alarm",
            "Timer",
            "Stopwatch"});
            this.comboBox.Location = new System.Drawing.Point(31, 72);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(144, 21);
            this.comboBox.TabIndex = 7;
            this.comboBox.SelectedValueChanged += new System.EventHandler(this.comboBox_SelectedValueChanged);
            // 
            // showEventsBtn
            // 
            this.showEventsBtn.Location = new System.Drawing.Point(105, 118);
            this.showEventsBtn.Name = "showEventsBtn";
            this.showEventsBtn.Size = new System.Drawing.Size(75, 23);
            this.showEventsBtn.TabIndex = 9;
            this.showEventsBtn.Text = "Show all";
            this.showEventsBtn.UseVisualStyleBackColor = true;
            this.showEventsBtn.Click += new System.EventHandler(this.showEventsBtn_Click);
            // 
            // removeEvent_Btn
            // 
            this.removeEvent_Btn.Location = new System.Drawing.Point(58, 288);
            this.removeEvent_Btn.Name = "removeEvent_Btn";
            this.removeEvent_Btn.Size = new System.Drawing.Size(75, 23);
            this.removeEvent_Btn.TabIndex = 11;
            this.removeEvent_Btn.Text = "Remove";
            this.removeEvent_Btn.UseVisualStyleBackColor = true;
            this.removeEvent_Btn.Click += new System.EventHandler(this.removeEvent_Btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "h";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Location = new System.Drawing.Point(75, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "m";
            // 
            // numericUpDownH
            // 
            this.numericUpDownH.Location = new System.Drawing.Point(6, 31);
            this.numericUpDownH.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numericUpDownH.Name = "numericUpDownH";
            this.numericUpDownH.Size = new System.Drawing.Size(46, 20);
            this.numericUpDownH.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "s";
            // 
            // numericUpDownM
            // 
            this.numericUpDownM.Location = new System.Drawing.Point(58, 31);
            this.numericUpDownM.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDownM.Name = "numericUpDownM";
            this.numericUpDownM.Size = new System.Drawing.Size(44, 20);
            this.numericUpDownM.TabIndex = 2;
            // 
            // numericUpDownS
            // 
            this.numericUpDownS.Location = new System.Drawing.Point(108, 31);
            this.numericUpDownS.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDownS.Name = "numericUpDownS";
            this.numericUpDownS.Size = new System.Drawing.Size(42, 20);
            this.numericUpDownS.TabIndex = 3;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.numericUpDownS);
            this.groupBox.Controls.Add(this.numericUpDownM);
            this.groupBox.Controls.Add(this.label3);
            this.groupBox.Controls.Add(this.numericUpDownH);
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox.Location = new System.Drawing.Point(24, 2);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(163, 64);
            this.groupBox.TabIndex = 8;
            this.groupBox.TabStop = false;
            // 
            // eventsListBox
            // 
            this.eventsListBox.FormattingEnabled = true;
            this.eventsListBox.Location = new System.Drawing.Point(18, 165);
            this.eventsListBox.Name = "eventsListBox";
            this.eventsListBox.Size = new System.Drawing.Size(163, 108);
            this.eventsListBox.TabIndex = 12;
            // 
            // EventsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(208, 153);
            this.Controls.Add(this.eventsListBox);
            this.Controls.Add(this.removeEvent_Btn);
            this.Controls.Add(this.showEventsBtn);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.addBtn);
            this.MinimumSize = new System.Drawing.Size(214, 192);
            this.Name = "EventsForm";
            this.Text = "Events";
            this.Load += new System.EventHandler(this.EventsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownS)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Button showEventsBtn;
        private System.Windows.Forms.Button removeEvent_Btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownM;
        private System.Windows.Forms.NumericUpDown numericUpDownS;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.ListBox eventsListBox;
    }
}