using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Point
{
    public int x;
    public int y;

    public void printXY()
    {
        Console.WriteLine("x: " + this.x + " y: " + this.y);
    }
}



namespace CS_Structure_3_
{
    class Program
    {
        static void Main(string[] args)
        {
            //0 일반적인 참조형-참조형 대입의 경우 : p_2에 p_1을 대입하고, p_2의 값을 변경하면, 참조형이기에 p_1의 값도 변경된다.

            Point p_1 = new Point();
            p_1.x = 10; p_1.y = 10;

            Point p_2 = p_1;
            p_2.x = 20; p_2.y = 20;

            p_1.printXY();
            Console.WriteLine();

            //-------------------------------------------------------------------------------------------------------------------

            //  1
            int a = 24;
            Value2REF(ref a);
            Console.WriteLine(a);
            Console.WriteLine();

            //-------------------------------------------------------------------------------------------------------------------

            //  2
            Point pt_1 = new Point();
            pt_1.x = 10; pt_1.y = 10;

            Point2Point(pt_1);

            pt_1.printXY();
            Console.WriteLine();

            //  2-1
            rePoint2Point(pt_1);

            pt_1.printXY();
            Console.WriteLine();

            //-------------------------------------------------------------------------------------------------------------------

            //  3
            Point pt_3 = new Point();
            pt_3.x = 10; pt_3.y = 10;
            Point2REF(ref pt_3);

            pt_3.printXY();
            Console.WriteLine();
        }

        //1 값형식을 REF를 이용하여 참조형식처럼 사용가능하다 : ref는 스택의 주솟값이 직접 전달된다.
        //  값형식이고, a의 값을 n으로 받아와서 사용하지만,
        //  ref가 붙어있기에, n의 값의 변화가 a에 영향을 줌 (ref를 사용하여 값형식도 참조형처럼 사용이 가능)
        public static void Value2REF(ref int n)
        {
            n = 365;
        }

        //2 참조형식을 그대로 받고, 해당 포인터에 그냥 새로운 Point객체를 생성 및 대입하고 그 후에야 값을 부여
        //  원본 Point는 값의 변함이 없다.
        //0번은 이미 값이 부여된 참조형객체를 새로만든 Point객체에 대입을 했기에 안되는 건가?
        public static void Point2Point(Point pt)
        {
            pt = new Point();

            pt.x = 20;
            pt.y = 20;
        }

        //2-1
        public static void rePoint2Point(Point pt)
        {
            Point tpt = new Point();
            tpt.x = 20;
            tpt.y = 20;

            pt = tpt;
        }

        //3 참조형식을 ref를 통해 받고 원본 값이 변화됨
        public static void Point2REF(ref Point pt)
        {
            pt = new Point();

            pt.x = 20;
            pt.y = 20;
        }
     
    }
}

//이번 개념에 대해 이해가 안되어 따로 공부를 해보았다..
//https://velog.io/@sputnikel0221/C-2


/*참고 static에 대해 헷갈릴때
 * https://ifcontinue.tistory.com/2
 * static은 메모리에 언제든 상주해놓고 사용하기에 
 * 언제든 사용하고 가져올 수 있으며, 메모리에 저장되었기에, 호출되어 값이 바뀌면 그대로 저장된다.
 * static메소드는 static변수만 사용가능한데, static이 아닌 인스턴스들은 static이 메모리에 저장될 때 생성이 안되어있는 상태기에 오류
 */
