using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using GenericTable.Abstract;

namespace GenericTable.Concrete
{
    public class Table<T1, T2>: ITable<T1, T2>
    {
        public IList<IRow<T1, T2>> Rows { get; set; }

        public IRow<T1, T2> this[int i]
        {
            get => Rows[i];
            set => Rows[i] = value;
        }

        public IList<IColumn> Columns { get; set; }

        public Table()
        {
            Columns = new List<IColumn>();
            Rows = new List<IRow<T1, T2>>();
        }
        
        public bool AddColumn(string columnName)
        {
            if (!Columns.Any(item => item.Name == columnName))
            {
                Columns.Add(new Column() {Name = columnName, Index = Columns.Count});
                return true;
            }

            return false;
        }

        public bool DeleteColumn(int columnIndex)
        {
            if (columnIndex < Columns.Count)
            {
                Columns.RemoveAt(columnIndex);
                return true;
            }

            return false;
        }

        public IRow<T1, T2> AddRow()
        {
            IRow<T1, T2> result = new Row<T1, T2>();
            foreach (IColumn column in Columns)
            {
                result.Cells.Add(new Cell<T1, T2>(result, column));
            }
            Rows.Add(result);
            return result;
        }

        public bool DeleteRow(int rowIndex)
        {
            if (rowIndex < Rows.Count)
            {
                Rows.RemoveAt(rowIndex);
                return true;
            }

            return false;
        }
    }
}