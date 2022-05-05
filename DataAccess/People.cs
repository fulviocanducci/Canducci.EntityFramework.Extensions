namespace DataAccess
{
    public class People
    {
        public System.Guid Id { get; set; }
        public string Name { get; set; }
        public System.DateTime CreatedAt { get; set; }
        public System.DateTime? UpdateAt { get; set; }
        public bool Active { get; set; }
    }
}
