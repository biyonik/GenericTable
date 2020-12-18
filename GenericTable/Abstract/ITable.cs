using System.Collections.Generic;

namespace GenericTable.Abstract
{
    public interface ITable<T1, T2>
    {
        IList<IRow<T1, T2>> Rows { get; set; }
        IRow<T1, T2> this[int i] { get; set; }
        IList<IColumn> Columns { get; set; }

        bool AddColumn(string columnName);
        bool DeleteColumn(int columnIndex);
        IRow<T1, T2> AddRow();
        bool DeleteRow(int rowIndex);
    }
}