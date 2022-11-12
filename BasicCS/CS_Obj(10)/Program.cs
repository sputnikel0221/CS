using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*      추상클메서드
 *  추상메서드는 반드시 추상클래스 안에서만 선언해야하고, 
 *  추상메서드는 abstart가 지정되어야 한다.
 *  
 *  추상클래스는 abstract가 붙어있다는 점에서 다른 일반클래스들과 차이가 있는데,
 *  1 - 추상클래스는 new를 통해 객체를 만들 수 없고,
 *  2 - 추상메서드를 가질 수 있다는 특성이 있다.
 *  (추상클래스를 new로 객체화할 수 없는 것은, 구현이 되지 않은 추상메서드가 있기 때문이다.)
 *  - 추상메서드가 없어도 객체화가 불가능하다
 * 
 *  자식에게 해당 메서드를 정의하라고 강제하고 싶을때 사용
 * 
 */

namespace CS_Obj_10_
{
    abstract class Troop
    {
        public abstract void Fight();
        public void Work()
        {
            Console.WriteLine("훈련");
        }       
    } 

    //추상클래스를 상속받으면 부모에서 구현하지 않은 추상 메서드를 "반드시" 구현해야한다
    //virtual-override와 같은점은 우선 override한 메서드가 우선적으로 실행된다는 것이고, 
    //다른점은, 해당 abstract-override는 부모의 메서드가 아예 정의되지 않은 점이다.
    class Army : Troop
    {
        public override void Fight()
        {
            Console.WriteLine("지상 전투");
            throw new NotImplementedException();
        }

    }

    class Program
    {
        delegate int addCalc(int a, int b);

        static void Main(string[] args)
        {
            Army a = new Army();
            a.Fight(); //지상전투

      
        }        
    }
}
