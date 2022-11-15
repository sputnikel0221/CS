using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Obj_18_
{
    interface robot
    {
        void TurnOn();
    }

    class RedRobot : robot
    {
        public void TurnOn()
        {
            Console.WriteLine("Im RED");
        }
    }

    class BlueRobot : robot
    {
        public void TurnOn()
        {
            Console.WriteLine("Im Blue");
        }
    }


    //해당 Button-RedRobot은 강력한 결합이다.
    //Button은 무조건 RedRobot만 켤 수 있기 때문이다.
    //BlueRobot을 켜기 위해선, 코드를 수동으로 바꾸어 줘야한다. 하지만 이게 100만줄이라면?
    class Button
    {
        public void Click(RedRobot robot)
        {
            robot.TurnOn();
        }
    }

    //그러니까 "특정성"이 없이, 뭐가 올지는 모르지만 "유연하게 대비"를 해두어야한다
    //그걸 인터페이스라는 종족으로 구분해놓아 구현할 수 있다.
    //그러면 빨간로봇이든 파란로봇이든 어떤로봇이든 유동적으로 결합이 가능하다. 느슨한 결합
    class New_Button
    {
        public void Click(robot anyrobot)
        {
            anyrobot.TurnOn();
        }
    }

    
    class Program
    {
        static void Main(string[] args)
        {
            Button b = new Button();
            b.Click(new RedRobot());
            //b.Click(new BlueRobot()); 작동안됨 강력한-결합

            New_Button n = new New_Button();
            n.Click(new RedRobot());
            n.Click(new BlueRobot()); //작동잘됨 느슨한-결합
        }
    }
}
