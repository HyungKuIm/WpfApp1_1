using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.ViewModel;
public class CalendarViewModel : BaseViewModel
{
    private List<int> days = Enumerable.Range(1, 30).ToList();

    private int startDay = 0;

    private string yearMonth = string.Empty;

    public CalendarViewModel()
    {
        // 현재 날짜 기준으로 현재 달의 첫날 계산
        DateTime firstDayOfMonth = 
            new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
        DayOfWeek dayOfWeek = firstDayOfMonth.DayOfWeek;
        StartDay = ((int)dayOfWeek);

        // 현재 달의 마지막 날 계산
        int year = DateTime.Now.Year;
        int month = DateTime.Now.Month;
        int daysInMonth = DateTime.DaysInMonth(year, month);
        Days = Enumerable.Range(1, daysInMonth).ToList();

        //
        YearMonth = "2024/11";
    }

    public List<int> Days
    { 
        get { return days; } 
        set { days = value; NotifyPropertyChanged(); }
    }

    public int StartDay
    {
        get { return startDay; }
        set { startDay = value; NotifyPropertyChanged(); }
    }

    public string YearMonth
    {
        get { return yearMonth; }
        set { yearMonth = value; NotifyPropertyChanged(); }
    }
}
