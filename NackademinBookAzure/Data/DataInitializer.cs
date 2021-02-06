using Microsoft.EntityFrameworkCore;
using NackademinBookAzure.Models;
using System.Linq;

namespace NackademinBookAzure.Data
{
    public class DataInitializer
    {
        public static void SeedData(BookDbContext dbContext)
        {
            SeedBooks(dbContext);
        }

        private static void SeedBooks(BookDbContext dbContext)
        {
            SeedNewBook(dbContext, "C# in Depth", "Jon Skeet", "C# in Depth is a book for those who are passionate about C#. It aims to be a bridge between the existing introductory books and the language specification: something readable but detailed, exploring every aspect of the language from version 2 onwards. In the interests of brevity, it doesn't spend much time on C# 1 - readers are already expected to know the first version at least reasonably. Every new feature from C# 2 onwards is covered, however, as shown in the table of contents below.");
            SeedNewBook(dbContext, "Microsoft Visual C# Step by Step", "John Sharp", "Your hands-on guide to Microsoft Visual C# fundamentals with Visual Studio 2015Expand your expertise--and teach yourself the fundamentals of programming with the latest version of Visual C# with Visual Studio 2015. If you are an experienced software developer, youll get all the guidance, exercises, and code you need to start building responsive, scalable Windows 10 and Universal Windows Platform applications with Visual C#.");
            SeedNewBook(dbContext, "C# 7.0 in a Nutshell: The Definitive Reference", "Joseph Albahari", "When you have questions about C# 7.0 or the .NET CLR and its core Framework assemblies, this bestselling guide has the answers you need. Since its debut in 2000, C# has become a language of unusual flexibility and breadth, but its continual growth means there’s always more to learn.");
            SeedNewBook(dbContext, "Murach's C# 2015", "Anne Boehm, Joel Murach", "This core C# book has been a favorite of developers ever since the 1st edition came out in 2004. So you can be sure that this 6th edition will deliver the professional skills you’re looking for.It’s a self - paced book that shows how to use Visual Studio 2015, C# 6.0, and the .NET 4.6 classes to develop Windows Forms applications…whether you’re new to programming or not. It’s an object-oriented book that shows how to use business classes, inheritance, and interfaces the way they’re used in the real world. It’s a data programming book that shows how to create professional database applications using data sources, ADO.NET code, and the Entity Framework, as well as how to use LINQ to query data structures, from collections to arrays to datasets.");
            SeedNewBook(dbContext, "The C# Programming Yellow Book: Learn to Program in C# from First Principles", "Rob S. Miles", "Learn C# from first principles the Rob Miles way. With jokes, puns, and a rigorous problem solving based approach.");
            SeedNewBook(dbContext, "Programming Jokes", "Joakim Carlsson", "Why do all Java-Developers have glasses? Because they don't C#. [Hip, Hip]");
        }

        private static void SeedNewBook(BookDbContext dbContext, string title, string author, string description)
        {
            var book = dbContext.Books.FirstOrDefault(i => i.Title == title);
            if (book != null) return;
            dbContext.Books.Add(new Book
            {
                Author = author,
                Description = description,
                Title = title
            });
            dbContext.SaveChanges();
        }
    }
}