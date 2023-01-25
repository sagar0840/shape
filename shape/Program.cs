using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace shape
{ 
    public static class Program
{

    static void Main(string[] args)
    {
        shape.Circle c1 = new shape.Circle(5);
        c1.CalculateArea();
        Console.WriteLine(c1);
    }
}
}