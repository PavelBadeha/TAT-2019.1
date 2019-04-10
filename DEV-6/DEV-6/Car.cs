using System;
namespace DEV_6
{
    class Car
    {
        public string Mark { get; set; }
        public string Model { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public Car(string Mark,string Model,double Price,int Quantity)
        {
            this.Mark = Mark;
            this.Model = Model;
            this.Price = Price;
            this.Quantity = Quantity;
        }
        public Car()
        {}
        public void Inform()
        {
            Console.WriteLine($"Mark: {Mark},Model: {Model}, Price: {Price}, Quantity: {Quantity}");
        }
    }
}
