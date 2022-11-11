using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * this관련 158p. 112p. 참조
 * this와 관련하여 정적 메서드와 instance 메서드의 차이 이해필요
 * base는 부모를 의미하는 것으로 이것도 생략해도 되지만, 맥락상 쓰기도 함
 * ~163p. 이해가 잘 안된다..
 * 
 * 다형성 - 오버라이딩 / 오버로딩
 * 오버라이딩 - 상속받는 객체에서 부모의 메소드르르 재정의하는 것
 * 
 * 메소드를 재정의하여 쓰고 싶다면 virtual/override를 사용하고,
 * 그냥 의미상 메소드 이름만 동일하게 사용하고 싶다면 new를 사용하면 된다.
 * 
 * 오버라이딩을 활용하여 Object의 기본 4가지 메소드를 개선할 수 있는데
 * 굳이라고 생각이 드는게, 이름만 가져왔지 새로 재정의하는 것이기 떄문이다.
 * 그냥 해당 메소드에 override만 붙여도 할 수 있다고 알려주는 듯 싶다.
 */

namespace CS_Obj_9_
{
    class Movie
    {
        virtual public void Show()
        {
            Console.WriteLine("재밌다");
        }
    }

    //new를 사용
    class Si_Fi : Movie
    {
        new public void Show()
        {
            Console.WriteLine("과학적이다");
        }
    }

    //virtual/override 사용
    class Hero : Movie
    {
        override public void Show()
        {
            //base.Show();  << 해당 문장을 넣으면 무조건 부모의 Show를 실행한다.
            //부모클래스의 메소드의 사용을 자식에 사용못하도록 강제방법이 없다는 것이 C#의 문제라고 한다.
            Console.WriteLine("히어로가 나온다");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            //오버라이딩
            Movie mv = new Movie();
            Si_Fi sf = new Si_Fi();
            mv.Show(); //재밌다
            sf.Show(); //과학적이다

            //부모로 형변환 된 경우의 오버라이딩
            mv = sf;
            mv.Show(); //재밌다

            //show메소드가 virtual이고, Hero의 Show메소드가 override했기에,
            //다형성을 갖도록 명시한 것이고, 어떤타입으로든 형변환이 되어도 Hero의 Show가 나오게 된다.
            Hero hr = new Hero();
            hr.Show();//히어로가 나온다
            mv = hr;  //히어로가 나온다
            mv.Show();          
        }
    }
}
