namespace Scheduler
{
	partial class PlusCalenderForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.Check = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.HourLabel = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.HourBox = new System.Windows.Forms.ComboBox();
            this.MinuteBox = new System.Windows.Forms.ComboBox();
            this.MinuteLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(66, 82);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(304, 25);
            this.textBox1.TabIndex = 0;
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(14, 15);
            this.Cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(114, 38);
            this.Cancel.TabIndex = 1;
            this.Cancel.Text = "취소";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Check
            // 
            this.Check.Location = new System.Drawing.Point(256, 13);
            this.Check.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(114, 38);
            this.Check.TabIndex = 2;
            this.Check.Text = "확인";
            this.Check.UseVisualStyleBackColor = true;
            this.Check.Click += new System.EventHandler(this.Check_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(11, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "일정";
            // 
            // HourLabel
            // 
            this.HourLabel.AutoSize = true;
            this.HourLabel.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.HourLabel.Location = new System.Drawing.Point(93, 142);
            this.HourLabel.Name = "HourLabel";
            this.HourLabel.Size = new System.Drawing.Size(29, 19);
            this.HourLabel.TabIndex = 5;
            this.HourLabel.Text = "시";
            this.HourLabel.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(276, 144);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(94, 19);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "하루 종일";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // HourBox
            // 
            this.HourBox.FormattingEnabled = true;
            this.HourBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.HourBox.Location = new System.Drawing.Point(26, 140);
            this.HourBox.Name = "HourBox";
            this.HourBox.Size = new System.Drawing.Size(61, 23);
            this.HourBox.TabIndex = 7;
            this.HourBox.Visible = false;
            // 
            // MinuteBox
            // 
            this.MinuteBox.FormattingEnabled = true;
            this.MinuteBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.MinuteBox.Location = new System.Drawing.Point(143, 140);
            this.MinuteBox.Name = "MinuteBox";
            this.MinuteBox.Size = new System.Drawing.Size(61, 23);
            this.MinuteBox.TabIndex = 8;
            this.MinuteBox.Visible = false;
            // 
            // MinuteLabel
            // 
            this.MinuteLabel.AutoSize = true;
            this.MinuteLabel.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MinuteLabel.Location = new System.Drawing.Point(210, 142);
            this.MinuteLabel.Name = "MinuteLabel";
            this.MinuteLabel.Size = new System.Drawing.Size(29, 19);
            this.MinuteLabel.TabIndex = 9;
            this.MinuteLabel.Text = "분";
            this.MinuteLabel.Visible = false;
            // 
            // PlusCalenderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 203);
            this.Controls.Add(this.MinuteLabel);
            this.Controls.Add(this.MinuteBox);
            this.Controls.Add(this.HourBox);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.HourLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Check);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PlusCalenderForm";
            this.Text = "PlusCalenderForm";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button Cancel;
		private System.Windows.Forms.Button Check;
		private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label HourLabel;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox HourBox;
        private System.Windows.Forms.ComboBox MinuteBox;
        private System.Windows.Forms.Label MinuteLabel;
    }
}