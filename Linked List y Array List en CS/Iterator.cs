using System;
using System.Collections.Generic;
using System.Text;

namespace Linked_List_y_Array_List_en_CS
{
    interface Iterator<T>
    {
        bool hasNext();

        T next();
    }
}
