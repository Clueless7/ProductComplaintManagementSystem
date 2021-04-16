using System.Collections.Generic;

namespace ProductComplaintsManagementSystem
{
    class Product
    {
        private string _productBrand;
        private string _productCode;
        private string _productName;
        private int _productQuantity;
        private List<ProductComplaint> _productComplaints = new List<ProductComplaint>();

        public string ProductBrand
        {
            get => _productBrand;
            set => _productBrand = value;
        }

        public string ProductCode
        {
            get => _productCode;
            set => _productCode = value;
        }

        public string ProductName
        {
            get => _productName;
            set => _productName= value;
        }

        public int ProductQuantity
        {
            get => _productQuantity;
            set => _productQuantity= value;
        }

        public void AddComplaint(ProductComplaint complaint)
        {
            _productComplaints.Add(complaint);
        }

        public List<ProductComplaint> GetComplaints()
        {
            return _productComplaints;
        }

        public Product(string brand, string code, string name, int quantity)
        {
            _productBrand = brand;
            _productCode = code;
            _productName = name;
            _productQuantity = quantity;
        }

    }
}
