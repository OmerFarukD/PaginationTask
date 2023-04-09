namespace Project.Entity
{
    public class Product : Core.Persistence.Repositories.Entity
    {
        public int Id{ get; set; }
        public string ProductName { get; set; }
        public double UnitPrice{ get; set; }
        public int Stock{ get; set; }
    }
}