using System;

class Program
{
    static void Main(string[] args)
    {
        Order order1 = new Order("Jason Shnider");
        order1.GenerateItem("Stuff", 111, 4.5, 3);
        order1.GenerateItem("Shlongs", 0101, 100, 1);
        order1.GenerateItem("Pepe the frog", 0420, 43.50, 2);
        order1.GetPackagingLable();
        order1.GetShippingLable();

        Order order2 = new Order("Makey Maakarov");
        order2.GenerateItem("Snuff", 211, 95.90, 1);
        order2.GenerateItem("Keksy", 0201, 5, 3);
        order2.GenerateItem("NateHIGGERS", 1488, 11.50, 5);
        order2.GetPackagingLable();
        order2.GetShippingLable();
    }
}