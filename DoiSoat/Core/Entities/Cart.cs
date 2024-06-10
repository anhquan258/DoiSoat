namespace DoiSoat.Core.Entities
{
    public class Cart
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public decimal Price { get; set; }
        public long? Date { get; set; }
        public int TypeCode { get; set; }
    }
}
