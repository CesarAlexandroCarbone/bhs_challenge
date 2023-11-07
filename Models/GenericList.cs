namespace BhsChallenge.Models
{
    public class GenericList<T>
    {
        public List<T> Items { get; set; } = new();

        public GenericList(List<T> items)
        {
            Items = items;
        }
    }
}
