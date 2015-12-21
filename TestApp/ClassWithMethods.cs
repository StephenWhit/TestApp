using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    public class ClassWithMethods
    {
        public RelayCommand buttonCommand { get; set; }
        public int counter;
        public ClassWithMethods()
        {
            buttonCommand = new RelayCommand(printToConsole);
            counter = 1;
        }

        public void printToConsole(object parameter)
        {
            Console.WriteLine("You clicked me " + counter++ + " times.");
        }
    }
}
