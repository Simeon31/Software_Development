using System;
using System.Collections.Generic;
using System.Text;

namespace On_Time_For_Exam.Model
{
    class On_Time
    {
        private int examHour;
        private int examMinutes;
        private int examTimeInMinutes;

        public On_Time(int examHour, int examMinutes)
        {
            this.examHour = examHour;
            this.examMinutes = examMinutes;
            examTimeInMinutes = examHour * 60 + examMinutes;
        }

        public int ExamTimeInMinutes
        {
            get
            {
                return examTimeInMinutes;
            }
            private set
            {
                examTimeInMinutes = value;
            }
        }
        public int ExamHour
        {
            get
            {
                return examHour;
            }
            private set
            {
                examHour = value;
            }
        }
        public int ExamMinutes
        {
            get
            {
                return examMinutes;
            }
            private set
            {
                examMinutes = value;
            }
        }
    }
}
