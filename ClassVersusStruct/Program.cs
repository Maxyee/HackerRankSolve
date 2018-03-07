using System;

namespace ClassVersusStruct
{
    struct Books
    {
        private string title;
        private string author;
        private string subject;
        private int book_id;

        public void getValues(string t,string a, string s, int id)
        {
            title = t;
            author = a;
            subject = s;
            book_id = id;
        }

        public void display()
        {
            Console.WriteLine("Title: {0}", title);
            Console.WriteLine("Author: {0}",author);
            Console.WriteLine("Subject : {0}",subject);
            Console.WriteLine("Book_id: {0}", book_id);
            //Console.ReadKey();
        }
    }

    public class MainClass
    {
        public static void Main(string[] args)
        {
            Books Book1 = new Books();
            Books Book2 = new Books();

            Book1.getValues("C Programming", "Mohon Khan","C programming basic", 234567);
            Book2.getValues("Dot Net Programming","Eyamin Khan","Dot Net Programmin tutorial",8769034);

            Book1.display();
            Book2.display();

            Console.ReadKey();
        }
    }
}
