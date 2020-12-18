namespace GenericTable.Abstract
{
    public interface ICell<T1, T2>
    {
        T1 Key { get; set; }
        T2 Value { get; set; }
        
        IRow<T1, T2> Row { get; set; }
        IColumn Column { get; set; }
    }
}