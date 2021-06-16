using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OphthalmologyClinic.App
{
    class GetMonth
    {
        public string Month(string number)
        {
            string Month = "";

            if (number == "1") { Month = "января"; }
            if (number == "2") { Month = "февраля"; }
            if (number == "3") { Month = "марта"; }
            if (number == "4") { Month = "апреля"; }
            if (number == "5") { Month = "мая"; }
            if (number == "6") { Month = "июня"; }
            if (number == "7") { Month = "июля"; }
            if (number == "8") { Month = "августа"; }
            if (number == "9") { Month = "сентября"; }
            if (number == "10") { Month = "октября"; }
            if (number == "11") { Month = "ноября"; }
            if (number == "12") { Month = "декабря"; }

            return Month;
        }
    }
}
