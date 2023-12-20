using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05.model
{
    public class Laptop
    {
        public string LaptopID {  get; set; }
        public string LaptopName { get; set; }
        public string LaptopType { get; set; }
        public DateTime ProductDate {  get; set; }
        public string Processor {  get; set; }
        public string HDD {  get; set; }
        public string RAM {  get; set; }
        public double Price {  get; set; }
        public string ImageName {  get; set; }
        public Laptop()
        {
            this.LaptopID = "S000";
            this.LaptopName= "Name";
        }
        public Laptop(string laptopID, string laptopName, string laptopType, DateTime productDate, string processor, string hDD, string rAM, double price, string imageName)
        {
            LaptopID = laptopID;
            LaptopName = laptopName;
            LaptopType = laptopType;
            ProductDate = productDate;
            Processor = processor;
            HDD = hDD;
            RAM = rAM;
            Price = price;
            ImageName = imageName;
        }
        public override string ToString()
        {
            return string.Format(
             "LaptopID: {0}, LaptopName: {1}, LaptopType: {2}, ProductDate: {3}, Processor: {4}, HDD: {5}, RAM: {6}, Price: {7}, ImageName: {8}",
             LaptopID, LaptopName, LaptopType, ProductDate, Processor, HDD, RAM, Price, ImageName);
        }
        }
}
