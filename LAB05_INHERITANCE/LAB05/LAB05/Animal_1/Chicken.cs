using System;
using System.Collections.Generic;
using System.Text;

namespace LAB05
{
    class Chicken: Animals
    {
        private bool canh;

        public Chicken(bool feet, bool eye, bool canh) : base(feet, eye)
        {
            this.canh = canh;
        }

        public void bietBay()
        {

        }

        public void bietVayCanh()
        {

        }
    }
}
