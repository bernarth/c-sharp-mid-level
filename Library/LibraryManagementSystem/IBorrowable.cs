﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem;

internal interface IBorrowable
{
    void Checkout(Patron patron);

    void ReturnItem(Patron patron);
}
