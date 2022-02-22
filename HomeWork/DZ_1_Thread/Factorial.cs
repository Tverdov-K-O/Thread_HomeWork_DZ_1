using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Thread_HomeWork_DZ_1.HomeWork.DZ_1_Thread
{
    class Factorial : ICommand
    {
        public int Finish;
        int factrialCount = 1;
        public Factorial(int fin)
        {
            Finish = fin;
        }
        public void Run()
        {
            for (int i = 1; i <= Finish; i++)
            {
                factrialCount = factrialCount * i;
                Console.WriteLine($"Factorial: {factrialCount}");
            }
        }

        public event EventHandler CanExecuteChanged;
        public bool CanExecute(object parameter = null) => true;
        public void Execute(object parameter = null) => Run(); 
    }
}
