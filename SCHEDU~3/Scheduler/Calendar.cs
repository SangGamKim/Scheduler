using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public struct Date
{
    public int Year;
    public int Month;
    public int Day;

    public Date(int year, int month, int day)
    {
        Year = year;
        Month = month;
        Day = day;
    }

    #region 오류방지
    public override bool Equals(object obj)
    {
        return base.Equals(obj);
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

    public override string ToString()
    {
        return base.ToString();
    }
    #endregion

    public static bool operator ==(Date a, Date b)
    {
        return (a.Year == b.Year && a.Month == b.Month && a.Day == b.Day);
    }

    public static bool operator !=(Date a, Date b)
    {
        return !(a == b);
    }
}

#pragma warning restore CS0660 // 형식은 == 연산자 또는 != 연산자를 정의하지만 Object.Equals(object o)를 재정의하지 않습니다.
#pragma warning restore CS0661 // 형식은 == 연산자 또는 != 연산자를 정의하지만 Object.GetHashCode()를 재정의하지 않습니다.
#pragma warning disable CS0661 // 형식은 == 연산자 또는 != 연산자를 정의하지만 Object.GetHashCode()를 재정의하지 않습니다.
#pragma warning disable CS0660 // 형식은 == 연산자 또는 != 연산자를 정의하지만 Object.Equals(object o)를 재정의하지 않습니다.
public struct Time
{
    public int Hour;
    public int Minute;

    public bool IsLive;

    public Time(int hour, int minute)
    {
        Hour = hour;
        Minute = minute;
        IsLive = true;
    }

    public static bool operator ==(Time a, Time b)
    {
        return (a.Hour == b.Hour && a.Minute == b.Minute);
    }

    public static bool operator !=(Time a, Time b)
    {
        return !(a == b);
    }
}



public class Calendar
{
    private Date _date;
    private Time _time;
    private string _calendarName;


    public Calendar(Date date, string name)
    {
        _date = date;
        _calendarName = name;
        _time.IsLive = false;
    }

    public Calendar(Date date, Time time, string name)
    {
        _date = date;
        _time = time;
        _calendarName = name;
    }


    public Date Date { get { return _date; } }
    public Time Time { get { return _time; } }
    public string CalendarName { get { return _calendarName; } set { _calendarName = value; } }
}
