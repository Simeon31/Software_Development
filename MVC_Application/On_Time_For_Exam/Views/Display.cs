using System;
using System.Collections.Generic;
using System.Text;

namespace On_Time_For_Exam.Views
{
    class Display
    {
        public int ExamHour { get; set; }
        public int ExamMinutes { get; set; }
        public int HourOfArriving { get; set; }
        public int MinutesOfArriving { get; set; }

        private string onTimeStatus = String.Empty;
        public Display()
        {
            ExamHour = int.Parse(Console.ReadLine());
            ExamMinutes = int.Parse(Console.ReadLine());
            HourOfArriving = int.Parse(Console.ReadLine());
            MinutesOfArriving = int.Parse(Console.ReadLine());
        }

        public string OnTimeStatus
        {
            get; set;
        }
        public void Print()
        {
            Console.WriteLine(OnTimeStatus);
        }
    }
}
