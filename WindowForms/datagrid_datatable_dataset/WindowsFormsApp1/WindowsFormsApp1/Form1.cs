using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            //datatable
            //데이터를 행과 열로서 저장할 수 있는 형식을 제공.
            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();


            //1개의 열을 추가
            DataColumn dc = new DataColumn();
            dc.ColumnName = "숫자타입";
            dc.DataType = typeof(Int32);

            //2개의 열을 추가
            DataColumn dc2 = new DataColumn();
            dc2.ColumnName = "이름";
            dc2.DataType = typeof(string);

            //데이터테이블 열을 연결.
            dt.Columns.Add(dc);
            dt.Columns.Add(dc2);

            //데이터테이블 행을 추가
            dt.Rows.Add(1, "홍길동");
            dt.Rows.Add(98, "김길동");
            dt.Rows.Add(199, "막길동");
            dt.Rows.Add(201, "홍길동2");

            //데이터셋이란? 데이터테이블의 모임
            DataSet ds = new DataSet("Mydataset");
            //데이터 셋에 앞서 생성한 dt 데이터 테이블을 저장하기
            ds.Tables.Add(dt);
            ds.Tables.Add(dt2);


            //데이터그리드뷰에 연결하여 데이터테이블 연결, 표시
            dataGridView1.DataSource= dt;
            //데이터그리드뷰에 데이터 셋에 저장된 데이터테이블 가져오기
            dataGridView2.DataSource = ds.Tables[0];
        }
    }
}
