//  car object homework

using System;

namespace oopReviewHomework
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var car1 = new Car("red", "Honda");
            //var smallCar = new SaloonCar("blue", "Toyota", "2");
            Console.WriteLine("Car1 is " + car1.color + " Made by " + car1.manufacturer);
            //Console.WriteLine("SaloonCar is " + smallCar.NumberOfSeats);
        }
    }

    public class Car
    {
        public Car (string _color, string _manufacturer)
        {
            this.color = _color;
            this.manufacturer = _manufacturer;
        }

        public string color { get; set; }
        public string manufacturer { get; set; }
    }

    //public class SaloonCar : Car
    //{
    //    public SaloonCar (string _NumberOfSeats)
    //    {
    //        this.NumberOfSeats = NumberOfSeats;
    //    }
    //    public string NumberOfSeats { get; set; }
    //}
}



//  create a car class  ok
//  instantiate a Car1 object  ok

//  make 3 constructors
//  1 assign number of seats
//  2 assign number of seats and manufacturer
//  3 assign nuber of seats, manufacturer and color


    //  create SaloonCar object with 2 seats
    //  create SaloonCar object with 3 seats manufacturer Nissan
    //  create SaloonCar object with 4 seats manufacturer Ford purple