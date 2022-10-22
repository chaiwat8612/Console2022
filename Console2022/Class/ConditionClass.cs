using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console2022.TestClass
{
    internal class ConditionClass
    {
        public void showResult()
        {
            float num = 4.0f;

            if (num == 4)
            {
                Console.WriteLine("matched with first cindition");
            }
            else if (num == 4.0f)
            {
                Console.WriteLine("matched with sencond condition");
            }
            else
            {
                Console.WriteLine("not matched any condition");
            }
        }
    }
}
