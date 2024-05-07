using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem;

internal class Catalog<T> : LibraryItem
{
    private List<T> _items;

    public Catalog()
    {
        _items = new List<T>();
    }

    public void AddITem(T data)
    {
        _items.Add(data);
    }

    public void RemoveItem(T data)
    {
        _items.Remove(data);
    }

    public List<T> GetItems()
    {
        return _items;
    }
}
