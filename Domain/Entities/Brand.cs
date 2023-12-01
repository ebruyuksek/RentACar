using Core.Persistance.Repositories;

namespace Domain.Entities
{
    public class Brand : Entity<Guid>
    {
        //[Key]
        //public Guid Id { get; set; }
        public string Name { get; set; }

        public Brand()
        {
                
        }
        public Brand(Guid id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
