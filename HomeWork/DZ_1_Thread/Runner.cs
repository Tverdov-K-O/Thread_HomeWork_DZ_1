using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using Thread_HomeWork_DZ_1.HomeWork.DZ_1_Thread;

namespace Thread_HomeWork_DZ_1
{
    class Runner
    {
        Fibonachi fibonachi = new Fibonachi(15);
        Factorial factorial = new Factorial(8);

        public void  StartThread()
        {
            //Фибоначчи
            new Thread( () => { fibonachi.Execute(); }).Start();
            //Факториал
            new Thread(()=> { factorial.Execute(); }).Start();
        }
    }
}
