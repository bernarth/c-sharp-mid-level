using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteBook
{
    internal class Car : IPrint
    {
        public string Brand { get; set; }
        public float Model { get; set; }
        public bool IsNew { get; set; }
        public float Price { get; set; }

        public string GetInformation()
        {
            return $"Brand: {Brand}\nModel: {Model}\nIsNew: {IsNew}\nPrice: {Price}";
        }
    }
}
