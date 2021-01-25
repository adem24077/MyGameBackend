using System;
using MyGameBackend.Entities.Concrete;

namespace MyGameBackend.Bussiness.Concrete
{
    class GameManager
    {
        public void Buy(Game game)
        {
            Console.WriteLine("{0} dolarlık {1} oyunu satın alındı.",game.UnitPrice, game.Name);
        }
    }
}
