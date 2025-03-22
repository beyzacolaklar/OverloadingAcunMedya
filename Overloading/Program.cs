// See https://aka.ms/new-console-template for more information
using System;

class Matematik
{
    public int Topla(int a, int b)
    {
        return a + b;
    }

    public int Topla(int a, int b, int c)
    {
        return a + b + c;
    }
    public double Topla(double a, double b)
    {
        return a + b;
    }

    
    public double Topla(double a, double b, double c)
    {
        return a + b + c;
    }

 
    public int Carp(int a, int b)
    {
        return a * b;
    }

    public int Carp(int a, int b, int c)
    {
        return a * b * c;
    }

    public double Carp(double a, double b)
    {
        return a * b;
    }

    public double Carp(double a, double b, double c)
    {
        return a * b * c;
    }
}

class Program
{
    static void Main()
    {
        Matematik matematik = new Matematik();

        Console.WriteLine("Toplamlar:");
        Console.WriteLine(matematik.Topla(5, 10));        
        Console.WriteLine(matematik.Topla(5, 10, 15));     
        Console.WriteLine(matematik.Topla(5.5, 2.3));      
        Console.WriteLine(matematik.Topla(1.1, 2.2, 3.3)); 

        Console.WriteLine("Çarpımlar:");
        Console.WriteLine(matematik.Carp(5, 10));         
        Console.WriteLine(matematik.Carp(5, 10, 2));      
        Console.WriteLine(matematik.Carp(2.5, 3.0));      
        Console.WriteLine(matematik.Carp(1.2, 2.2, 3.3)); 
    }
}

