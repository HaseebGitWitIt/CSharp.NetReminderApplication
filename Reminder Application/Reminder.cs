using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reminder_Application
{
    class Reminder
    {
        public String message { get; set; }
        public DateTime time { get; set; }
        public bool repeat { get; set; }
        private String creationDate;
        public Reminder(String message, DateTime time, Boolean repeat, String creationDate)
        {
            this.message = message;
            this.time = time;
            this.repeat = repeat;
            this.creationDate = creationDate;
        }
    }
}
