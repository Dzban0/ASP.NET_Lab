namespace Labolatorium_3.Models
{
    public class PageList<T>
    {
        public IEnumerable<T> Data { get; set; }
        public int TotalItems { get; }
        public int TotalPages { get; }
        public int Number { get; }
        public int Size { get; }
        public bool IsFirst { get; }
        public bool IsLast { get; }
        public bool IsNext { get; }
        public bool IsPrevious { get; }
        
        public PageList(IEnumerable<T> data, int totalItems, int number, int size)
        {
            Data = data;
            TotalItems = totalItems;
            Number = number;
            Size = size;
            TotalPages = TotalItems / Size + (TotalItems % Size > 0 ? 1 : 0);
            IsFirst = number <= 1;
            IsLast = number >= TotalPages;
            IsNext = !IsLast;
            IsPrevious = !IsFirst;
        }

        public static PageList<T> Create(ICollection<T> data, int totalItems, int number, int size)
        {
            PageList<T> page = new PageList<T>(data, totalItems, number, size);
            if (number > page.TotalPages)
            {
                return new PageList<T>(data, totalItems, page.TotalPages, size);
            }
            if (number < 1)
            {
                return new PageList<T>(data, totalItems, 1, size);
            }
            return page;
        }
    }
}
