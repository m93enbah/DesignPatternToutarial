using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDesignPatternPro.Models
{
    //class HtmlELement contain the injection of create StringBuilder 
    public class HtmlElement
    {
        //we define the element name and text 
        public string Name, Text;
        //we define list of the same class 
        public List<HtmlElement> Elements = new List<HtmlElement>();
        //used for the provide space 
        private const int indentSize = 2;

        public HtmlElement() { }

        public HtmlElement(string name, string text)
        {
            Name = name ?? throw new ArgumentNullException(paramName: nameof(name));
            Text = text ?? throw new ArgumentNullException(paramName: nameof(text));
        }

        //we using custom string template that create string builder 
        public override string ToString()
        {
            return ToStringTemplate(0);
        }

        private string ToStringTemplate(int ident)
        {
            var sb = new StringBuilder();
            var i = new string(' ', indentSize * ident);
            sb.AppendLine($"{i}<{Name}>");
            if (!string.IsNullOrWhiteSpace(Text))
            {
                sb.Append(new string(' ', indentSize * (ident + 1)));
                sb.AppendLine(Text);
            }
            foreach (var e in Elements)
            {
                sb.Append(e.ToStringTemplate(ident + 1));
            }
            sb.AppendLine($"{i}</{Name}>");
            return sb.ToString();
        }
    }
}
