using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Bai6_TH5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.ScrollAlwaysVisible = true;
            txtMSV.Select();
        }

        private void btnDangKi_Click(object sender, EventArgs e)
        {
            string msv = txtMSV.Text;
            string hoten = txtHoTen.Text;

            string hocki = "";
            if (rad1.Checked)
            {
                hocki = "I";
            }
            else if (rad2.Checked)
            {
                hocki="II";
            }
            else if(rad3.Checked)
            {
                hocki = "III";
            }else if (rad4.Checked)
            {
                hocki = "IV";
            }

            string monHoc = "";
            if(checkBox1.Checked)
            {
                monHoc += "LT Windows\n";
            }
            if (checkBox2.Checked)
            {
                monHoc += "LT Internet\n";
            }
            if (checkBox3.Checked)
            {
                monHoc += "Mạng máy tính\n";
            }
            if (checkBox4.Checked)
            {
                monHoc += "UML";
            }

            int stt = 1;

            string nienkhoa = cbbNienKhoa.SelectedItem.ToString();
            string lop = cbbLop.SelectedItem.ToString();


            string thongTin = $"Mã sinh viên: {msv}\nHọ Tên: {hoten}\nLớp: {lop}\nNiên Khóa: {nienkhoa}\nHọc Kì: {hocki}\nĐã đăng kĩ những môn học sau: \n{monHoc}";

            MessageBox.Show(thongTin, "Thông tin đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;

            rad1.Checked = false;
            rad2.Checked = false;
            rad3.Checked = false;
            rad4.Checked = false;

            cbbNienKhoa.SelectedItem = null;
            cbbLop.SelectedItem = null;

            txtHoTen.Text = string.Empty;
            txtMSV.Text = string.Empty;

            txtMSV.Select();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
