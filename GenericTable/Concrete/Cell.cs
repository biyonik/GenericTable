using GenericTable.Abstract;

namespace GenericTable.Concrete
{
    public class Cell<T1, T2>: ICell<T1, T2>
    {
        public T1 Key { get; set; }
        public T2 Value { get; set; }
        public IRow<T1, T2> Row { get; set; }
        public IColumn Column { get; set; }

        public Cell(IRow<T1, T2> row, IColumn column)
        {
            Row = row;
            Column = column;
        }
    }
}