using System;
using OnlineOrdering;

class Program
{
    static void Main(string[] args)
    {
        Address address = new Address("123 Main St", "Anytown", "CA", "USA");
        address.GetFullAddress();
        Console.WriteLine(address.IsUsaAddress());
        Address address2 = new Address("123 Main St", "Anytown", "CA", "Canada");
        address2.GetFullAddress();
        Console.WriteLine(address2.IsUsaAddress());
        Address address3 = new Address("123 Main St", "Anytown", "CA", "USA");
        address3.GetFullAddress();
        Console.WriteLine(address3.IsUsaAddress());
    }
}