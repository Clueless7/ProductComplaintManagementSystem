using System;
using System.Collections.Generic;

namespace ProductComplaintsManagementSystem
{
    class Program
    {
        public static List<Product> productsList = new List<Product>();

        static void Main(string[] args)
        {
            Instantiate();

            //ProductComplaint complaint = new ProductComplaint("josel", new DateTime(2021, 4, 13), "this is a content");
            //productsList[0].AddComplaint(complaint);
            //List<ProductComplaint> ballpenComplaints = productsList[0].GetComplaints();
            //ballpenComplaints.ForEach(delegate (ProductComplaint productComplaint)
            //{
            //    Console.WriteLine(productComplaint.GetAllInfo());
            //});

            Console.WriteLine("Welcome to Product Complaints Management System");
            Console.WriteLine("Available products: ");
            Console.WriteLine("Index\t Product");
            ShowAvailableProducts();

            Console.WriteLine("Please type: ");
            Console.WriteLine("or \'q\' to quit");
            Console.WriteLine("or \'s\' to select a product");
            Console.Write("INPUT: ");

            Console.WriteLine();

            // TODO: Create Menu System

        }

        // Create some hard coded dummy Products
        static void Instantiate()
        {
            Product ballpen = new Product("Panda", "0001", "Ballpen", 500);
            productsList.Add(ballpen);
            Product notebook = new Product("Green Apple", "0002", "Notebook", 250);
            productsList.Add(notebook);
            Product ruler = new Product("Orion", "0005", "Ruler", 250);
            productsList.Add(ruler);
        }

        static void ShowAvailableProducts()
        {
            for (int i = 0; i < productsList.Count; i++)
            {
                Console.WriteLine($"{i} \t {productsList[i].ProductName}");
            }
        }

    }
}
