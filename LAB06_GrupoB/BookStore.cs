using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB06_GrupoB
{
    public class BookStore
    {
        public static List<Book> Books =>
            new()
            {
                new Book
                {
                    BookId = 1, Title = "Harry Potter and the Sorcerer's Stone", Author = "J.K. Rowling",
                    Category = "Ficção", Year = 1997, Pages = 309, Price = 20.99m
                },
                new Book
                {
                    BookId = 2, Title = "Foundation", Author = "Isaac Asimov", Category = "Ciência", Year = 1951,
                    Pages = 244, Price = 15.50m
                },
                new Book
                {
                    BookId = 3, Title = "1984", Author = "George Orwell", Category = "Ficção", Year = 1949, Pages = 328,
                    Price = 12.75m
                },
                new Book
                {
                    BookId = 4, Title = "The Hobbit", Author = "J.R.R. Tolkien", Category = "Ficção", Year = 1937,
                    Pages = 310, Price = 22.99m
                },
                new Book
                {
                    BookId = 5, Title = "The Lord of the Rings", Author = "J.R.R. Tolkien", Category = "Ficção",
                    Year = 1954, Pages = 1178, Price = 35.50m
                },
                new Book
                {
                    BookId = 6, Title = "Brave New World", Author = "Aldous Huxley", Category = "Ficção", Year = 1932,
                    Pages = 288, Price = 18.00m
                },
                new Book
                {
                    BookId = 7, Title = "Dune", Author = "Frank Herbert", Category = "Ficção", Year = 1965, Pages = 412,
                    Price = 29.95m
                },
                new Book
                {
                    BookId = 8, Title = "The Catcher in the Rye", Author = "J.D. Salinger", Category = "Ficção",
                    Year = 1951, Pages = 277, Price = 14.99m
                },
                new Book
                {
                    BookId = 9, Title = "Fahrenheit 451", Author = "Ray Bradbury", Category = "Ficção", Year = 1953,
                    Pages = 194, Price = 13.99m
                },
                new Book
                {
                    BookId = 10, Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", Category = "Ficção",
                    Year = 1925, Pages = 180, Price = 10.99m
                },
                new Book
                {
                    BookId = 11, Title = "Moby Dick", Author = "Herman Melville", Category = "Ficção", Year = 1851,
                    Pages = 635, Price = 19.99m
                },
                new Book
                {
                    BookId = 12, Title = "War and Peace", Author = "Leo Tolstoy", Category = "História", Year = 1869,
                    Pages = 1225, Price = 25.99m
                },
                new Book
                {
                    BookId = 13, Title = "Crime and Punishment", Author = "Fyodor Dostoevsky", Category = "Ficção",
                    Year = 1866, Pages = 671, Price = 21.50m
                },
                new Book
                {
                    BookId = 14, Title = "The Odyssey", Author = "Homer", Category = "Clássico", Year = -800, Pages = 500,
                    Price = 18.00m
                },
                new Book
                {
                    BookId = 15, Title = "To Kill a Mockingbird", Author = "Harper Lee", Category = "Ficção", Year = 1960,
                    Pages = 281, Price = 16.99m
                },
                new Book
                {
                    BookId = 16, Title = "Pride and Prejudice", Author = "Jane Austen", Category = "Romance", Year = 1813,
                    Pages = 432, Price = 14.95m
                },
                new Book
                {
                    BookId = 17, Title = "The Iliad", Author = "Homer", Category = "Clássico", Year = -750, Pages = 543,
                    Price = 17.99m
                },
                new Book
                {
                    BookId = 18, Title = "Brave New World Revisited", Author = "Aldous Huxley", Category = "Não-Ficção",
                    Year = 1958, Pages = 144, Price = 9.99m
                },
                new Book
                {
                    BookId = 19, Title = "The Brothers Karamazov", Author = "Fyodor Dostoevsky", Category = "Ficção",
                    Year = 1880, Pages = 824, Price = 24.99m
                },
                new Book
                {
                    BookId = 20, Title = "The Divine Comedy", Author = "Dante Alighieri", Category = "Clássico",
                    Year = 1320, Pages = 798, Price = 29.99m
                },
                new Book
                {
                    BookId = 21, Title = "Don Quixote", Author = "Miguel de Cervantes", Category = "Ficção", Year = 1605,
                    Pages = 992, Price = 23.99m
                },
                new Book
                {
                    BookId = 22, Title = "The Catch-22", Author = "Joseph Heller", Category = "Ficção", Year = 1961,
                    Pages = 453, Price = 19.50m
                },
                new Book
                {
                    BookId = 23, Title = "One Hundred Years of Solitude", Author = "Gabriel Garcia Marquez",
                    Category = "Ficção", Year = 1967, Pages = 417, Price = 22.00m
                },
                new Book
                {
                    BookId = 24, Title = "Anna Karenina", Author = "Leo Tolstoy", Category = "Romance", Year = 1877,
                    Pages = 864, Price = 20.99m
                },
                new Book
                {
                    BookId = 25, Title = "The Sound and the Fury", Author = "William Faulkner", Category = "Ficção",
                    Year = 1929, Pages = 326, Price = 15.75m
                },
                new Book
                {
                    BookId = 26, Title = "The Grapes of Wrath", Author = "John Steinbeck", Category = "Ficção", Year = 1939,
                    Pages = 464, Price = 18.99m
                },
                new Book
                {
                    BookId = 27, Title = "Lolita", Author = "Vladimir Nabokov", Category = "Ficção", Year = 1955,
                    Pages = 336, Price = 17.50m
                },
                new Book
                {
                    BookId = 28, Title = "The Picture of Dorian Gray", Author = "Oscar Wilde", Category = "Ficção",
                    Year = 1890, Pages = 254, Price = 14.99m
                },
                new Book
                {
                    BookId = 29, Title = "A Tale of Two Cities", Author = "Charles Dickens", Category = "História",
                    Year = 1859, Pages = 489, Price = 16.50m
                },
                new Book
                {
                    BookId = 30, Title = "Madame Bovary", Author = "Gustave Flaubert", Category = "Romance", Year = 1857,
                    Pages = 328, Price = 13.95m
                },
                new Book
                {
                    BookId = 31, Title = "Wuthering Heights", Author = "Emily Brontë", Category = "Romance", Year = 1847,
                    Pages = 416, Price = 12.99m
                },
                new Book
                {
                    BookId = 32, Title = "The Stranger", Author = "Albert Camus", Category = "Ficção", Year = 1942,
                    Pages = 123, Price = 11.50m
                },
                new Book
                {
                    BookId = 33, Title = "Les Misérables", Author = "Victor Hugo", Category = "História", Year = 1862,
                    Pages = 1463, Price = 29.99m
                },
                new Book
                {
                    BookId = 34, Title = "The Metamorphosis", Author = "Franz Kafka", Category = "Ficção", Year = 1915,
                    Pages = 201, Price = 9.99m
                },
                new Book
                {
                    BookId = 35, Title = "Frankenstein", Author = "Mary Shelley", Category = "Ficção", Year = 1818,
                    Pages = 280, Price = 14.95m
                },
                new Book
                {
                    BookId = 36, Title = "Medea", Author = "Euripides", Category = "Clássico", Year = -431, Pages = 112,
                    Price = 8.99m
                },
                new Book
                {
                    BookId = 37, Title = "Dracula", Author = "Bram Stoker", Category = "Ficção", Year = 1897, Pages = 418,
                    Price = 13.99m
                },
                new Book
                {
                    BookId = 38, Title = "The Scarlet Letter", Author = "Nathaniel Hawthorne", Category = "Ficção",
                    Year = 1850, Pages = 240, Price = 10.99m
                },
                new Book
                {
                    BookId = 39, Title = "Jane Eyre", Author = "Charlotte Brontë", Category = "Romance", Year = 1847,
                    Pages = 532, Price = 15.50m
                },
                new Book
                {
                    BookId = 40, Title = "The Old Man and the Sea", Author = "Ernest Hemingway", Category = "Ficção",
                    Year = 1952, Pages = 128, Price = 11.99m
                },
                new Book
                {
                    BookId = 41, Title = "The Adventures of Huckleberry Finn", Author = "Mark Twain", Category = "Ficção",
                    Year = 1884, Pages = 366, Price = 14.50m
                },
                new Book
                {
                    BookId = 42, Title = "The Sun Also Rises", Author = "Ernest Hemingway", Category = "Ficção",
                    Year = 1926, Pages = 251, Price = 12.99m
                },
                new Book
                {
                    BookId = 43, Title = "The Count of Monte Cristo", Author = "Alexandre Dumas", Category = "Aventura",
                    Year = 1844, Pages = 1276, Price = 24.99m
                },
                new Book
                {
                    BookId = 44, Title = "Great Expectations", Author = "Charles Dickens", Category = "Ficção", Year = 1861,
                    Pages = 505, Price = 18.75m
                },
                new Book
                {
                    BookId = 45, Title = "Mansfield Park", Author = "Jane Austen", Category = "Romance", Year = 1814,
                    Pages = 560, Price = 16.99m
                },
                new Book
                {
                    BookId = 46, Title = "Gulliver's Travels", Author = "Jonathan Swift", Category = "Aventura",
                    Year = 1726, Pages = 306, Price = 13.95m
                },
                new Book
                {
                    BookId = 47, Title = "The Catcher in the Rye", Author = "J.D. Salinger", Category = "Ficção",
                    Year = 1951, Pages = 277, Price = 14.99m
                },
                new Book
                {
                    BookId = 48, Title = "Bleak House", Author = "Charles Dickens", Category = "História", Year = 1853,
                    Pages = 912, Price = 19.99m
                },
                new Book
                {
                    BookId = 49, Title = "Sense and Sensibility", Author = "Jane Austen", Category = "Romance", Year = 1811,
                    Pages = 409, Price = 14.50m
                },
                new Book
                {
                    BookId = 50, Title = "The War of the Worlds", Author = "H.G. Wells", Category = "Ficção", Year = 1898,
                    Pages = 192, Price = 11.99m
                }
            };
    }
}
