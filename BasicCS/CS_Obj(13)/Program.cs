using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Obj_13_
{
    class Target
    {
        public void Do(Source obj)
        {
            Console.WriteLine(obj.GetResult());
        }
    }

    class Source
    {
        public int GetResult()
        {
            return 10;
        }

        public void Test()
        {
            Target target = new Target();
            target.Do(this);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
