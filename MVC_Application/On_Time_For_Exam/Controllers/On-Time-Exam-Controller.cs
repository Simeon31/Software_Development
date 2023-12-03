using System;
using System.Collections.Generic;
using System.Text;
using On_Time_For_Exam.Model;
using On_Time_For_Exam.Views;

namespace On_Time_For_Exam.Controllers
{
    class ExamTimeController
    {
        private Display display;
        Student student;
        On_Time exam;

        public ExamTimeController()
        {
            display = new Display();
            student = new Student(display.HourOfArriving, display.MinutesOfArriving);
            exam = new On_Time(display.ExamHour, display.ExamMinutes);

            display.OnTimeStatus = student.CheckOnTimeForExam(exam);
            display.Print();
        }
    }
}
