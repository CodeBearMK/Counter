using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Counter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtPW.Text == "123456")
            {
                label1.Text = "請輸入提領金額，按 [確定] 鈕";
                txtMoney.Enabled = true;
                button2.Enabled = true;
            }
            else
            {
                label1.Text = "密碼錯誤！請重新輸入";
                txtPW.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "提領金額是 " + txtMoney.Text + " 元";
        }
    }
}
