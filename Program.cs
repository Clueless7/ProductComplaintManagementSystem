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

            bool showMenu = true;
            
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }

        // Create some hardcoded dummy Products
        static void Instantiate()
        {
            Product ballpen = new Product("Panda", "0001", "Ballpen", 500);
            productsList.Add(ballpen);
            Product notebook = new Product("Green Apple", "0002", "Notebook", 250);
            productsList.Add(notebook);
            Product ruler = new Product("Orion", "0005", "Ruler", 250);
            productsList.Add(ruler);
        }

        // Print the list of products each with index numbers
        static void ShowAvailableProducts(bool withIndex)
        {
            if (withIndex == true)
            {
                for (int i = 0; i < productsList.Count; i++)
                {
                    Console.WriteLine($"{i} \t {productsList[i].ProductName}");
                }
            } else
            {
                for (int i = 0; i < productsList.Count; i++)
                {
                    Console.WriteLine($"{productsList[i].ProductName}");
                }
            }
        }

        static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Main");
            Console.WriteLine("Welcome to Product Complaints Management System");
            Console.WriteLine("Available products: ");
            ShowAvailableProducts(false);
            Console.WriteLine();
            Console.WriteLine("Please type: ");
            Console.WriteLine("\'q\' to quit");
            Console.WriteLine("\'s\' to select a product");
            Console.WriteLine();
            Console.Write("INPUT: ");

            switch (Console.ReadLine().ToLower())
            {
                case "q":
                    return false;
                case "s":
                    bool showSecondMenu = true;

                    while (showSecondMenu)
                    {
                        showSecondMenu = ShowSecondMenu();
                    }

                    return true;
                default:
                    return true;
            }
        }

        static bool ShowSecondMenu()
        {
            Console.Clear();
            Console.WriteLine("Main > Product Select");
            Console.WriteLine("==========PRODUCT SELECT MODE==========");
            Console.WriteLine("Index\t Product");
            ShowAvailableProducts(true);
            Console.WriteLine();
            Console.WriteLine("Please type the index number of the product");
            Console.WriteLine("\'b\' to go back");
            Console.WriteLine();
            Console.Write("INPUT: ");

            switch (Console.ReadLine().ToLower())
            {
                case "0":
                    {
                        bool showThirdMenu = true;

                        while (showThirdMenu)
                        {
                            showThirdMenu = ShowThirdMenu(0);
                        }

                        return true;
                    }
                case "1":
                    {
                        bool showThirdMenu = true;

                        while (showThirdMenu)
                        {
                            showThirdMenu = ShowThirdMenu(1);
                        }

                        return true;
                    }
                case "2":
                    {
                        bool showThirdMenu = true;

                        while (showThirdMenu)
                        {
                            showThirdMenu = ShowThirdMenu(2);
                        }

                        return true;
                    }
                case "b":
                    return false;
                default:
                    return true;
            }
        }

        static bool ShowThirdMenu(int index)
        {
            Console.Clear();
            Console.WriteLine("Main > Product Select > Product Information");
            Console.WriteLine("==========PRODUCT INFORMATION==========");
            Console.WriteLine($"Product Brand: {productsList[index].ProductBrand}");
            Console.WriteLine($"Product Code: {productsList[index].ProductCode}");
            Console.WriteLine($"Product Name: {productsList[index].ProductCode}");
            Console.WriteLine($"Product Quantity: {productsList[index].ProductQuantity}");
            Console.WriteLine("Product Complaints: ");
            
            List<ProductComplaint> productComplaints = productsList[index].GetComplaints();

            if (productComplaints.Count == 0)
            {
                Console.WriteLine("No complaints about this product");
            }

            for (int i = 0; i < productComplaints.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {productComplaints[i].GetAllInfo()}");
            }

            Console.WriteLine();
            Console.WriteLine("Please type: ");
            Console.WriteLine("\'a\' add a complaint");
            Console.WriteLine("\'b\' to go back");
            Console.WriteLine();
            Console.Write("INPUT: ");

            switch (Console.ReadLine().ToLower())
            {
                case "a":
                    {
                        bool showFourthMenu = true;

                        while (showFourthMenu)
                        {
                            showFourthMenu = ShowFourthMenu(index);
                        }

                        return false;
                    }
                case "b":
                    return false;
                default:
                    return true;
            }
        }

        static bool ShowFourthMenu(int index)
        {
            Console.Clear();
            Console.WriteLine("Main > Product Select > Product Information > Add Complaint");
            Console.WriteLine("==========ADD PRODUCT COMPLAINT==========");
            Console.Write("Enter name: ");
            string complaintName = Console.ReadLine();
            Console.Write("Enter complaint: ");
            string complaintContent = Console.ReadLine();

            ProductComplaint complaint = new ProductComplaint(complaintName, DateTime.Now, complaintContent);
            productsList[index].AddComplaint(complaint);

            Console.WriteLine("Complaint successfully added");
            Console.ReadLine();

            return false;
        }
    }
}
