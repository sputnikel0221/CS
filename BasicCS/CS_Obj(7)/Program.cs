using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * Object라는 것은, 값 형식과 참조 형식 변수들 모두의 부모클래스 이다.
 * 따라서 어떤 클래스를 만들더라도 무조건 object를 상속받도록 만들어진다(생략해도 작동)
 * 하지만, 값과 참조형식은 처리방식이 다르기에,
 * 
 * object는 하위타입을아래의 4가지로 정의해 두었고
 * -System.ValueType
 * -String
 * -System.Array
 * -class 타입들
 * 
 * 해당 object하위타입중 System.ValueType을 상속받으면 값형식이 된다.
 * 그 외는 참조형식
 * 
 * 그렇기에 모든 형식은 object로 형변환이 가능하다.
 * object클래스는 단순히보면 C#에서의 예약어이고,
 * System이라는 namespace에 정의된 하나의 클래스이다.
 * 
 * object클래스는 해당 클래스 안에 미리 정의된 메소드들이 있는데,
 * 그 중 대표적인 4가지가 존재한다. 즉 아래 메소드는 모든 인스턴스에 대해 사용이 가능하다.
 * 
 * 1. ToString 
 *      - 해당 인스턴스가 속한 클래스의 전체이름을 반환 ex)CS_Obj_7_.Program
 *      - String을 포함한 기본타입(int, short..)의 경우, 해당 타입이 담고 있는 값을 string으로 반환 
 * 2. GetType
 *      - C#에서 class타입으로 객체를 만들면, 내부적으로 class타입의 정보를 담고있는 System.Type의 인스턴스를 가지게 된다.
 *      - System.Type를 가져올 수 있는 방법이 GetType메소드이다
 *      - 클래스가 아닌 것들도 가능
 *      - 아래 예제 참고
 * 3. Equals
 *      - 값을 비교한 결과를 bool형으로 반환
 *      - 값형식/참조형식에 따라 방식이 달라짐 
 *      - 힙에 할당된 실제 유의미한 값을 비교하는 것이 아니라, 메모리영역에 할당된, 힙을 가리키는 주소값을 비교함
 *      - string의 경우 예외로, Equals에 대해 따로 정의해두어 값형식처럼 값을 비교한다.
 * 4. GetHashCode
 *      - 특정 인스턴스를 고유히 식별하는 HashCode(4바이트 int값)를 반환
 *      - GetHashCode는 Equals와 비슷하다고 보면 되는것이,
 *      - Equals에서 True로 나왔으면 각자의 HashCode는 같고,
 *      - Equals에서 False로 나왔으면 각자의 HashCode는 다르다.
 *      - 블랙박스처럼 참조타입에 대한 원리는 다르지만, 작동방식은 같다
 *      - 아래 예제 추가 참고
 *     
 */

class Car
{
    //Type의 사용을 위해 만든 더미 class
}

namespace CS_Obj_7_
{
    class Program
    {
        static void Main(string[] args)
        {
            //2 Get Type 메소드 예제
            //클래스를 선언했으므로 해당 객체에서 Type을 가져와 Type변수에 저장할 수 있다.
            Car car_1 = new Car();
            Type type_1 = car_1.GetType();

            Console.WriteLine(type_1.FullName);
            Console.WriteLine(type_1.IsClass);
            Console.WriteLine(type_1.IsArray);

            //클래스가 아닌 배열도 Type를 사용가능
            int[] arr = new int[] { 1,2 };
            Type arrtype = arr.GetType();
            Console.WriteLine(arrtype.IsArray);

            //값 형 인스턴스에도 Type를 사용가능, 이 경우 자료형의 이름이 나온다 ex)System.Int32 ..
            int n = 5;
            string txt = "Hi";
            Console.WriteLine(n.GetType());
            Console.WriteLine(txt.GetType());

            //---------------------------------------------------------------------------

            //3 Equals 메소드 예제
            string txt_1 = "A";
            string txt_2 = "A";
            string txt_3 = "B";
            Console.WriteLine(txt_2.Equals(txt_2)); //True
            Console.WriteLine(txt_2.Equals(txt_3)); //False

            //---------------------------------------------------------------------------

            //4 GetHashoCode 메소드 예제
            //string의 경우, int의 범위를 넘는다.
            //그러므로 정상적인 해쉬값과, 값을 넘어서 한바퀴 돌아온 값이 생겨 해쉬코드가 같은 경우가 발생할 수 있다.
            //hash collision이라고 하고, 이런 해시 충돌이 발생할 수 있으며, 이런경우 비슷한 Equals메소드를 사용한다.
            Console.WriteLine(txt_1.GetHashCode()); //-842352673
            Console.WriteLine(txt_2.GetHashCode()); //-842352673
            Console.WriteLine(txt_3.GetHashCode()); //-842352674

            //HashCode(32비트 int형과) Int형(32비트)의 범위가 같으므로
            //그냥 int형의 hashcode는 해당 값이 되도록 만들어졌다.
            int n1 = 256;
            int n2 = 323;
            Console.WriteLine(n1.GetHashCode()); //-842352673
            Console.WriteLine(n2.GetHashCode()); //-842352674



        }
    }
}
