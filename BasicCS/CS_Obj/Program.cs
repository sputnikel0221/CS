using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Obj
{
    class Program
    {
        static void Main(string[] args)
        {
            Book csbasic = new Book("C#공부하자");
            Console.WriteLine(csbasic.Title);
            Console.WriteLine(Book.Count);

            Singleton.sg.work(" is ");
        }
    }

    //반환타입이 없고, 클래스이름과 동일한 메소드는 생성자
    class Book
    {
        public string Title;

        //정적 필드, 객체생성시 각 객체마다 고유한것이 아니라, 그냥 클래스라는 큰 틀에서의 값
        static public int Count; 
        
        public Book()
        {
            Console.WriteLine("기본 생성자");
            Count++;
        }

        //오버로딩
        public Book(String st)
        {
            this.Title = st;
            Count++;
        }

        /*
         * 생성자가 있으면 종료자라는 것도 있을법하고, 실제로 존재한다. ~
         * 하지만 C#과 같은 언어는 String이나 지금 Class처럼 new를 써서 힙을 사용하는 객체를 생성할 때
         * GC가 관여를 하게 되는데, 해당 객체가 사용하지 않게된다고 판단하면 알아서 정리해주어 부하를 막는다.
         * 추가로 종료자를 쓰는 것이 GC에게 오히려 더 부하가 걸리게 된다
         */
    }

        /*
         * 싱글턴방식
         * static으로 객체를 생성하기에 클래스에 대한 객체를 오직 하나만 갖도록하는 방법
         * (class당 static이 붙은 변수의 값은 하나다)
         * 
         * private로 생성자까지 막으면 된다.
         * new로 객체를 분명 할당한적이 없지만, 그냥 해당 클래스 기능을 쓸 수 있다는 장점이 존재한다.
         */
    class Singleton
    {
        static public Singleton sg = new Singleton("Only one");
        string mode;
        string st;


        private Singleton(string letters)
        {
            mode = "singleton";
            st = letters;
        }

        public void work(string word)
        {
            Console.WriteLine(st + word + mode);
        }

    }
        
        /*
        *Main 메서드도 클래스 내의 메서드일 뿐이다
        *하지만 메서드 중에서도 특이한것이, C#에서 최초 실행되는 메서드는 무조건 Main메서드이다.
        *
        *해당 Main메서드는 정적이어야 한다.
        *Main도 클래스마다 여러개를 둘 수 있다. 이럴경우는 C#컴파일러에서 따로 설정을 해줘야한다
        *반환형은 void 혹은 int만 가능 / 매개변수는 없거나 string[]만 허용됨
        */


}
