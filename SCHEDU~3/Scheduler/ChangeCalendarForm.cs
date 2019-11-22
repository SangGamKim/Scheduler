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
	public partial class ChangeCalendarForm : Form
	{
		private Calendar _calendar;
		private DailyCalendarForm _prevForm;


		public ChangeCalendarForm(Date date, string name, DailyCalendarForm prevForm)
		{
			InitializeComponent();
			_calendar = CalendarManager.Instance.GetCalendar(date, name);
			_prevForm = prevForm;
			Init();
		}

		private void Init()
		{
			textBox1.Text = _calendar.CalendarName;

			if (_calendar.Time.IsLive)
			{
				checkBox1.Checked = false;

				HourBox.Text = _calendar.Time.Hour.ToString();
				MinuteBox.Text = _calendar.Time.Minute.ToString();

				HourBox.Visible = true;
				MinuteBox.Visible = true;
				HourLabel.Visible = true;
				MinuteLabel.Visible = true;
			}
			else
			{
				checkBox1.Checked = true;

				HourBox.Visible = false;
				MinuteBox.Visible = false;
				HourLabel.Visible = false;
				MinuteLabel.Visible = false;
			}
		}

		private void Cancel_Click(object sender, EventArgs e)
		{
			Dispose();
		}

		private void Check_Click(object sender, EventArgs e)
		{
			if (checkBox1.Checked) { CalendarManager.Instance.AddCalendar(_calendar.Date, textBox1.Text); }
			else
			{
				Time time = new Time(int.Parse(HourBox.Text), int.Parse(MinuteBox.Text));
				CalendarManager.Instance.AddCalendar(_calendar.Date, time, textBox1.Text);
			}

			CalendarManager.Instance.DeleteCalendar(_calendar);

			_prevForm.Renewal();

			Dispose();
		}

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            CalendarManager.Instance.DeleteCalendar(_calendar);
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
