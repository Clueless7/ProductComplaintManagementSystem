using System;
using System.Collections.Generic;

namespace ProductComplaintsManagementSystem
{
    class Program
    {
        public static List<Product> productsList = new List<Product>();

        static void Main(string[] args)
        {
            //Product ballpen = new Product("Panda", "0001", "Ballpen", 500);

            //ProductComplaint complaint = new ProductComplaint("josel", new DateTime(2021, 4, 13), "this is a content");
            //ProductComplaint complaint2 = new ProductComplaint("josel2", new DateTime(2021, 4, 17), "this is a content2");

            //ballpen.AddComplaint(complaint);
            //ballpen.AddComplaint(complaint2);

            //List<ProductComplaint> complaintsList = ballpen.GetComplaints();

            //complaintsList.ForEach(pComplaint =>
            //{
            //    Console.WriteLine(pComplaint.GetAllInfo());
            //});

            Instantiate();


            Console.WriteLine("Welcome to Product Complaints Management System");
            Console.WriteLine("Available products: ");
            ShowAvailableProducts();

            Console.WriteLine();
            Console.WriteLine("Please type:");
            Console.WriteLine($"\'q\' if you want to view information about ");
            Console.WriteLine($"\'a\' if you want");
            Console.Write("INPUT: ");


        }


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
                Console.WriteLine($"{i} - {productsList[i].GetProductName()}");

            }
        }

    }
}
