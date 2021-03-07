using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Iterator_Sample
{
    public class Book
    {
        public string name
        {
            get;
            protected set;
        }

        public virtual string getInfo()
        {
            return name;
        }

        public Book(string _name)
        {
            name = _name;
        }
    }

    public class Journal : Book
    {
        public string author
        {
            get;
            private set;
        }

        public override string getInfo()
        {
            return $"{name} : {author}";
        }

        public Journal(string _name,string _author) : base(_name)
        {
            name = _name;
            author = _author;
        }
    }
}
