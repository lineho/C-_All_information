using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//비밀번호는 속성에서 Passwordchar 부분 건드려야 text 시각적 암호화됨.

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            //선택 알림창 띄우기
            DialogResult drslt = MessageBox.Show("로그인하시겠습니까?", "로그인", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            //사용자가 확인을 눌렀을 때 if 문
            if(DialogResult.OK == drslt)
            {
                //messageBox.Show();

                //사용자가 asdf 로그인을 하겠습니다.(메시지박스)
                if (textBox1.Text.Equals("asdf"))
                {
                    MessageBox.Show("로그인 하겠습니다.");
                }
                else
                {
                    MessageBox.Show("로그인에 실패했습니다.");
                }
            }
        }
    }
}
