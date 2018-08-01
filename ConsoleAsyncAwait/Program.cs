using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleAsyncAwait
{
    class Program
    {
        static void Main(string[] args)
        {
          myMethod();

            Console.WriteLine("Запуск синхронного цикле в методе Main");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("*************");
            }



            Console.ReadLine();
        }




        async static Task myMethod()
        {
            Console.WriteLine("Вызов метода myMethod1('await 1 cycle'); в методе myMethod");
            Task myTask = myMethod1("await 1 cycle");
            Console.WriteLine("Вызов метода myMethod1('await 2 cycle'); в методе myMethod");
            Task myTask2 = myMethod1("await 2 cycle");

            await myTask;
            await myTask2;
        }


        async static Task myMethod1(string s = "Выполняется метод `myMethod1`")
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(200);
                Console.WriteLine(s);
            }
        }


        async static Task SomeCycleAsync()
        {
            var myTask = await ResultOfCycle();

            Console.WriteLine("Dыполнился цикл1 (10000 инкрементов)");
        }
        async static Task<int> ResultOfCycle()
        {
            int sum = 0;
            for (int i = 0; i < 10000; i++)
            {
                sum += i;
            }
            return sum;
        }


    }
}
