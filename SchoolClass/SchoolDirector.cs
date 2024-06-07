using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClass
{
    public class SchoolDirector
    {
        public string DirectorName { get; set; }

        public DateTime AppointedDate { get; set; }
        public int TeachedYears { get; set; }
        public int MonthlyPay {  get; set; }

        public SchoolDirector(string directorName, DateTime appointedDate, int teachedYears, int monthlyPay) 
        { 
            DirectorName = directorName;
            AppointedDate = appointedDate;
            TeachedYears = teachedYears;
            MonthlyPay = monthlyPay;
        }

        public SchoolDirector()
        {
            DirectorName = string.Empty;
            AppointedDate= DateTime.Now;
            TeachedYears = 0;
            MonthlyPay = 0;
        }

        public override string ToString()
        {
            return $"{DirectorName}(kinevezés: {AppointedDate}, {TeachedYears} éve tanár";
        }
    }
}
