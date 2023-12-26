using System;
using System.Collections.Generic;
using System.Text;

namespace On_Time_For_Exam.Model
{
    class Student
    {
        private int arivalHour;
        private int arivalMinutes;
        private int arivalTimeInMinutes;

        public Student(int arivalHour, int arivalMinutes)
        {
            ArivalHour = arivalHour;
            ArivalMintes = arivalMinutes;
            ArivalTimeInMinutes = ArivalHour * 60 + ArivalMintes;
        }

        public int ArivalHour
        {
            get
            {
                return arivalHour;
            }
            private set
            {
                arivalHour = value;
            }
        }
        public int ArivalMintes
        {
            get
            {
                return arivalMinutes;
            }
            private set
            {
                arivalMinutes = value;
            }
        }
        public int ArivalTimeInMinutes
        {
            get
            {
                return arivalTimeInMinutes;
            }
            private set
            {
                arivalTimeInMinutes = value;
            }
        }

        public string CheckOnTimeForExam(On_Time exam)
        {
            int minutesDiff = exam.ExamTimeInMinutes - ArivalTimeInMinutes;
            int hours = 0;
            int minutes = 0;
            if (minutesDiff <= -60)
            {
                minutesDiff = Math.Abs(minutesDiff);
                hours = minutesDiff / 60;
                minutes = minutesDiff % 60;
                return $"Late {hours}:{minutes:D2} hours after the start.";
            }
            if (minutesDiff < 0)
            {
                minutesDiff = Math.Abs(minutesDiff);
                return $"Late {minutesDiff:D2} minutes after the start.";
            }
            if (minutesDiff >= 60)
            {
                hours = minutesDiff / 60;
                minutes = minutesDiff % 60;
                return $"Early {hours}:{minutes:D2} hours before the start.";
            }
            if (minutesDiff > 30)
            {
                return $"Early {minutesDiff:D2} minutes before the start.";
            }
            if (minutesDiff > 0)
            {
                return $"On time {minutesDiff:D2} minutes before the start.";
            }

            return "On time";
        }
    }
}
