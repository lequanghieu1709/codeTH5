using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtNhap.Select();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Kiểm tra xem phím Enter đã được nhấn
            {
                string number = txtNhap.Text.Trim(); // Lấy số từ TextBox và loại bỏ khoảng trống đầu và cuối
                if (!string.IsNullOrEmpty(number)) // Kiểm tra xem số có rỗng hay không
                {
                    list.Items.Add(number); // Thêm số vào ListBox
                    txtNhap.Clear(); // Xóa nội dung của TextBox
                    txtNhap.Focus(); // Đặt con trỏ vào TextBox
                }

                e.Handled = true; // Đánh dấu sự kiện đã được xử lý
            }
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            string number = txtNhap.Text.Trim(); // Lấy số từ TextBox và loại bỏ khoảng trống đầu và cuối
            if (!string.IsNullOrEmpty(number)) // Kiểm tra xem số có rỗng hay không
            {
                list.Items.Add(number); // Thêm số vào ListBox
                txtNhap.Clear(); // Xóa nội dung của TextBox
                txtNhap.Focus(); // Đặt con trỏ vào TextBox
            }
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            int tong = TinhTongComboBox(list);
            MessageBox.Show("Tổng các phần tử trong List: " + tong);
        }

        private int TinhTongComboBox(System.Windows.Forms.ListBox list)
        {
            int tong = 0;

            foreach (var item in list.Items)
            {
                if (int.TryParse(item.ToString(), out int giaTri))
                {
                    tong += giaTri;
                }
            }

            return tong;
        }

        private void XoaPhanTuDauVaCuoi(System.Windows.Forms.ListBox list)
        {
            if (list.Items.Count > 0)
            {
                list.Items.RemoveAt(0); // Xóa phần tử đầu tiên
                list.Items.RemoveAt(list.Items.Count - 1); // Xóa phần tử cuối cùng
            }
        }

        private void btnXoa1_Click(object sender, EventArgs e)
        {
            XoaPhanTuDauVaCuoi(list);
        }
        private void XoaPhanTuDangChon(System.Windows.Forms.ListBox list)
        {
            if (list.SelectedIndex != -1)
            {
                list.Items.RemoveAt(list.SelectedIndex);
                // Hoặc sử dụng comboBox.Items.Remove(comboBox.SelectedItem);
            }
        }

        private void btnXoa2_Click(object sender, EventArgs e)
        {
            XoaPhanTuDangChon(list);         
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void TangGiaTriListBox(ListBox listBox)
        {
            for (int i = 0; i < listBox.Items.Count; i++)
            {
                int giaTri = Convert.ToInt32(listBox.Items[i]);
                giaTri += 2;
                listBox.Items[i] = giaTri.ToString();
            }
        }

        private void btnTang_Click(object sender, EventArgs e)
        {
            TangGiaTriListBox(list);
        }

        private void ThayBangBP(ListBox listBox)
        {
            for (int i = 0; i < listBox.Items.Count; i++)
            {
                int giaTri = Convert.ToInt32(listBox.Items[i]);
                giaTri = giaTri * giaTri;
                listBox.Items[i] = giaTri.ToString();
            }
        }

        private void btnThay_Click(object sender, EventArgs e)
        {
            ThayBangBP(list);
        }
        private void chan(ListBox listBox)
        {
            for (int i = 0; i < listBox.Items.Count; i++)
            {
                int giaTri = Convert.ToInt32(listBox.Items[i]);
                
                listBox.Items[i] = giaTri.ToString();
                if(giaTri % 2 == 0)
                {
                    list.SelectedIndex = i;
                }
            }
        }

        private void btnChan_Click(object sender, EventArgs e)
        {
            chan(list);
        }

        private void le(ListBox listBox)
        {
            listBox.ClearSelected();
            for (int i = 0; i < listBox.Items.Count; i++)
            {
                int giaTri = Convert.ToInt32(listBox.Items[i]);
                if (giaTri % 2 != 0)
                {
                    list.SelectedIndices.Add(i);
                }
            }
        }

        private void btnLe_Click(object sender, EventArgs e)
        {
            le(list);
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
