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
    struct DayCollection
    {
        public Button Button;
        public Label CalendarNameLabel;
        public Label CalendarCountLabel;
    }

    public partial class MainCalendarForm : Form
    {
        private DayCollection[] _arrDay = new DayCollection[42];

        private int _currentYear = DateTime.Now.Year;
        private int _currentMonth = DateTime.Now.Month;

        public MainCalendarForm()
        {
            InitializeComponent();

            #region DayCollection 등록
            int buttonIndex = 10;
            int nameLabelIndex = 54;
            int countLabelIndex = 55;
            for (int i = 0; i < _arrDay.Length; i++)
            {
                for (int y = 0; y < this.Controls.Count; y++)
                {
                    if (this.Controls[y].TabIndex == buttonIndex)
                    {
                        _arrDay[i].Button = this.Controls[y] as Button;
                        buttonIndex++;
                    }
                    if (this.Controls[y].TabIndex == nameLabelIndex)
                    {
                        _arrDay[i].CalendarNameLabel = Controls[y] as Label;
                        nameLabelIndex += 2;
                    }
                    if (this.Controls[y].TabIndex == countLabelIndex)
                    {
                        _arrDay[i].CalendarCountLabel = Controls[y] as Label;
                        countLabelIndex += 2;
                    }
                }
            }
            #endregion

            PrintDateTime();
        }

        private void DayButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < _arrDay.Length; i++)
            {
                if (sender.Equals(_arrDay[i].Button))
                {
                    DailyCalendarForm form = new DailyCalendarForm(new Date(_currentYear, _currentMonth, int.Parse(_arrDay[i].Button.Text)), this);

                    form.StartPosition = FormStartPosition.CenterParent;
                    form.ShowDialog();
                    break;
                }
            }

        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            ++_currentMonth;
            if (_currentMonth > 12) { _currentMonth = 1; ++_currentYear; }

            PrintDateTime();
        }

        private void PrevButton_Click(object sender, EventArgs e)
        {
            --_currentMonth;
            if (_currentMonth < 1) { _currentMonth = 12; --_currentYear; }

            PrintDateTime();
        }


        private void PrintDateTime()
        {
            _monthLable.Text = _currentMonth.ToString();
            _yearLable.Text = _currentYear.ToString();

            RenewalDateTime();
        }
        public void RenewalDateTime()
        {
            int dayNum = DateTime.DaysInMonth(_currentYear, _currentMonth);
            int startDay = 0;

            DateTime date = new DateTime(_currentYear, _currentMonth, 1);

            switch (date.DayOfWeek)
            {
                case DayOfWeek.Sunday: { startDay = 0; } break;
                case DayOfWeek.Monday: { startDay = 1; } break;
                case DayOfWeek.Tuesday: { startDay = 2; } break;
                case DayOfWeek.Wednesday: { startDay = 3; } break;
                case DayOfWeek.Thursday: { startDay = 4; } break;
                case DayOfWeek.Friday: { startDay = 5; } break;
                case DayOfWeek.Saturday: { startDay = 6; } break;
                default: break;
            }

            int day = 1;
            for (int i = startDay; i < dayNum + startDay; i++)
            {
                Date temp = new Date(_currentYear, _currentMonth, day);

                var list = CalendarManager.Instance.GetList(temp);

                if (list.Count > 0)
                {
                    _arrDay[i].CalendarNameLabel.Visible = true;
                    _arrDay[i].CalendarNameLabel.Text = list[0].CalendarName;
                }
                else
                {
                    _arrDay[i].CalendarCountLabel.Visible = false;
                    _arrDay[i].CalendarNameLabel.Visible = false;
                }

                if (list.Count > 1)
                {
                    _arrDay[i].CalendarCountLabel.Visible = true;
                    _arrDay[i].CalendarCountLabel.Text = "+" + (list.Count - 1).ToString();
                }


                _arrDay[i].Button.Text = day++.ToString();
                _arrDay[i].Button.Enabled = true;
            }

            for (int i = 0; i < startDay; i++)
            {
                _arrDay[i].Button.Text = "";
                _arrDay[i].Button.Enabled = false;

                _arrDay[i].CalendarNameLabel.Visible = false;
                _arrDay[i].CalendarCountLabel.Visible = false;
            }

            for (int i = dayNum + startDay; i < _arrDay.Length; i++)
            {
                _arrDay[i].Button.Text = "";
                _arrDay[i].Button.Enabled = false;

                _arrDay[i].CalendarNameLabel.Visible = false;
                _arrDay[i].CalendarCountLabel.Visible = false;
            }
        }
    }
}
