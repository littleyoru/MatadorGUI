using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animation1
{
    class Matador
    {
        public Street start;
        public List<Car> Cars = new List<Car>();
        public Car currentPlayer;
        public Matador()
        {
            start = new Street { Name = "Start", x = 320, y = 50 };
            start.next = start;
        }
        public void CarsToStart()
        {
            foreach (var car in Cars)
            {
                car.Street = start;
            }
            currentPlayer = Cars[0];
        }
        public void AddStreet(string name, int x, int y)
        {
            var temp = start;
            while (temp.next != start)
            {
                temp = temp.next;
            }
            temp.next = new Street { Name = name };
            temp.next.x = x;
            temp.next.y = y;
            temp.next.next = start;
        }
        public void PrintBoard(Graphics g)
        {
            Pen pen1 = new Pen(Color.DarkCyan, 2F);
            Pen pen2 = new Pen(Color.DarkGoldenrod, 2F);
            Street i = start;
            while (i != null)
            {
                // draw street rectangle
                g.DrawRectangle(pen1, i.x, i.y, 105, 30);

                // draw street name
                Font drawFont = new Font("Arial", 12);
                SolidBrush drawBrush = new SolidBrush(Color.DarkOrange);
                g.DrawString(i.Name, drawFont, drawBrush, i.x, i.y);

                // draw car
                //foreach (var car in Cars)
                //{
                //    if (car.Street == i)
                //    {
                //        g.DrawRectangle(pen2, i.x + , i.y, 10, 10);
                //    }
                //}

                if (i.next == start) break;
                i = i.next;
            }
        }
        public void PrintDie(Graphics g)
        {
            // draw die
            Image die = Image.FromFile(@"C:\Users\Elena\source\repos\Animation1\Animation1\others\dice.png");
            g.DrawImage(die, 0, 0, 95, 95);
        }
        public void PrintTotalCars(Graphics g)
        {
            // draw cars
            Image ford = Image.FromFile(@"C:\Users\Elena\source\repos\Animation1\Animation1\cars\ford.png");
            g.DrawImage(ford, 5, 5, 60, 50);

            Image bmw = Image.FromFile(@"C:\Users\Elena\source\repos\Animation1\Animation1\cars\bmw.png");
            g.DrawImage(bmw, 5, 60, 60, 50);

            Image toyota = Image.FromFile(@"C:\Users\Elena\source\repos\Animation1\Animation1\cars\toyota.png");
            g.DrawImage(toyota, 5, 120, 60, 50);

            Image ferrari = Image.FromFile(@"C:\Users\Elena\source\repos\Animation1\Animation1\cars\ferrari.png");
            g.DrawImage(ferrari, 5, 180, 60, 50);

            Image vw = Image.FromFile(@"C:\Users\Elena\source\repos\Animation1\Animation1\cars\vw.png");
            g.DrawImage(vw, 5, 240, 60, 50);
        }
        public void MoveCar(string carName, int distance)
        {
            var car = Cars.Where(x => x.Name.ToLower() == carName).FirstOrDefault();
            if (car == null)
            {
                Console.WriteLine("Car name doesn't exist!");
            }
            else
            {
                for (int i = 0; i < distance; i++)
                {
                    car.Street = car.Street.next;
                }
                Console.WriteLine($"Car moved to {car.Street.Name}\n");
            }
        }
    }
    class Street
    {
        public string Name;
        public int Price;
        public Street next;
        public int x, y;
    }
    class Car
    {
        public string Name;
        public Street Street;
        public int Money;
    }
}
