using System;
namespace DEV_6
{
    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public Car(string Brand,string Model,double Price,int Quantity)
        {
            this.Brand = Brand;
            this.Model = Model;
            this.Price = Price;
            this.Quantity = Quantity;
        }
        public Car()
        {}
        public void Inform()
        {
            Console.WriteLine($"Brand: {Brand},Model: {Model}, Price: {Price}, Quantity: {Quantity}");
        }
    }
}
