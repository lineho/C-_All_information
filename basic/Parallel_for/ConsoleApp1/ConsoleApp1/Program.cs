using System; //필수
using System.Threading.Tasks; //필수
using System.Threading; //필수
using System.Collections.Generic;

namespace ConsoleApp1
{
    /// <summary>
    /// 간단한 숫자 세기(순차진행, 병렬진행) -> 솔직히 속도가 순차진행이 더빠른것같은데 모르겠다.
    /// </summary>
    class CountNumForTest
    {
        /// <summary>
        /// for문 순차적 실행.
        /// </summary>
        public void ForTest1()
        {
            for (int i = 0; i < 10000; i++)
            {
                Console.WriteLine("{0}:{1}", Thread.CurrentThread.ManagedThreadId, i);
            }
            Console.Read();
        }

        /// <summary>
        /// 병렬 실행
        /// </summary>
        public void ParalleForTest1()
        {
            Parallel.For(0, 10000, (i) =>
            {
                Console.WriteLine("{0}:{1}", Thread.CurrentThread.ManagedThreadId, i);
            }
          );
        }
    }

    /// <summary>
    /// 다량의 데이터를 암호화하기(순차진행, 병렬진행)
    /// </summary>
    class EncrytForTest
    {
        const int MAX = 10000000;
        const int SHIFT = 3;
        static void SequentialEncryt()
        {
            // 테스트 데이타 셋업
            // 1000 만개의 스트링
            string text = "I am a boy. My name is Tom.";
            List<string> textList = new List<string>(MAX);
            for (int i = 0; i < MAX; i++)
            {
                textList.Add(text);
            }

            // 순차 처리 (Test run: 8.7 초)
            System.Diagnostics.Stopwatch watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            for (int i = 0; i < MAX; i++)
            {
                char[] chArr = textList[i].ToCharArray();

                // 모든 문자를 시저 암호화
                for (int x = 0; x < chArr.Length; x++)
                {
                    // 시저 암호
                    if (chArr[x] >= 'a' && chArr[x] <= 'z')
                    {
                        chArr[x] = (char)('a' + ((chArr[x] - 'a' + SHIFT) % 26));
                    }
                    else if (chArr[x] >= 'A' && chArr[x] <= 'Z')
                    {
                        chArr[x] = (char)('A' + ((chArr[x] - 'A' + SHIFT) % 26));
                    }
                }

                // 변경된 암호로 치환
                textList[i] = new String(chArr);
            };
            watch.Stop();
            Console.WriteLine(watch.Elapsed.ToString());
        }

        static void ParallelEncryt()
        {
            // 테스트 데이타 셋업
            // 1000 만개의 스트링
            string text = "I am a boy. My name is Tom.";
            List<string> textList = new List<string>(MAX);
            for (int i = 0; i < MAX; i++)
            {
                textList.Add(text);
            }

            // 병렬 처리 (Test run: 6.1 초)
            System.Diagnostics.Stopwatch watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            Parallel.For(0, MAX, i =>
            {
                char[] chArr = textList[i].ToCharArray();

                // 모든 문자를 시저 암호화
                for (int x = 0; x < chArr.Length; x++)
                {
                    // 시저 암호
                    if (chArr[x] >= 'a' && chArr[x] <= 'z')
                    {
                        chArr[x] = (char)('a' + ((chArr[x] - 'a' + SHIFT) % 26));
                    }
                    else if (chArr[x] >= 'A' && chArr[x] <= 'Z')
                    {
                        chArr[x] = (char)('A' + ((chArr[x] - 'A' + SHIFT) % 26));
                    }
                }

                // 변경된 암호로 치환
                textList[i] = new String(chArr);
            });
            watch.Stop();
            Console.WriteLine(watch.Elapsed.ToString());
        }

    }
    class Program
    {

        static void Main(string[] args)
        {

            //Console.WriteLine("숫자세기");
            //Thread.Sleep(2000);
            //CountNumForTest forTest = new CountNumForTest();
            //forTest.ParalleForTest1();
            //Thread.Sleep(2000);
            //forTest.ForTest1();

            Console.WriteLine("대량의 데이터 암호화");


        }


    }
}
