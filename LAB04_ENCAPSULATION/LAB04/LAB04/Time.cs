using System;
using System.Collections.Generic;
using System.Text;

namespace LAB04
{
    class Time
    {
        private byte second;
        private byte minute;
        private byte hours;

        public Time ()
        {

        }

        public Time (byte hours, byte minute, byte second)
        {
            this.second = second;
            this.minute = minute;
            this.hours = hours;
        }

        public byte Second
        {
            get => second;
            set
            {
                if (value >= 0 && value <60)
                {
                    second = value;
                }
            }
        }
        public byte Minute
        {
            get => minute;
            set
            {
                if (value >= 0 && value < 60)
                {
                    minute = value;
                }
            }
        }

        public byte Hours
        {
            get => hours;
            set
            {
                if (value >= 0 && value < 24)
                {
                    hours = value;
                }
            }
        }

        public void Show12Hours()
        {
            if (hours > 12)
                Console.WriteLine("{0}:{1}:{2} PM", hours % 12, Minute, Second);
            else
                Console.WriteLine("{0}:{1}:{2} AM", hours, Minute, Second);
        }

        public void Show24Hours()
        {
            Console.WriteLine("{0}:{1}:{2}", hours, Minute, Second);
        }

        public void Add1Second()
        {
            second += 1;
            if (second ==60)
            {
                second = 0;
                minute++;
            }
            if (minute ==60)
            {
                minute = 0;
                hours++;
            }
            if (hours == 24)
                hours = 0;
        }
    }
}
