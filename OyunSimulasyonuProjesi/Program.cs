using OyunSimulasyonuProjesi.Abstract;
using OyunSimulasyonuProjesi.Concrete;
using OyunSimulasyonuProjesi.Entities;
using System;

namespace OyunSimulasyonuProjesi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------OYUNCU EKLEME--------");
            Console.WriteLine("");
           
            BasePlayerManager playerManager = new SteamPlayerManager(new PlayerCheckManager());

            Player player = new Player { BirthDay = new DateTime(1998, 1, 1), FirstName = "The Beast", LastName = "The Best", Id = "12345678910" };
            Player player2 = new Player { BirthDay = new DateTime(1998, 2, 2), FirstName = "Alperen", LastName = "Mutlu", Id = "11111111111" };

            Console.WriteLine("");

            playerManager.Add(player);
            playerManager.Add(player2);

            Console.WriteLine("----------OYUNCU SİLME--------");
            Console.WriteLine("");

            playerManager.Delete(player2);

            Console.WriteLine("----------OYUNCU Güncelleme--------");
            Console.WriteLine("");

            playerManager.Update(player);


            Console.WriteLine("--------------------------------------");

            Console.WriteLine("----------OYUN EKLEME--------");
            Console.WriteLine("");
            BaseGameManager gameManager = new SteamGameManager();
            Game game = new Game { Id = 1, GameName = "War Rock", GameType = "FPS", Release = new DateTime(2007, 1, 1) };
            gameManager.Add(game);

            Game game2 = new Game { Id = 1, GameName = "CS:GO", GameType = "FPS", Release = new DateTime(2012, 2, 2) };
            gameManager.Add(game2);


            
            Console.WriteLine();
            gameManager.Add(game);
            gameManager.Add(game2);

            Console.WriteLine("----------OYUN SİLME-------");
            Console.WriteLine("");
            gameManager.Delete(game2);

            Console.WriteLine("----------OYUN GÜNCELLEME--------");
            Console.WriteLine("");

            
            gameManager.Update(game);
            Console.WriteLine("");

            Console.WriteLine("----------------------------------");

            Console.WriteLine("----------KAMPANYA  EKLEME--------");
            Console.WriteLine();

            BaseCampaignManager campaignManager = new SteamCampaignManager();
            Campaign campaign = new Campaign() {CampaignName = "Şahane Cuma İndirimi",Discount = 25, StartDate = new DateTime(2021,1,1), EndDate = new DateTime(2021,1,10)};
            campaignManager.Add(campaign);

            Campaign campaign2 = new Campaign() { CampaignName = "Yaz İndirimi", Discount = 50, StartDate = new DateTime(2021,2, 2), EndDate = new DateTime(2021, 2, 10) };
            campaignManager.Add(campaign2);

            Console.WriteLine("----------KAMPANYA  SİLME--------");
            campaignManager.Delete(campaign);

            Console.WriteLine("----------KAMPANYA  GÜNCELLEME-------");
            Console.WriteLine();
            campaignManager.Update(campaign);

            Console.WriteLine("----------------------------------");


            Console.WriteLine("----------SATIŞ  EKLEME--------");
            Console.WriteLine();

            BaseSalesManager baseSalesManager = new SteamSalesManager();
            Sales sales1 = new Sales();
            baseSalesManager.Add(sales1);

            Sales sales2 = new Sales();
            baseSalesManager.Add(sales2);


            Console.WriteLine("----------SATIŞ  SİLME--------");
            Console.WriteLine();
            baseSalesManager.Delete(sales2);


            Console.WriteLine("----------SATIŞ  GÜNCELLEME--------");
            Console.WriteLine();

            baseSalesManager.Update(sales1);














        }
    }
}
