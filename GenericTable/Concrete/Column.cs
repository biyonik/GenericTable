using GenericTable.Abstract;

namespace GenericTable.Concrete
{
    public class Column:IColumn
    {
        public int Index { get; set; }
        public string Name { get; set; }
    }
}