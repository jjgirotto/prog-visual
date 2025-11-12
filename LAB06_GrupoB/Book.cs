using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB06_GrupoB
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; } = null!;
        public string Author { get; set; } = null!;
        public string Category { get; set; } = null!;
        public short Year { get; set; }
        public int Pages { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"{BookId} - {Title}, {Author}, {Year}, {Price:C} ({Category}, {Pages} páginas)";
        }

        public override bool Equals(Object obj)
        {
            //Is null (como o objeto que invoca não pode ser null)
            if (Object.ReferenceEquals(null, obj))
            {
                return false;
            }
            //Is the same object
            if (Object.ReferenceEquals(this, obj))
            {
                return true;
            }
            // Not same type
            if (obj.GetType() != this.GetType())
            {
                return false;
            }
            //Is the same type -> podemos fazer cast seguro
            Book p = obj as Book;
            return int.Equals(BookId, p.BookId);
        }

        public override int GetHashCode()
        {
            return BookId.GetHashCode();
        }

    }
}
