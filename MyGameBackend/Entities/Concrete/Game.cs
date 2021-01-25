using MyGameBackend.Entities.Abstract;

namespace MyGameBackend.Entities.Concrete
{
    class Game:IEntity
    {
        public int Id { get; set; }          
        public string Name { get; set; }
        public string Publisher { get; set; }
        public int UnitPrice { get; set; }
    }
}
