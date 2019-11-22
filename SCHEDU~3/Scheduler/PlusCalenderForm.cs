using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scheduler
{
    public partial class PlusCalenderForm : Form
    {
        private Date _date;
        private DailyCalendarForm _prevForm;

        public PlusCalenderForm(Date date, DailyCalendarForm prevForm)
        {
            InitializeComponent();
            _date = date;
            _prevForm = prevForm;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void Check_Click(object sender, EventArgs e)
        {
            string temp = textBox1.Text;

            temp = temp.Trim();

            if (temp.Length == 0) { MessageBox.Show("일정을 입력하세요"); return; }

            if (checkBox1.Checked)
            {
                CalendarManager.Instance.AddCalendar(_date, textBox1.Text);
            }
            else
            {
                Time time = new Time(int.Parse(HourBox.Text), int.Parse(MinuteBox.Text));
                CalendarManager.Instance.AddCalendar(_date, time, textBox1.Text);
            }

            _prevForm.Renewal();

            Dispose();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                HourBox.Visible = false;
                MinuteBox.Visible = false;
                HourLabel.Visible = false;
                MinuteLabel.Visible = false;
            }
            else
            {
                HourBox.Visible = true;
                MinuteBox.Visible = true;
                HourLabel.Visible = true;
                MinuteLabel.Visible = true;

                HourBox.Text = 0.ToString();
                MinuteBox.Text = 0.ToString();
            }
        }
    }
}
