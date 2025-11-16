using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystemLib
{
    public class Book
    {
        public string Code { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Quantity { get; set; }
        public string Status { get; set; }

        public Book(string code, string title, string author, int quantity)
        {
            Code = code;
            Title = title;
            Author = author;
            Quantity = quantity;

            Status = (quantity > 0) ? "Available" : "No Available Copy";
        }

        public bool BorrowCopy()
        {
            if (Quantity > 0)
            {
                Quantity--;
                UpdateStatus();
                return true;
            }

            return false;
        }

        public void ReturnCopy()
        {
            Quantity++;
            UpdateStatus();
        }

        public void UpdateStatus()
        {
            if (Quantity > 0)
            {
                Status = "Available";
            }
            else
            {
                Status = "No Available Copy";
            }
        }   

        public override string ToString()
        {
            return $"Code: {Code} | Title: {Title} | Author: {Author} | Qty: {Quantity} | Status: {Status}";
        }

    }
}
