using System;

class Program {
  public static void Main (string[] args)
  {
    Console.WriteLine ("Co chcesz policzyć? 1-obwód kwadratu, 2-pole rombu, 3-pole trójkąta, 4-pole koła, 5-objętość walca, 6-pole powierzchni kuli, 7-pole powierzchni szcześcianu");
    int wybor = int.Parse(Console.ReadLine());
    if (wybor == 1)
    {
      Console.WriteLine("Podaj A");
      int a = int.Parse(Console.ReadLine());
      double wynik = 4*a;
      Console.WriteLine($" 4 x {a} : {wynik}");
    }
    if (wybor == 2)
    {
      Console.WriteLine("Podaj A");
      int a = int.Parse(Console.ReadLine());
      Console.WriteLine("Podaj H");
      int h = int.Parse(Console.ReadLine());
      double wynik = a*h;
      Console.WriteLine($" {a} x {h} : {wynik}");
    }
    if (wybor == 3)
    {
      Console.WriteLine("Podaj A");
      int a = int.Parse(Console.ReadLine());
      Console.WriteLine("Podaj H");
      int h = int.Parse(Console.ReadLine());
      double wynik = (a*h)/ 2;
      Console.WriteLine($" {a} x {h} / 2 : {wynik}");
    }
    if (wybor == 4)
    {
      Console.WriteLine("Podaj r");
      int r = int.Parse(Console.ReadLine());
      double wynik = Math.PI * r* r;
      Console.WriteLine($" pi x {r} x {r} : {wynik}");
    }
    if (wybor == 5)
    {
      Console.WriteLine("Podaj r");
      int r = int.Parse(Console.ReadLine());
      Console.WriteLine("Podaj h");
      int h = int.Parse(Console.ReadLine());
      double wynik = Math.PI * r* r * h;
      Console.WriteLine($" pi x {r} x {r} x {h} : {wynik}");
    }
    if (wybor == 6)
    {
      Console.WriteLine("Podaj r");
      int r = int.Parse(Console.ReadLine());
      double wynik = 4 * Math.PI * r* r;
      Console.WriteLine($" 4pi x {r} x {r} : {wynik}");
    }
    if (wybor == 7)
    {
      Console.WriteLine("Podaj A");
      int a = int.Parse(Console.ReadLine());
      double wynik = 6*a*a;
      Console.WriteLine($" 6 x {a} x {a} : {wynik}");
    }
  }
}