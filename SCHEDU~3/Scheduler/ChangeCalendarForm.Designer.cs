namespace Scheduler
{
	partial class ChangeCalendarForm
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
            this.MinuteLabel = new System.Windows.Forms.Label();
            this.MinuteBox = new System.Windows.Forms.ComboBox();
            this.HourBox = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.HourLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CheckButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MinuteLabel
            // 
            this.MinuteLabel.AutoSize = true;
            this.MinuteLabel.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MinuteLabel.Location = new System.Drawing.Point(210, 155);
            this.MinuteLabel.Name = "MinuteLabel";
            this.MinuteLabel.Size = new System.Drawing.Size(29, 19);
            this.MinuteLabel.TabIndex = 18;
            this.MinuteLabel.Text = "분";
            this.MinuteLabel.Visible = false;
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
            this.MinuteBox.Location = new System.Drawing.Point(143, 152);
            this.MinuteBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinuteBox.Name = "MinuteBox";
            this.MinuteBox.Size = new System.Drawing.Size(61, 23);
            this.MinuteBox.TabIndex = 17;
            this.MinuteBox.Visible = false;
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
            this.HourBox.Location = new System.Drawing.Point(26, 152);
            this.HourBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HourBox.Name = "HourBox";
            this.HourBox.Size = new System.Drawing.Size(61, 23);
            this.HourBox.TabIndex = 16;
            this.HourBox.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(277, 156);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(94, 19);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "하루 종일";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // HourLabel
            // 
            this.HourLabel.AutoSize = true;
            this.HourLabel.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.HourLabel.Location = new System.Drawing.Point(93, 155);
            this.HourLabel.Name = "HourLabel";
            this.HourLabel.Size = new System.Drawing.Size(29, 19);
            this.HourLabel.TabIndex = 14;
            this.HourLabel.Text = "시";
            this.HourLabel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(11, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "일정";
            // 
            // CheckButton
            // 
            this.CheckButton.Location = new System.Drawing.Point(277, 28);
            this.CheckButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(90, 30);
            this.CheckButton.TabIndex = 12;
            this.CheckButton.Text = "확인";
            this.CheckButton.UseVisualStyleBackColor = true;
            this.CheckButton.Click += new System.EventHandler(this.Check_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(14, 28);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(90, 30);
            this.CancelButton.TabIndex = 11;
            this.CancelButton.Text = "취소";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(66, 95);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(303, 25);
            this.textBox1.TabIndex = 10;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(149, 28);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(90, 30);
            this.DeleteButton.TabIndex = 19;
            this.DeleteButton.Text = "삭제";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ChangeCalendarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 202);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.MinuteLabel);
            this.Controls.Add(this.MinuteBox);
            this.Controls.Add(this.HourBox);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.HourLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CheckButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ChangeCalendarForm";
            this.Text = "ChangeCalendarForm";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label MinuteLabel;
		private System.Windows.Forms.ComboBox MinuteBox;
		private System.Windows.Forms.ComboBox HourBox;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Label HourLabel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button CheckButton;
		private System.Windows.Forms.Button CancelButton;
		private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button DeleteButton;
    }
}