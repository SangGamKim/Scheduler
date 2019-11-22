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
    public partial class DailyCalendarForm : Form
    {
        private Button[] _arrButton = new Button[10];
        private Label[] _arrLabel = new Label[10];

        private Date _date;
        private MainCalendarForm _prevForm;

        public DailyCalendarForm(Date date, MainCalendarForm form)
        {
            InitializeComponent();

            #region 버튼 등록
            int index = 2;
            for (int i = 0; i < _arrButton.Length; i++)
            {
                for (int y = 0; y < this.Controls.Count; y++)
                {
                    if (this.Controls[y].TabIndex == index)
                    {
                        _arrButton[i] = this.Controls[y] as Button;
                        index++;
                    }
                }
            }
            #endregion

            #region 라벨 등록
            index = 12;
            for (int i = 0; i < _arrLabel.Length; i++)
            {
                for (int y = 0; y < this.Controls.Count; y++)
                {
                    if (this.Controls[y].TabIndex == index)
                    {
                        _arrLabel[i] = this.Controls[y] as Label;
                        index++;
                    }
                }
            }
            #endregion

            _date = date;

            DailyFormMainLabel.Text = _date.Year + "-" + _date.Month + "-" + _date.Day;

            _prevForm = form;

            Renewal();
        }

        public void Renewal()
        {
            var list = CalendarManager.Instance.GetList(_date);

            for (int i = 0; i < list.Count; i++)
            {
                _arrButton[i].Text = list[i].CalendarName;
                _arrButton[i].Visible = true;

                if (list[i].Time.IsLive)
                {
                    _arrLabel[i].Text = list[i].Time.Hour.ToString() + " : " + list[i].Time.Minute.ToString();
                    _arrLabel[i].Visible = true;
                }
				else
				{
					_arrLabel[i].Visible = false;
				}
			}
            for (int i = list.Count; i < _arrButton.Length; i++)
            {
                _arrButton[i].Visible = false;
                _arrLabel[i].Visible = false;
            }
        }

        private void PlusCalendar_Click(object sender, EventArgs e)
        {
            PlusCalenderForm form = new PlusCalenderForm(_date, this);

            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog();
        }

        private void ClickCalendar(object sender, EventArgs e)
        {
			Button btn = sender as Button;

			ChangeCalendarForm form = new ChangeCalendarForm(_date, btn.Text, this);

            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog();
        }

        private void DailyCalendarForm_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            _prevForm.RenewalDateTime();
        }
    }
}
