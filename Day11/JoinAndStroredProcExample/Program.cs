using JoinAndStroredProcExample.Models;
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace JoinAndStroredProcExample
{
    class Program
    {
        PublisherContext context;
        public Program()
        {
            context = new PublisherContext();
        }
        void PrintDetails()
        {
            //Join using LINQ
            //var myData = context.Titles.Join(context.Publishers,
            //    myTitles => myTitles.PubId,//outer table
            //    publisher => publisher.PubId,//inner table
            //    (myTitles, publisher) => new//creating a new type with the required attributes
            //    {
            //        PublisherName = publisher.PubName,
            //        BookName = myTitles.Title1
            //    });
            //foreach (var item in myData)
            //{
            //    Console.Write(item.PublisherName+"                     ");
            //    Console.WriteLine(item.BookName);
            //}
            //-----------------------Way2 execute sp
            //var authors = context.Authors
            //                .FromSqlRaw<Author>("proc_GetAllAuthors").ToList();

            //foreach (var item in authors)
            //{
            //    Console.WriteLine(item.AuFname);
            //}
            //If u do not use include it will not load the child object
            var myData = context.Titles.Include(t => t.Pub).ToList();
            foreach (var item in myData)
            {
                Console.WriteLine("Publisher Name : " + item.Pub.PubName);
                Console.WriteLine("Title Name : " + item.Title1);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            new Program().PrintDetails();
            Console.ReadKey();
        }
    }
}
