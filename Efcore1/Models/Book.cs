using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Efcore1.Models
{
    public class Book
    {
        public int BookID {  get; set; }

        public string Title { get; set; }

        public int ISBN { get; set; }

        public decimal Price { get; set; }

        public int NumberOfPages { get; set; }

        public DateTime PublishedYear {  get; set; }

        public bool IsInStock { set; get; }

        //Navigation

        public ICollection<Author> Authors { get; set; }=new List<Author>();


        public int CategoryId { get; set; }
        public Category Category { get; set; }


    }
}
