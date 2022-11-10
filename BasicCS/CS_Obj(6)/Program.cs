using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Obj_5_
{
    //protected로 자식으로 정의된 class에서만 호출가능
    public class Game
    {
        bool gameOn;
        protected void StartGame()
        {
            Console.WriteLine("Start!");
        }
        public void StopGame()
        {
            Console.WriteLine("Stop!");
        }
    }

    sealed public class LOL : Game
    {
        int BP;

        public void gameStart()
        {
            StartGame();
        }
    }

   

    class Program
    {
        static void Main(string[] args)
        {
            Game mmorpg = new Game();
            LOL league = new LOL();

        }
    }
}
