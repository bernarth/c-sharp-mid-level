using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteBook
{
    internal class Phone : IPrint
    {
        public string Brand { get; set; }
        public bool Camera4K { get; set; }
        public string Os { get; set; }
        public int Ram { get; set; }
        public string Color { get; set; }

        public string GetInformation()
        {
            return $"Brand:{Brand}\nCamera 4K:{Camera4K}\nOS:{Os}\nRAM:{Ram}\nColor:{Color}\n\n";
        }
    }
}
