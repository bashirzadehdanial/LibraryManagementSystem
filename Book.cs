using System;

namespace LibraryManagementSystem
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public bool IsCheckedOut { get; set; }

        public override string ToString()
        {
            return $"{Id}: {Title} by {Author} - {(IsCheckedOut ? "Checked Out" : "Available")}";
        }
    }
}
