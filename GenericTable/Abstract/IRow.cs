using System.Collections.Generic;

namespace GenericTable.Abstract
{
    public interface IRow<T1, T2>
    {
        IList<ICell<T1, T2>> Cells { get; set; }
    }
}