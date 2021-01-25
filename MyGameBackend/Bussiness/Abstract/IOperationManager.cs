using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameBackend
{
    interface IOperationManager
    {
        void Add();
        void Delete();
        void Update();
    }
    class CampaignManager:IOperationManager
    {
        public void Add()
        {
            Console.WriteLine("Kampanya uygulandı.");
        }

        public void Delete()
        {
            Console.WriteLine("Kampanya silindi.");
        }

        public void Update()
        {
            Console.WriteLine("Kampanya güncellendi.");
        }
    }

    class PlayerManager:IOperationManager
    {
        public void Add()
        {
            Console.WriteLine("Oyuncu eklendi.");
        }
        public void Delete()
        {
            Console.WriteLine("Oyuncu silindi.");
        }
        public void Update()
        {
            Console.WriteLine("Oyuncu bilgileri güncellendi.");
        }
    }
}
