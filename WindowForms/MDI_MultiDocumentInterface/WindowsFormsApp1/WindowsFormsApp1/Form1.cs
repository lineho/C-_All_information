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

        private void button1_Click(object sender, EventArgs e)
        {
            //Form2 화면을 보여주는 코드(Form2 생성은 술루션에서 새항목 추가하고 windowsForm 추가하면 된다.)
            //Form2를 Form1 밖에서 생성할지 안에서 생성할지는 Form1의 속성 중 IsMdiContainer를 조절하면 됨.
            Form2 form2 = new Form2();
            form2.MdiParent = this; //Form1을 부모로 설정.
            form2.Show();
        }
    }
}
