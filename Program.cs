using System;
using Books.Classes;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Dasturchilar kutubxonasiga xush kelibsiz !!!");
        Console.Write("Iltimos ismingizni kiriting: ");
        string userName = Console.ReadLine();
        Console.WriteLine($"Salom {userName}");
        Console.WriteLine("Qanday turdagi kitobni o'qishni xohlaysiz. Iltimos uning nomini kiriting!");

        string bookName = Console.ReadLine();

        Console.WriteLine("Bir daqiqa kuting siz izlagan kitob topilmoqda...");

        string[] Books = {"Karera programmista","24 Deadly Sins of Software Security","Artificial Intelligence for Games",
                  "Mathematics for 3D Game Programming and Computer Graphics","Game Programming Patterns","Jump Start MySQL",
                  "Python dasturlash tili","Html va CSS","C# 9 va .NET 5 — Zamonaviy platformalarni ishlab chiqish"};

        kitoblar kitoblar = new kitoblar(bookName, Books);

        kitoblar.CheckList_1();
        kitoblar.CheckList_2();
    }
}