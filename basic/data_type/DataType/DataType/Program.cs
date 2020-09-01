using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataType
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. 변수 선언 방법.
            int x; //선언과
            x = 100; //데이터 할당을 별도로 할 수도 있지만

            int y = 100; //선언과 초기화를 한번에 할 수도 있다.

            int a, b, c; // 같은 형식의 변수들은 동시에 선언할 수 있다.
            int d = 10, e = 100, f = 1000; //선언과 초기화를 한번에 하는 것도 여전히 가능하다.

            //2. 리터럴 이란.
            //리터럴 이란 변수에 들어간 고정값을 의미한다.
            int z = 100; //변수 z , 리터럴 100
            int h = 0x200; //변수 h, 리터럴 0x200 은10진수 512의 16진수 표기법
            float m = 3.14f; //변수 m, 리터럴 3.14f

            //3. 값 형식과 참조 형식
            // 값 형식은 스택이고 참조 형식은 힙이다.
            // 스택은 대괄호가 나오면 알아서 데이터가 소실되나 힙은 Garbage collector이 해준다.
            //실제 참조형식은 힙, 스택 둘다 쓴다. 힙영역에 데이터를 저장하고 스택영역에는 데이터가 저장되어있는 힙 메모리 주소를 저장한다.
            // 아래 참조형식 두개를 봐보자. (참조형식은 오브젝트와 문자열 두개가 있다, 나머지는 모두 값형식이다.
            object l = 10;
            object i = 20;

            //정수형 형식을 더 자세히 살펴보자.
            sbyte ab = -10;
            byte ba = 40;

            Console.WriteLine($"ab={ab}, ba={ba}");

            short cd = -30000;
            ushort dc = 60000;

            Console.WriteLine($"cd = {cd}, dc= {dc}");

            int ef = -1000_0000; // 0이 7개, 큰 자리수 일때는 구분자인 '_' 를 사용하여 자리수 나누면 좋음. 어디 넣을지는 내마음.
            uint fe = 3_0000_0000; // 0이 8개

            Console.WriteLine($"ef= {ef}, fe={fe}");

            long gh = -5000_0000_0000; //0이 11개
            ulong hg = 200_0000_0000_0000_0000; //0이 18개

            Console.WriteLine($"gh={gh}, hg={hg}");

            //만약 담을 수 있는 수보다 더 높은 수를 원하는 경우 암시적 형 변환은 불가능 하여 명시적으로 해달라고 에러 뜸.

            //4. 2진수, 10진수, 16진수

        }
    }
}
