using System;

class Program
{
    static void Main(string[] args)
    {
        Order order1 = new Order("Jason Shnider","Nelly Strause 95 1", "Dresden","West","DE");
        order1.GenerateItem("Pilk", 0001 , 3.45, 2);
        order1.GenerateItem("Mice Defender xm69", 0169, 45, 4);
        order1.GenerateItem("Pepe the frog", 0420, 43.50, 2);
        
        Order order2 = new Order("Makey Maakarov","42E 7N","Jackson","FL","US");
        order2.GenerateItem("Drugs", 0010, 95.90, 1);
        order2.GenerateItem("Blanket", 0201, 11.90, 1);
        order2.GenerateItem("Spoons", 0002, 6.50, 10);

        Console.Clear();
        order1.GetShippingLable();
        order1.GetPackagingLable();
        Console.WriteLine("\n Next Order");
        order2.GetShippingLable();
        order2.GetPackagingLable();
    }
}