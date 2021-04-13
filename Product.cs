using System;
using System.Collections.Generic;
using System.Text;

namespace ProductComplaintsManagementSystem
{
    class Product
    {
        private string _productBrand;
        private string _productCode;
        private string _productName;
        private int _productQuantity;
        private List<ProductComplaint> _productComplaints = new List<ProductComplaint>();

        public Product(string brand, string code, string name, int quantity)
        {
            _productBrand = brand;
            _productCode = code;
            _productName = name;
            _productQuantity = quantity;
        }

        public string GetProductBrand()
        {
            return _productBrand;
        }

        public void SetProductBrand(string brand)
        {
            _productBrand = brand;
        }

        public string GetProductCode()
        {
            return _productCode;
        }

        public void SetProductCode(string code)
        {
            _productCode = code;
        }

        public string GetProductName()
        {
            return _productName;
        }

        public void SetProductName(string name)
        {
            _productName = name;
        }

        public int GetProductQuantity()
        {
            return _productQuantity;
        }

        public void SetProductQuantity(int quantity)
        {
            _productQuantity = quantity;
        }

        public void AddComplaint(ProductComplaint complaint)
        {
            _productComplaints.Add(complaint);
        }

        public List<ProductComplaint> GetComplaints()
        {
            return _productComplaints;
        }
    }
}
