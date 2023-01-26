using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiskeprojekt
{
    internal class Menu
    {
        List<Fish> fishListSaltCarn = new();
        List<Fish> fishListFreshCarn = new();

        List<Fish> fishListSaltHerb = new();

        List<Fish> fishListFreshHerb = new();
        public Menu()
        {
            while (true)
            {
                MainMenu();
            }
        }
        public void MainMenu()
        {
            Console.WriteLine("Main Menu\n\n(1) Add new fish\n(2) Show Fish");

            var v = Console.ReadKey(true);
            switch (v.KeyChar)
            {
                case '1':
                    CreateItem();
                    break;
                case '2':
                 //   ShowList();
                    break;
                default:
                    break;
            }
        }
/*        void ShowList()
        {
            //foreach (? item in 1)
            {
                ShowItem(item);
            }
      
        }*/
        private void CreateItem()
        {
            Fish newFish = new Fish();

            Console.WriteLine("Is the fish freshwater? Press: Y Is the fish Saltwater press: N");
            newFish.IsFreshwater = Console.ReadKey(true).Key == ConsoleKey.Y ? true : false;
            Console.WriteLine("Is the fish carnivore? Press: Y Is the fish herbivore press: N");
            newFish.IsCarnivore = Console.ReadKey(true).Key == ConsoleKey.Y ? true : false;

            if(newFish.IsFreshwater == true)
            {
                if (newFish.IsCarnivore == true)
                {
                    fishListFreshCarn.Add(newFish);
                    Console.WriteLine("The fish was added to the Fresh Carnivore list.");
                }
                else
                {
                    fishListFreshHerb.Add(newFish);
                    Console.WriteLine("The fish was added to the Fresh Herbivore list");
                }
            }
            else 
            {
                if (newFish.IsCarnivore == true)
                {
                    fishListSaltCarn.Add(newFish);
                    Console.WriteLine("The fish was added to the Salt Carnivore list");
                }
                else
                {
                    fishListSaltHerb.Add(newFish);
                    Console.WriteLine("The fish was added to the Salt Herbivore list");
                }
            }
                








        }
           
          

        }
        //private void ShowItem(ToDoItem toDoItem)
        //{
        //    Console.WriteLine($"What: {toDoItem.Todo}  isDone: {toDoItem.IsDone}");
           
        //}
    }


