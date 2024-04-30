using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteBook
{
    internal class Person : IPrint
    {
        public string Name {  get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public string GetInformation()
        {
            return $"Name: {Name}\nId: {Id}\nTitle: {Title}\nDescription: {Description}";
        }
    }
}
