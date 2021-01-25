using MyGameBackend.Entities.Abstract;

namespace MyGameBackend.Entities.Concrete
{
    class Player:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string BirthDate { get; set; }
    }
}