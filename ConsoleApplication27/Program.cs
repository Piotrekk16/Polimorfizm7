using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication27
{
    public class A
    {
        public void NormalFun() { Console.WriteLine("A NormalFun()"); VirtualFun(); }
        public virtual void VirtualFun() { Console.WriteLine("A VirtualFun()"); VirtualFun2(); }
        public virtual void VirtualFun2() { Console.WriteLine("A VirtualFun2()"); }
    }

    public class B : A
    {
        public void NormalFun() { Console.WriteLine("B NormalFun()"); }
        public virtual void VirtualFun() { Console.WriteLine("B VirtualFun()"); VirtualFun2(); }
        public override void VirtualFun2() { Console.WriteLine("B VirtualFun2()"); NormalFun();  }
    }

    public class C : B
    {
        public override void VirtualFun() { Console.WriteLine("C VirtualFun()"); }
    }

    public class D : C
    {
        public void NormalFun() { Console.WriteLine("D NormalFun()"); }
        public override void VirtualFun() { Console.WriteLine("D VirtualFun()"); VirtualFun2(); }
        public override void VirtualFun2() { Console.WriteLine("D VirtualFun2()"); }
    }

    public abstract class E : D
    {
        public virtual void VirtualFun() { Console.WriteLine("E VirtualFun()"); NormalFun(); }
        public abstract void VirtualFun2();
    }

    public class F : E
    {
        public override void VirtualFun() { Console.WriteLine("F VirtualFun()"); }
        public override void VirtualFun2() { Console.WriteLine("F VirtualFun2()"); }
    }

    public class G : F
    {
        public void NormalFun() { Console.WriteLine("G NormalFun()"); }
        public override void VirtualFun() { Console.WriteLine("G VirtualFun()"); VirtualFun2(); }
        public override void VirtualFun2() { Console.WriteLine("G VirtualFun2()"); }
    }

    public class H : B
    {
        public void NormalFun() { Console.WriteLine("H NormalFun()"); VirtualFun(); }
        public virtual void VirtualFun() { Console.WriteLine("H VirtualFun()"); VirtualFun2(); }
        public virtual void VirtualFun2() { Console.WriteLine("H VirtualFun2()"); }
    }

    public class I : H
    {
        public void NormalFun() { Console.WriteLine("I NormalFun()"); }
        public override void VirtualFun() { Console.WriteLine("I VirtualFun()"); VirtualFun2(); }
        public override void VirtualFun2() { Console.WriteLine("I VirtualFun2()"); }
    }

    public class J : I
    {
        public new void NormalFun() { Console.WriteLine("J NormalFun()"); VirtualFun(); }
        public override void VirtualFun() { Console.WriteLine("J VirtualFun()"); VirtualFun2(); }
        public override void VirtualFun2() { Console.WriteLine("J VirtualFun2()"); }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Tu jest wynik:");
            //tu wkleić kod


            Console.ReadKey();
 
        }
    }
}
