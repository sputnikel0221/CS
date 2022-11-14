using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*      인터페이스 
 * 대부분의 프로그래밍언어는 다중상속이 불가능하고, C#도 그렇다.
 * 다중상속은 자식이 2개의 부모를 두는 것인데, 맥락상도 맞지 않고, 죽음의 다이아몬드라는 누가 부모고 누구걸 우선해서 실행해야할지 애매하기에 금지시켰다.
 * 허나 인터페이스로는 가능하게 풀어놓았다. 클래스와 인터페이스를 섞어서 받을 수 있다(클래스는 무조건 하나까지만, 인터페이스는 1개이상가능)
 * 
 * 위의 차이 이외에 인터페이스는 추상클래스와 비슷하다 - 그럼 추상클래스를 굳이 왜쓰는거지?
 */


namespace CS_Obj_15_
{
    //아래 2개는 거의 동일한 구문이다.
    abstract class Com
    {
        public abstract void Show();
        public abstract void Draw();
    }

    interface Computer
    {
        void Show();
        void Draw();
    }

    //interface를 상속받은 class는 무조건 해당 메소드를 구현해야하며, 무조건 public을 붙여야한다.
    class Moniter : Computer
    {
        //아래 2가지 방법으로 써도 되지만, 무조건 pulic으로 간주한다.
        public void Show()
        {
            Console.WriteLine("보이기");
        }
        void Computer.Draw()
        {
            Console.WriteLine("그리기");
        }
    }

    class Notebook : Computer
    {
        public void Show()
        {
            Console.WriteLine("노트북보이기");
        }
        public void Draw()
        {
            Console.WriteLine("노트북그리기");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Moniter m = new Moniter();
            m.Show();

            //2번째 방식으로 public을 생략하고 사용했던 draw의 경우, 명시적으로 인터페이스 참조하고 있다고 표시해야한다.
            //처음부터 이렇게 썼으니 끝까지 표시하라는 느낌. 그냥 1번 방식으로 public만 붙이는 것이 편할 듯 싶다.
            Computer c = m as Computer;
            c.Draw();


            //인터페이스 배열을 만들 수 있다.
            //난해하지만 아래 방식으로 생성가능
            Computer[] instances = new Computer[] { new Moniter(), new Notebook() };


            //아래처럼 활용가능하다
            foreach (Computer item in instances)
            {
                Console.WriteLine(item);
                item.Show();
                item.Draw();
            }

        }
    }
}

/*      출력창
      
보이기
그리기
CS_Obj_15_.Moniter
보이기
그리기
CS_Obj_15_.Notebook

*/