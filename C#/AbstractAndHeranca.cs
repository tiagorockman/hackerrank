using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ConsoleAPP
{
    public static class AbstractAndHeranca
    {
        /* INPUT
          The Alchemist
            Paulo Coelho
            248
        */
        public static void MainHeranca()
        {
            String title = Console.ReadLine();
            String author = Console.ReadLine();
            int price = Int32.Parse(Console.ReadLine());
            Book new_novel = new MyBook(title, author, price);
            new_novel.display();
        }

        abstract class Book
        {

            protected String title;
            protected String author;

            public Book(String t, String a)
            {
                title = t;
                author = a;
            }
            public abstract void display();


        }

        //Write MyBook class
        class MyBook : Book
        {
            private int price = 0;
            public MyBook(string title, string author, int price) : base(title, author)
            {
                this.price = price;
            }

            public override void display()
            {
                Console.Write($"Title: {title} \nAuthor: {author} \nPrice: {price}");
            }

        }
    }
   
}
