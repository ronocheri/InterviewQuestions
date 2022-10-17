using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions
{
    internal class SingletonImp
    {
        public sealed class MyProgram
        {
            private readonly static object lockObj = new object(); //for thread safe

            private static MyProgram inst = null;

            private MyProgram() { }
            
            public static MyProgram getInstance()
            {
                lock (lockObj)
                    {
                        if (inst == null)
                            inst = new MyProgram();
                    }
                return inst;
            }
        }
        static void Main2(string[] args)
        {
            MyProgram prog1 = MyProgram.getInstance();
            MyProgram prog2 = MyProgram.getInstance();

            Console.WriteLine(prog1 == prog2 ? "Equal" : "Different");


        }
    }
}
