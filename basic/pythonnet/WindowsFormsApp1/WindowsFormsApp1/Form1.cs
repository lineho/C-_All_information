using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Python.Runtime; //파이썬 코드를 불러오기 위한 using
using System.IO;

//1. 아나콘다 실행
//2. 원하는 가상환경에 pip install git+https://github.com/pythonnet/pythonnet 하기.
//3. C# 에서 Python.Runtime.dll 참조 추가하기 (가상환경 경로 안에 있음, 보통 lib안에 site-pakages)
//4. C# 설정에서 x64선택해야함.
// matplotlib 사용하려면 pip install PyQt5 있어야함.

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 환경설정 Path를 설정하는 함수이다. 실제 Path가 바뀌는 건 아니고 프로그램 세션 안에서만 path를 변경해서 사용한다.
        /// </summary>
        /// <param name="paths"></param>
        public static void AddEnvPath(params string[] paths)
        {
            // PC에 설정되어 있는 환경 변수를 가져온다.
            var envPaths = Environment.GetEnvironmentVariable("PATH").Split(Path.PathSeparator).ToList();

            // 중복 환경 변수가 없으면 list에 넣는다.
            envPaths.InsertRange(0, paths.Where(x => x.Length > 0 && !envPaths.Contains(x)).ToArray());

            // 환경 변수를 다시 설정한다.
            Environment.SetEnvironmentVariable("PATH", string.Join(Path.PathSeparator.ToString(), envPaths), EnvironmentVariableTarget.Process);

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            // 아까 where python으로 나온 anaconda 설치 경로를 설정
            var PYTHON_HOME = Environment.ExpandEnvironmentVariables(@"C:\Users\USER\anaconda3\envs\SPDRCtest\");
            // 환경 변수 설정
            AddEnvPath(PYTHON_HOME, Path.Combine(PYTHON_HOME, @"Library\bin"));
            // Python 홈 설정.
            PythonEngine.PythonHome = PYTHON_HOME;
            // 모듈 패키지 패스 설정.
            PythonEngine.PythonPath = string.Join(
                Path.PathSeparator.ToString(),
                new string[] {
                    PythonEngine.PythonPath,
                    // pip하면 설치되는 패키지 폴더.
                    Path.Combine(PYTHON_HOME, @"Lib\site-packages"),
                    // 개인 패키지 폴더
                    "C:\\Users\\USER\anaconda3\\envs\\SPDRCtest\\Lib"
                }
            );
            // Python 엔진 초기화
            PythonEngine.Initialize();
            using (Py.GIL()) {
               

                dynamic text = Py.Import("example");
                PythonEngine.RunSimpleString(@"
import sys;
print(sys.version);

");
                string textfile = File.ReadAllText(@"./xgboost.txt");
                rtb1.Text = textfile;

                pictureBox1.Image = System.Drawing.Image.FromFile("./foo.png");
            }


        }


    }
}
