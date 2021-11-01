using System;
using System.Collections.Generic;
using System.Text;

namespace Lab03
{
    class WorkerManagement
    {
        static void Main ()
        {
            Worker worker1 = new Worker();
            Worker worker2 = new Worker();
            Worker worker3 = new Worker();

            worker1.Input();
            //worker2.Input();
            //worker3.Input();

            worker1.FindWorkplace();
            //worker2.FindWorkplace();
            //worker3.FindWorkplace();

            worker1.Output();
            //worker2.Output();
            //worker3.Output();

        }
    }
}
