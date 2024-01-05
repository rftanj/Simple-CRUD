namespace SimpleCRUD.Models
{
    public class Customer
    {
        public int Id { get; set; } //default akan menjadi primary key
        public string Name { get; set; } // 'string?' artinya nullable
        public string Address { get; set; }
        public string City { get; set; }
    }
}
