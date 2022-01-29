using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _082_as
{
    class Base
    {
        int num;

        public void Print()
        {
            Console.WriteLine("num : {0}", num);
        }

    }

    class AA : Base
    {
        int a;

        public void PrintA()
        {
            Console.WriteLine("a : {0}", a);
        }

    }

    class BB : Base
    {
        int b;

        public void PrintB()
        {
            Console.WriteLine("b : {0}", b);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Base _base = new Base();
            _base.Print();

            Base aa = new AA();
            aa.Print();

            if (aa is BB)
            {
                Console.WriteLine("aa는 BB의 객체입니다.");
            }
            else if(aa is AA)
            {
                Console.WriteLine("aa는 AA의 객체입니다.");
            }

            Base bb = new BB();

            BB copyBB = bb as BB;
            if(null != copyBB)
            {
                Console.WriteLine("------------");
                Console.WriteLine("copyBB는 AA로 형변환");
            }
            else
            {
                Console.WriteLine("------------");
                Console.WriteLine("copyBB는 null");
            }

        }
    }
}
