using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace MayTinhBoTui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            add_Click();
            list = new List<string>();
        }
        List<Button> buttons;
        List<string> list;
        private void enableButton()
        {
            bt_cong.Enabled = true;
            bt_tru.Enabled = true;
            bt_nhan.Enabled = true;
            bt_chia.Enabled = true;
        }
        private void disableButton()
        {
            bt_cong.Enabled = false;
            bt_tru.Enabled = false;
            bt_nhan.Enabled = false;
            bt_chia.Enabled = false;
        }
        private void add_Click()
        {
            buttons = new List<Button>() { bt_0, bt_1, bt_2, bt_3, bt_4, bt_5, bt_6, bt_7, bt_8, bt_9 };
            foreach(var item in buttons)
            {
                item.Click += new EventHandler(button_Click);
            }
        }
        private void button_Click(object sender , EventArgs e)
        {
            //string textButton = ((Button)sender).Text;// dung tuong minh
            string textButton = (sender as Button).Text;// dung as
            textBox1.Text += textButton;
        }
        private void sum()
        {
            if(list.Contains("+"))
            {
                list.Remove("+");
                double s = Convert.ToDouble(list[0]) + Convert.ToDouble(list[1]);
                textBox1.Text = s.ToString();
            }
        }
        private void sub()
        {
            if (list.Contains("-"))
            {
                list.Remove("-");
                double s = Convert.ToDouble(list[0]) - Convert.ToDouble(list[1]);
                textBox1.Text = s.ToString();
            }
        }
        private void mul()
        {
            if (list.Contains("*"))
            {
                list.Remove("*");
                double s = Convert.ToDouble(list[0]) * Convert.ToDouble(list[1]);
                textBox1.Text = s.ToString();
            }
        }
        private void div()
        {
            if (list.Contains("/"))
            {
                list.Remove("/");
                double s = Convert.ToDouble(list[0]) / Convert.ToDouble(list[1]);
                textBox1.Text = s.ToString();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show ("Bạn có muốn thoát chương trình không?","Thông Báo" , MessageBoxButtons.YesNo , MessageBoxIcon.Question);
        }
        private void bt_cong_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                list.Add(textBox1.Text);
                list.Add(bt_cong.Text);
                textBox1.Text = "";
                disableButton();
            }
        }
        private void bt_bang_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                list.Add(textBox1.Text);
                sum();
                sub();
                mul();
                div();
                enableButton();
                list.Clear();
            }
        }
        private void bt_tru_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            { 
            list.Add(textBox1.Text);
            list.Add(bt_tru.Text);
            textBox1.Text = "";
            disableButton();
        }
    }
        private void bt_nhan_Click(object sender, EventArgs e)
    { 
            if(textBox1.Text != "")
        {
            list.Add(textBox1.Text);
            list.Add(bt_nhan.Text);
            textBox1.Text = "";
            disableButton();
        }
    }
        private void bt_chia_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                list.Add(textBox1.Text);
                list.Add(bt_chia.Text);
                textBox1.Text = "";
                disableButton();
            }
        }
        private void bt_xoa_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.Focus();
            list.Clear();
            enableButton();
        }
    }
}
