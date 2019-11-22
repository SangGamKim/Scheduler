using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

class CalendarManager
{
    private static readonly CalendarManager _instance = new CalendarManager();

    private List<Calendar> _listCalendar = new List<Calendar>();

    private CalendarManager()
    {

    }

    public void AddCalendar(Date date, string name)
    {
        _listCalendar.Add(new Calendar(date, name));
    }
    public void AddCalendar(Date date, Time time, string name)
    {
        _listCalendar.Add(new Calendar(date, time, name));
    }
    public void DeleteCalendar(Calendar calendar)
    {
        _listCalendar.Remove(calendar);
    }

	public Calendar GetCalendar(Date date, string name)
	{
		return _listCalendar.Find((c) => (c.Date == date && c.CalendarName == name));
	}


    public List<Calendar> GetList(Date date)
    {
        List<Calendar> returnValue = new List<Calendar>();

        for (int i = 0; i < _listCalendar.Count; i++)
        {
            if (_listCalendar[i].Date == date)
            {
                returnValue.Add(_listCalendar[i]);
            }
        }

        return returnValue;
    }

    public static CalendarManager Instance { get { return _instance; } }
}
