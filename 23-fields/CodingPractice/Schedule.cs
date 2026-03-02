using System;
using System.Threading.Channels;

class Schedule {
    private string[] _weekDays = {"Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

    public void PrintWeekDays() {
        foreach (var weekDay in _weekDays) {
            Console.Write($"{weekDay}\t");
        }
    }
}