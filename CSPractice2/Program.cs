using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSPractice2
{
    internal class Program
    {

        class Parent
        {
            public int variable = 273;

            public virtual void Method()
            {
                Console.WriteLine("부모 메서드");
            }
        }

        class Child : Parent
        {
            public string variable = "하이딩";

            public new void Method()
            {
                Console.WriteLine("자식 메서드");
            }
        }

        class Child2 : Parent
        {
            public override void Method()
            {
                Console.Write("오버라이드된 자식 메서드");
            }
        }

        static void Main(string[] args)
        {

            // #6 23-7. 섀도잉
            int number = 20;
            Console.WriteLine(number); // 20

            // #6 23-7. 하이딩
            Child child = new Child();
            Console.WriteLine(child.variable); // 하이딩
            child.Method(); // 자식 메서드
            Console.WriteLine(((Parent)child).variable); // 273
            ((Parent)child).Method(); // 부모 메서드
            Parent p = child;
            Console.WriteLine(p.variable); // 273
            p.Method(); // 부모 메서드
            ((Child)p).Method(); // 자식 메서드

            // #6 23-8. 오버라이딩
            Child2 child2 = new Child2();
            child2.Method(); // 오버라이드된 자식 메서드
            ((Parent)child2).Method();
            Parent p2 = child2; 
            p2.Method(); // 오버라이드된 자식 메서드
            ((Child)p2).Method(); // 오버라이드된 자식 메서드
        }
    }
}
