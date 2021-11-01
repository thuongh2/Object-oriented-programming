using System;
using System.Collections.Generic;
using System.Text;

namespace LAB05
{
    class Dog: Animals
    {
        private bool tail;

        public Dog (bool tail, bool feet, bool eye): base (feet, eye)
        {
            this.tail = tail;
        }

        public void Bark()
        {

        }

        public void vayDuoi()
        {

        }
    }
}
