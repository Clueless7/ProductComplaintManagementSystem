using System;
using System.Collections.Generic;
using System.Text;

namespace ProductComplaintsManagementSystem
{
    class ProductComplaint
    {
        private string _author;
        private DateTime _date;
        private string _content;

        public ProductComplaint(string author, DateTime date, string content)
        {
            _author = author;
            _date = date;
            _content = content;
        }

        public string GetAuthor()
        {
            return _author;
        }

        public void SetAuthor(string author)
        {
            _author = author;
        }

        public DateTime GetDate()
        {
            return _date;
        }

        public void SetDate(DateTime date)
        {
            _date = date;
        }

        public string GetContent()
        {
            return _content;
        }

        public void SetContent(string content)
        {
            _content = content;
        }

        public string GetAllInfo()
        {
            return $"author: {_author}, DateTime: {_date}, content: {_content}";
        }
    }
}
