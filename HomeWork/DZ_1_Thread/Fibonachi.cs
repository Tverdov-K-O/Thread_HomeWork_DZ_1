using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Thread_HomeWork_DZ_1
{
    class Fibonachi : ICommand
    {
        public int Range { get; set; }
        private int a  = 0;
        private int b  = 1;

        public Fibonachi(int range)
        {
            Range = range;
        }
        void Run()
        {
            for (int i = 0; i <= Range; i++)
            {
                int temp = b;
                b = a;
                a = temp + a;
                Console.WriteLine($"Fibonacci:{b}");
            }
        }


        public event EventHandler CanExecuteChanged;
        public bool CanExecute(object parameter = null) => true; 
        public void Execute(object parameter = null) => Run(); 
    }
}
