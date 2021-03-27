using BuilderDesignPatternPro.Builder;
using System;

namespace BuilderDesignPatternPro
{
    class Program
    {
        //static void Main(string[] args)
        //{
            //life without builder design pattern
            //var hello = "hello";
            //var sb = new StringBuilder();
            //sb.Append("<p>");
            //sb.Append(hello);
            //sb.Append("</p>");
            //Console.WriteLine(sb);


            //var words = new[] { "hello", "world" };
            //sb.Clear();
            //sb.Append("<ul>");
            //foreach (var word in words)
            //{
            //    sb.AppendFormat("<li>{0}</li>", word);
            //}
            //sb.Append("</ul>");
            //Console.WriteLine(sb);
        //}
        static void Main(string[] args)
        {
            //we pass the rootName that used as parent for the child elements
            var builder = new HtmlBuilder("ul");
            builder.AddChild("li", "hello");
            builder.AddChild("li", "world");
            //this method call the custom ToString() that pass the Name ul in the end of the html 
            Console.WriteLine(builder.ToString());           
            Console.ReadLine();
        }
    }
}
