using System;

namespace DEV_6
{
    /// <summary>
    /// Class for car information
    /// </summary>
    class Car
    {
        /// <summary>
        /// <param name="Brand">Car's brand</param>
        /// <param name="Model">Car's model</param>
        /// <param name="Price">Car's price</param>
        /// <param name="Quantity">Car's quantity</param>
        /// </summary>
        public string Brand { get; set; }
        public string Model { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
         
        /// <summary>
        /// Method that display info about car
        /// </summary>
        public void Inform()
        {
            Console.WriteLine($"Brand: {Brand},Model: {Model}, Price: {Price}, Quantity: {Quantity}");
        }
    }
}
