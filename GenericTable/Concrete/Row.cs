using System.Collections.Generic;
using GenericTable.Abstract;

namespace GenericTable.Concrete
{
    public class Row<T1, T2>: IRow<T1, T2>
    {
        public IList<ICell<T1, T2>> Cells { get; set; }

        public Row()
        {
            Cells = new List<ICell<T1, T2>>();
        }
    }
}