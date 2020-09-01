using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration; //App.config 써야되서 추가됨.
using System.Data.SqlClient;

/// <summary>
/// 탬플릿: Windows Forms 앱(.NET Framework)
/// 다룰내용: mariaDB에 연결하기, 연결끊기, 실시간 연동하기.
/// 대상 프레임워크: .NET Framework 4.7.2
/// </summary>
namespace Realtime_example
{
    public partial class Form1 : Form
    {
        DataSet ds = new DataSet();
        private MySqlConnection sqlConn = null;

        //참조에서 확장 들어가면 Mysql.data라는 것이 있는데 없으면 다운받아야함. 
        //경로 https://dev.mysql.com/downloads/connector/net/

        //접속 정보를 저장하려면 App.config(솔루션탐색기 쪽 보면 있음)에 넣어야 함. 여기에 쓰면 안됨.
        //private string connstr = "SERVER=127.0.0.1,3307;DATABASE=test;UID=root;PASSWORD=1245780";

        //App.config사용하려면 일단 참조추가로 어셈블리에서 System.configuration을 추가해줘야함.
        //Configurationmanager쓰고 알트 엔터하면 부족한 것(using System.Configuration; 채워짐)


        //어떤건 Port 넣어도 되고 어떤건 안된다. 왜인가?
        //private string connstr = "Server=" + ConfigurationManager.AppSettings["IP"] + "," + ConfigurationManager.AppSettings["PORT"] + ";" +
        //    "Database=" + ConfigurationManager.AppSettings["DBNAME"] + ";Uid=" + ConfigurationManager.AppSettings["USERID"] + ";Pwd=" + ConfigurationManager.AppSettings["USERPASSWORD"];

        private string connstr = "Server=" + ConfigurationManager.AppSettings["IP"] + ";Port=" + ConfigurationManager.AppSettings["PORT"] + ";" +
              "Database=" + ConfigurationManager.AppSettings["DBNAME"] + ";Uid=" + ConfigurationManager.AppSettings["USERID"] + ";Pwd=" + ConfigurationManager.AppSettings["USERPASSWORD"];



        public Form1()
        {
            InitializeComponent();
        }

        //DB연결버튼 클릭시
        private void btn_connectDB_Click(object sender, EventArgs e)
        {
            string query = "SELECT * from books"; //테이블명 작성됨.
            try
            {
                sqlConn = new MySqlConnection(connstr);
                sqlConn.Open();
                Console.WriteLine(" Success: connect to MariaDB");
                MessageBox.Show("DB 연결 성공");
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, sqlConn);
                adapter.Fill(ds);
                dgv_DB.DataSource = ds.Tables[0];

            }
            catch (Exception ex)
            {
                //알림창으로 에러내용 확인
                MessageBox.Show("에러발생내용" + ex.ToString());
            }
        }

        //폼 닫을 때 나타나는 효과
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult.Yes != MessageBox.Show(
                "정말 종료하시겠습니까?",  //내용 
                "프로그램 종료",           //제목
                MessageBoxButtons.YesNo,  //버튼 종류 
                MessageBoxIcon.Warning, //내용 아이콘
                MessageBoxDefaultButton.Button2)) //버튼 포커스
            {
                e.Cancel = true;
            }
            else
            {
                try
                {
                    //데이터베이스와 연결을 끊기.
                    //null이 아닌 것은 sqlConn = new SqlConnection(connstr);이 실행됐음.
                    if (sqlConn != null)
                    {
                        sqlConn.Close();
                        Console.WriteLine("Success: Disconnected to MariaDB");
                    }
                }
                catch (Exception ex)
                {
                    //알림창으로 에러내용 확인. 
                    Console.WriteLine("error: " + ex.ToString());

                }
            }
        }

        //시간 설정
        private void TimeTicker()
        {
            Timer timer = new Timer();
            timer.Interval = 10; //0.1초간견으로 타이머 실행
            timer.Tick += new EventHandler(UpdateDB);
            timer.Start();
        }

        //DB업데이트 설정
        private void UpdateDB(object sender, EventArgs e) 
        {
            
            string s1 = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"); //현재 시각

            if (sqlConn != null)
            {
                string query = "SELECT * from books"; //테이블명 작성됨.
                

                tb_log.AppendText(s1);
                tb_log.AppendText(" [MariaDB]is connected");

                ds.Clear();
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, sqlConn);
                adapter.Fill(ds);

                dgv_DB.DataSource = ds.Tables[0];
            }
            else
            {
                tb_log.AppendText(s1);
                tb_log.AppendText(" [MariaDB]is deconnected \n");

            }
        }


        private void btn_renewDB_Click(object sender, EventArgs e)
        {
            TimeTicker();
        }
    }
}
