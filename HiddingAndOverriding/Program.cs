using System;
using System.Security.Cryptography.X509Certificates;

class Alpha
{
    public void hello()
    {
        Console.WriteLine("Metod hello() iz classa Alpha");
    }
    public virtual void hi()
    {
        Console.WriteLine("metod Hi() iz classa Alpha");
    }
        public void show()
        {
            hello();
            hi();
            Console.WriteLine();

        }
    }
class Bravo: Alpha
{
    new public void hello()
    {
        Console.WriteLine("Metod hello() iz classa Bravo()");
    }
    public override void hi()
    {
         Console.WriteLine("Metod hi() iz classa Bravo");
        }
    }
class HiddinfAndOverridingDemo
{
    static void Main()
    {
        Alpha A = new Alpha();
        Console.WriteLine("Vipolnenie commandi A.Show():");
        A.show();
        Bravo B = new Bravo();
        Console.WriteLine("Vipolnenie commandi B.hello():");
        B.hello();
        Console.WriteLine("Vipolnenie commandi B.hi():");
        B.hi();
        Console.WriteLine("Vipolnenie commandi B.Show():");
        B.show();
        Console.WriteLine("Vipolnenie commandi A=B:");
        A = B;
        A.hello();
        Console.WriteLine("Vipolnenie commandi A.hi():");
        A.hi();
        Console.WriteLine("Vipolnenie commandi A.Show():");
        A.show();
    }
}

