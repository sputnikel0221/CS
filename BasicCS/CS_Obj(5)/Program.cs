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
        protected void StartGame() {
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

    //LOL에 sealed가 붙었기에, 해당 LOL의 자식은 생성이 불가능하다
    /*
    public class Lolchess : LOL
    {

    }
    */

    class Force_stop
    {
        public void pause(Game obj)
        {
            obj.StopGame();
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Game mmorpg = new Game();
            LOL league = new LOL();
            league.gameStart();

            //아래와 같은 부모>자식 형변환은 되지 않는다
            //league = mmorpg;

            //명시적 변환은 되지만, 대체적으로 오류가 난다. 특수기능을 자식에 구현했기 때문이다.
            //그래서 해당 오류가 나는지 확인하기 위해 as라는 문법이 존재한다.
            //형변환이 가능하면, 그대로 형변환, 되지 않으면 null값을 반환하므로서 오류가 있는지 개발자가 확인 가능하다.
            //참조형만 확인이 가능 (string도 as로 사용가능)
            //is라는 문법도 as와 거의 유사한데, 다른것은 - 가능하다면 true, 아니라면 false를 반환 / 그리고 값형에도 사용이 가능

            //명시적 변환이 존재하는 이유는, 아래의 1번 암시적 변환을 한 뒤, 원래대로 명시적 변환을 하기 위함이다.
            LOL test = mmorpg as LOL;
            league = (LOL)mmorpg;
            

            //암시적 변환인 자식>부모는 가능하다. 자식은 특수한경우고, 보편적인 부모에 속하는 상태이므로 가능
            mmorpg = league;

            // ------------------------------
            // 암시적 형변환 쓰는 예시1
            // Force_stop은 Game 클래스의 변수를 받지만, LOL클래스가 알아서 형변환 되어 들어감.

            Game tft = new Game();
            LOL chess = new LOL();
            Force_stop fs = new Force_stop();
            fs.pause(chess);

            // ------------------------------
            // 암시적 형변환 쓰는 예시2
            // Game클래스 타입의 배열인 경우, 해당 원소로 형변환되어 들어감.
            Game[] riot = new Game[] {new LOL()};


        }
    }
}
