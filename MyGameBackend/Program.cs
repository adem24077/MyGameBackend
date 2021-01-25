using System;
using MyGameBackend.Bussiness.Concrete;
using MyGameBackend.Entities;
using MyGameBackend.Entities.Concrete;

namespace MyGameBackend
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player();
            player1.Id = 1234567891;
            player1.Name = "Ali";
            player1.Surname = "Çetinkaya";
            player1.BirthDate = "1998";

            Player player2 = new Player();
            player2.Id = 1874561235;
            player2.Name = "Berkan";
            player2.Surname = "Özlü";
            player2.BirthDate = "1981";

            Campaign campaign1 = new Campaign();
            campaign1.CampaignName = "Öğrenci";
            Campaign campaign2 = new Campaign();
            campaign2.CampaignName = "Haftasonu";


            PlayerManager playerManager = new PlayerManager();
            playerManager.Add();
            playerManager.Delete();
            playerManager.Update();

            Console.WriteLine(player1.Id);

            CampaignManager campaignManager1 = new CampaignManager();
            campaignManager1.Add();
            campaignManager1.Delete();

            Game game1 = new Game();
            game1.Name = "Mortal Combat 11";
            game1.UnitPrice = 60;

            Game game2 = new Game();
            game2.Name = "Borderlands 3";
            game2.UnitPrice = 60;

            GameManager gameManager = new GameManager();
            gameManager.Buy(game2);

            IOperationManager campaignManager2 = new CampaignManager();
            campaignManager2.Delete();
            IOperationManager playerManager3 = new PlayerManager();
            playerManager3.Update();

        }
    }
}
