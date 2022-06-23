namespace GB_MVCCourse.Classes
{
    public class ConcurrentList<T> : List<T>
    {
        private static object _lock = new();
        public List<T> Items { get; set; }

        public new void Add(T item)
        {
            lock (_lock)
            {
                Items.Add(item);
            }
        }
        public new void Remove(T item)
        {
            lock (_lock)
            {
                Items.Remove(item);
            }
        }

        public void Sort()
        {
            lock (_lock)
            {
                _ = Items.OrderBy(n => n);
            }
        }
    }
}