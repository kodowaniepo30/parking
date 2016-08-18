using System;
using System.Collections.Generic;

namespace Parkowanie
{
    class Program
    {
        public static List<Car> Parking = new List<Car>();
        static void Main(string[] args)
        {
            Int16 choice = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Program 'Parkowanie'\n");
                Console.WriteLine("1) Zaparkuj nowy samochód ");
                Console.WriteLine("2) Usuń ostatni samochód");
                Console.WriteLine("3) Wyświetl wszystkie samochody");
                Console.WriteLine("4) Opuśc parking");
                Console.Write("\nTwój wybór: ");
                try
                {
                    choice = Convert.ToInt16(Console.ReadLine());
                }
                catch (Exception)
                {
                    choice = 0;
                }
                switch (choice)
                {
                    case 1:
                        AddCar();
                        break;
                    case 2:
                        DelCar();
                        break;
                    case 3:
                        ShowCars();
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("\nNie ma takiej możliwości do wyboru");
                        Console.ReadLine();
                        break;
                }
            } while (!(choice == 4));
        }

        static void AddCar()
        {
            Console.Write("\nPodaj markę samochodu: ");
            string name = Console.ReadLine();
            Console.Write("\nPodaj kolor samochodu: ");
            string color = Console.ReadLine();
            Parking.Add(new Car(name, color));            
        }

        static void DelCar()
        {
            if (Parking.Count > 0)
                Parking.RemoveAt(Parking.Count - 1);
            else
            {
                Console.Write("\nNa parkingu nie stoi żaden samochód");
                Console.ReadLine();
            }                
        }

        static void ShowCars()
        {
            Console.WriteLine("\nLiczba aut na parkingu: " + Parking.Count);
            int i = 1;
            foreach (Car j in Parking)
            {
                Console.WriteLine("\nID samochodu   : " + i + "\nNazwa samochodu: " + j.getName() + "\nKolor samochodu: " + j.getColor());
                i++;
            }
            Console.ReadLine();
        }
    }
}