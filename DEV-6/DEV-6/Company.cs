using System;
using System.Collections.Generic;
using System.Xml;

namespace DEV_6
{
    /// <summary>
    /// The class that parses info about cars from Xml files
    /// </summary>
    class Company
    {
        /// <summary>
        /// The list of all cars
        /// </summary>
        public List<Car> cars;

        /// <summary>
        ///the Xml elements
        /// </summary>
        private XmlDocument xmlDocument;
        private XmlElement xmlElement;

        /// <summary>
        /// The lis of all brands
        /// </summary>
        public List<string> allBrands;

        /// <summary>
        /// The name of Xml file
        /// </summary>
        private string nameOfXml = string.Empty;

        /// <summary>
        /// The constructor
        /// </summary>
        /// <param name="nameOfXml">The name of Xml file</param>
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

        /// <summary>
        /// The method that add all brands to list
        /// </summary>
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

        /// <summary>
        /// The method that add all cars to list
        /// </summary>
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
