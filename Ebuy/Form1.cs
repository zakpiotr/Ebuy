using Ebuy.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Ebuy
{
    public partial class Form1 : Form
    {
        Random _ran { get; set; }

        public Form1()
        {
            _ran = new Random();
            InitializeComponent();

            List<Product> products = GenerateProduct();
            DisplayProducts(products);
        }

        private List<Product> GenerateProduct()
        {
            List<Product> products = new List<Product>();

            List<Car> cars = GenerateCars();
            List<Watch> watchs = GenerateWatchs();
            List<CellPhone> cellphones = GenerateCellPhones();

            products.AddRange(cars);
            products.AddRange(watchs);
            products.AddRange(cellphones);

            return products;
        }

        private List<Car> GenerateCars()
        {
            List<Car> cars = new List<Car>();

            for (int i = 0; i < 100; i++)
            {
                Car car = new Car();
                car.Id = Guid.NewGuid();
                car.Price = (decimal)_ran.NextDouble() * 100000;
                car.Name = string.Format("Car{0}", i);
                car.Type = ProductType.Car;
                car.EngineCapacity = i + 100;
                car.SeatNumber = _ran.Next(1, 5);

                cars.Add(car);
            }

            return cars;
        }

        private List<Watch> GenerateWatchs()
        {
            List<Watch> watchs = new List<Watch>();

            for (int i = 0; i < 100; i++)
            {
                Watch watch = new Watch();
                watch.Id = Guid.NewGuid();
                watch.Price = (decimal)_ran.NextDouble() * 100000;
                watch.Name = string.Format("watch{0}", i);
                watch.Type = ProductType.Watch;
                watch.Lenght = i + 100;
                watch.Weight = _ran.Next(1, 5);

                watchs.Add(watch);
            }

            return watchs;
        }

        private List<CellPhone> GenerateCellPhones()
        {
            List<CellPhone> cellPhones = new List<CellPhone>();

            for (int i = 0; i < 100; i++)
            {
                CellPhone cellPhone = new CellPhone();
                cellPhone.Id = Guid.NewGuid();
                cellPhone.Price = (decimal)_ran.NextDouble() * 100000;
                cellPhone.Name = string.Format("cellPhone{0}", i);
                cellPhone.Type = ProductType.CellPhone;
                cellPhone.ScreenSize = _ran.Next(1, 8);

                cellPhones.Add(cellPhone);
            }

            return cellPhones;
        }

        private void DisplayProducts(List<Product> products)
        {
            foreach (var product in products)
            {
                string[] subItem = new string[] {
                    product.Id.ToString(),
                    product.Name,
                    product.Price.ToString()
                };



                ListViewItem item = new ListViewItem(subItem);

                listView1.Items.Add(item);
            }
        }
    }
}
