using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace DEV_6
{
    /// <summary>
    /// The class that parses info about cars from Xml files
    /// </summary>
    class Company
    {
        /// <summary>
        /// The instance of the Singleton-type class.
        /// </summary>
        private static Company uniqueInstance;

        /// <summary>
        /// The list of all cars
        /// </summary>
        public List<Car> cars;

        /// <summary>
        /// The list of all brands
        /// </summary>
        public List<string> allBrands;

        /// <summary>
        /// The name of Xml file
        /// </summary>
        private string nameOfXml = string.Empty;

        /// <summary>
        /// Returns the instance of the class, or creates it if it doesn't exist
        /// </summary>
        /// <param name="nameOfXml">The name of Xml file</param>
        /// <returns>The instance of the class</returns>
        public static Company getInstance(string nameOfXml)
        {
            if (uniqueInstance == null)
            {
                uniqueInstance = new Company(nameOfXml);
            }
            return uniqueInstance;
        }

        /// <summary>
        /// The private constructor
        /// </summary>
        /// <param name="nameOfXml">The name of Xml file</param>
        private Company(string nameOfXml)
        {
            this.nameOfXml = nameOfXml;
            cars = new List<Car>();
            allBrands = new List<string>();
            AddBrandsToList();
            AddCarsToList();
           
        }

        /// <summary>
        /// The method that add all brands to list
        /// </summary>
        public void AddBrandsToList()
        {
            var xmlDocument = XDocument.Load(nameOfXml);
            var items = from xe in xmlDocument.Element("Cars").Elements("Car")
                        select
                        xe.Element("Brand")?.Value;
            allBrands = items.ToList();
        }

        /// <summary>
        /// The method that add all cars to list
        /// </summary>
        public void AddCarsToList()
        {
            var xmlDocument = XDocument.Load(nameOfXml);
            var items = from xe in xmlDocument.Element("Cars").Elements("Car")
                        select new Car
                        {
                            Brand = xe.Element("Brand")?.Value,
                            Model = xe.Element("Model")?.Value,
                            Quantity = Convert.ToInt32(xe.Element("Quantity")?.Value),
                            Price = Convert.ToInt32(xe.Element("Price")?.Value)
                        };
            cars = items.ToList();
        }     
    }
}
