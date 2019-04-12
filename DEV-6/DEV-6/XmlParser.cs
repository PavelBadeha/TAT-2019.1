using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Threading.Tasks;

namespace DEV_6
{
    class XmlParser
    {
        public List<Car> cars {get;private set;}
        public List<string> allBrands { get; private set; }
        public string nameOfXml { get; private set; }
        private static XmlParser uniqueInstance;
        private XmlParser(string nameOfXml)
        {
            AddBrandsToList();
            AddCarsToList();
            this.nameOfXml = nameOfXml;
        }
        public static XmlParser getInstance(string nameOfXml)
        {
            if (uniqueInstance == null)
            {
                uniqueInstance = new XmlParser(nameOfXml);
            }
            return uniqueInstance;
        }
        public void AddBrandsToList()
        {
            var xmlDocument = XDocument.Load(nameOfXml);
            var items = from xe in xmlDocument.Element("Cars").Elements("Car")
                        select
                        xe.Element("Brand")?.Value;
            allBrands = items.ToList();
        }
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
