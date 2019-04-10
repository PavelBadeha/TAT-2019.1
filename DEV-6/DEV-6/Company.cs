using System;
using System.Collections.Generic;
using System.Xml;

namespace DEV_6
{
    class Company
    {
        public List<Car> cars;
        private XmlDocument xmlDocument;
        private XmlElement xmlElement;
        public List<string> allBrands;
        private string nameOfXml = string.Empty;
        public Company(string nameOfXml)
        {
            cars = new List<Car>();
            allBrands = new List<string>();
            this.nameOfXml = nameOfXml;
            xmlDocument = new XmlDocument();
            xmlDocument.Load(nameOfXml);
            xmlElement = xmlDocument.DocumentElement;
            AddCarsToList();
            AddBrandsToList();
        }
        public void AddBrandsToList()
        {
            foreach (XmlElement xnode in xmlElement)
            {
                if(!allBrands.Contains(xnode.Attributes.GetNamedItem("Brand")?.Value))
                {
                    allBrands.Add(xnode.Attributes.GetNamedItem("Brand")?.Value);
                }            
            }
        }
        public void AddCarsToList()
        {         
            foreach (XmlElement xnode in xmlElement)
            {
                Car car = new Car();               
                foreach (XmlNode childnode in xnode)
                {                             
                    foreach (XmlNode node in childnode)
                    {
                        car.Brand = xnode.Attributes.GetNamedItem("Brand")?.Value;
                        car.Model = childnode.Attributes.GetNamedItem("Model")?.Value;
                        if (node.Name=="Price")
                        {
                            car.Price = Int32.Parse(node?.InnerText);
                        }
                        else
                        {
                            car.Quantity = Int32.Parse(node?.InnerText);
                        }                     
                    }
                }
                cars.Add(car);
            }
        }
    }
}
