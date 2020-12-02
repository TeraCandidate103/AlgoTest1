using System;
using System.Diagnostics;

namespace SumMultiples
{
    class Tester
    {
        private readonly IAdder adder;
        public Tester(IAdder adder)
        {
            this.adder = adder;
        }
        public void go()
        {
            test(2, 0); // = 0
            test(3, 3); // = 0 + 3
            test(5, 8); // = 0 + 3 + 5
            test(10, 33); // = 0 + 3 + 5 + 6 + 9 + 10
            test(15, 60); // = 0 + 3 + 5 + 6 + 9 + 10 + 12 + 15
            test(20, 98); // = 0 + 3 + 5 + 6 + 9 + 10 + 12 + 15 + 18 + 20
            test(100, 2418); // ...
            test(1000, 234168);
            test(1000*1000, 1405932684);
            test(1000*1000*1000, 1631780268);
        }

        private void test(int maxint, int expected_result)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            int result = adder.addAll(maxint);
            sw.Stop();
            if (result != expected_result)
            {
                Console.WriteLine($"result ({result}) is not matching expected {expected_result}");
            }
            if (sw.ElapsedMilliseconds > 1)
            {
                Console.WriteLine($"elapsed time {sw.ElapsedMilliseconds}");
            }
        }
    }
}