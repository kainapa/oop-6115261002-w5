using System;

namespace oop_6115261002_w5
{
    class Program
    {
        static void Main(string[] args)
        {
                Building dgka = new Building("5", "computer", "659", "287");
                Room jrhr = new Room("555", "952", "4", "4", "computer", dgka);
                Subject sfy = new Subject("002", "programming", "3", "3", "5");
                Lecturer fti = new Lecturer("002", "jag", "iyf", "professor");
                Section yvsf = new Section("02", "Monday", "8.00AM", "12.00PM", jrhr, sfy, fti);
                Console.WriteLine(yvsf);
        }
    }
}
