using System;

namespace ProductComplaintsManagementSystem
{
    class ProductComplaint
    {
        private string _author;
        private DateTime _date;
        private string _content;

        public string Author
        {
            get => _author;
            set => _author = value;
        }

        public DateTime Date
        {
            get => _date;
            set => _date = value;
        }

        public string Content
        {
            get => _content;
            set => _content = value;
        }

        public string GetAllInfo()
        {
            return $"author: {_author}, DateTime: {_date}, content: {_content}";
        }

        public ProductComplaint(string author, DateTime date, string content)
        {
            _author = author;
            _date = date;
            _content = content;
        }
    }
}
