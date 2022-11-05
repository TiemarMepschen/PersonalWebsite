namespace Domain.Common.Entities
{
    public sealed class PagingOverview<T>
    {
        public int TotalCount { get; set; } = 0;
        public IEnumerable<T> Items { get; set; } = new List<T>();
    }
}
