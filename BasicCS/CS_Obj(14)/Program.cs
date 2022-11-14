using System;

namespace CS_Obj_14_
{
    /* ================= 예제 4.23: 델리게이트와 object를 이용한 범용 정렬 코드 ================= */

    //delegate로 CompareDelgate형을 미리 정의
    //object로 인자를 받기에 어떤형이든 인자를 2개 받아서 bool을 리턴하는 자료형
    delegate bool CompareDelegate(object arg1, object arg2); // object 인자 2개

    //Person이라는 클래스
    //생성자는 나이, 이름
    //ToString이라는 이미 존재하는 메소드 이름을 사용하기에 override / 이름: 나이를 반환
    class Person
    {
        public int Age;
        public string Name;

        public Person(int age, string name)
        {
            this.Age = age;
            this.Name = name;
        }

        public override string ToString()
        {
            return Name + ": " + Age;
        }
    }

    //SortObject 클래스
    //생성자는 object배열을 받음.
    //기능은 Sort, Display기능 존재
    //핵심은 Sort기능이 delegate형을 받기에, 메소드를 인수로 받음
    class SortObject
    {
        object[] things;

        public SortObject(object[] things) // object 배열
        {
            this.things = things;
        }

        public void Sort(CompareDelegate compareMethod) //메소드를 인수로 받음
        {
            object temp;

            for (int i = 0; i < things.Length; i++)
            {
                int lowPos = i;

                for (int j = i + 1; j < things.Length; j++)
                {
                    if (compareMethod(things[j], things[lowPos]))
                    {
                        lowPos = j;
                    }
                }

                temp = things[lowPos];
                things[lowPos] = things[i];
                things[i] = temp;
            }
        }

        public void Display()
        {
            for (int i = 0; i < things.Length; i++)
            {
                Console.WriteLine(things[i] + ",");
            }
        }
    }


    //프로그램 클래스
    //해당 프로그램 클래스에서 실제로 동작할 메소드를 제작함
    class Program
    {
        //AscSortByName은 오름차순, Name에 의한 정렬에 관한 메소드이다. 2개의 인수를 받아, 뒤의 인수가 더 작다면 리턴하는 방식.
        static bool AscSortByName(object arg1, object arg2)
        {
            Person person1 = arg1 as Person; // 대상 타입으로 형변환
            Person person2 = arg2 as Person;
            return person1.Name.CompareTo(person2.Name) < 0;
        }



        //실제로 실행하는 main에선, 넣을 객체들을 생성 및 값을 부여한다.
        //그리고 SO객체를 만들어, so객체의 Sort메소드의 인수인 delegate메소드를 그대로 전달한다.
        //그러면 해당 규칙에 맞게 sort가 되고, 보여준다.
        static void Main(string[] args)
        {
            Person[] personArray = new Person[]  {
                new Person(51, "Anders"),
                new Person(37, "Scott"),
                new Person(45, "Peter"),
                new Person(62, "Mads"),
            };

            SortObject so = new SortObject(personArray);
            so.Sort(AscSortByName);
            so.Display();

            Console.WriteLine("--------------------------------------------");

            SortObject so_2 = new SortObject(personArray);
            so.Sort(DecSortByAge);
            so.Display();
        }


        //다른 규칙도 추가해보자
        static bool DecSortByAge(object arg1, object arg2)
        {
            Person person1 = arg1 as Person; // 대상 타입으로 형변환 //이건 추후에 다른 클래스의 다른 인스턴스에도 활용할 수 있다는 말이되고, 범용성을 위한 object와.. as인 것이다.
            Person person2 = arg2 as Person;
            return person1.Age.CompareTo(person2.Age) > 0;
        }
    }
}

/*      출력창
    
Anders: 51,
Mads: 62,
Peter: 45,
Scott: 37,
--------------------------------------------
Mads: 62,
Anders: 51,
Peter: 45,
Scott: 37,

*/