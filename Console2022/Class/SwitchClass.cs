using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console2022.TestClass
{
    internal class SwitchClass
    {
        public void showResult()
        {
            int num = 2022; //develop on 2022

            switch(num)
            {
                case 2021: 
                    Console.WriteLine("Previous Year"); 
                    break;

                case 2022:
                    Console.WriteLine("Current Year");
                    break;

                case 2023:
                    Console.WriteLine("Next Year");
                    break;

                default:
                    Console.WriteLine("Not match condition");
                    break;
            }
        }
    }
}
