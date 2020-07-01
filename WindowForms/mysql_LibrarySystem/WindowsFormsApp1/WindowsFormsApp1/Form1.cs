using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Configuration; //App.config 써야되서 추가됨.
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient; //Mysql 접속

/// <summary>
/// 탬플릿: Windows Forms 앱(.NET Framework)
/// 다룰내용: mariaDB에 연결하기, 연결끊기.
/// 대상 프레임워크: .NET Framework 4.7.2
/// </summary>
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private MySqlConnection sqlConn = null;

        //참조에서 확장 들어가면 Mysql.data라는 것이 있는데 없으면 다운받아야함. 
        //경로 https://dev.mysql.com/downloads/connector/net/

        //접속 정보를 저장하려면 App.config(솔루션탐색기 쪽 보면 있음)에 넣어야 함. 여기에 쓰면 안됨.
        //private string connstr = "SERVER=127.0.0.1,3306;DATABASE=test;UID=root;PASSWORD=1245780";

        //App.config사용하려면 일단 참조추가로 어셈블리에서 System.configuration을 추가해줘야함.
        //Configurationmanager쓰고 알트 엔터하면 부족한 것(using System.Configuration; 채워짐)
        private string connstr = "Server=" + ConfigurationManager.AppSettings["IP"] + "Port=" + ConfigurationManager.AppSettings["PORT"] + ";" +
            "Database=" + ConfigurationManager.AppSettings["DBNAME"] + ";Uid=" + ConfigurationManager.AppSettings["USERID"] + ";Pwd=" + ConfigurationManager.AppSettings["USERPASSWORD"];

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// DB연결.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn1_Click_1(object sender, EventArgs e)
        {
            try
            {
                sqlConn = new MySqlConnection(connstr);
                MessageBox.Show("데이터베이스연결성공");
            }
            catch (Exception ex)
            {
                //알림창으로 에러내용 확인
                MessageBox.Show("에러발생내용" + ex.ToString());
            }
        }

        /// <summary>
        /// DB연결 해제
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn2_Click_1(object sender, EventArgs e)
        {
            try
            {
                //데이터베이스와 연결을 끊기.
                //null이 아닌 것은 sqlConn = new SqlConnection(connstr);이 실행됐음.
                if (sqlConn != null)
                {
                    sqlConn.Close();
                    MessageBox.Show("데이터베이스연결을 끊음");
                }
            }
            catch (Exception ex)
            {
                //알림창으로 에러내용 확인. 
                MessageBox.Show("에러발생내용" + ex.ToString());

            }
        }

    }
}
