using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class Form1 : Form
    {
        SinhVienXL xlSV;
        public Form1()
        {
            InitializeComponent();
            xlSV = new SinhVienXL();
        }
        public void ShowAllSinhVien()
        {
            DataTable dt = xlSV.getAllSinhVien();
            dataGridViewSinhVien.DataSource = dt;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowAllSinhVien();
        }
        public bool CheckData()
        {
            if (string.IsNullOrEmpty(txtMaSVV.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã sinh viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaSVV.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtTenSvv.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên sinh viên .", "Thông báo", MessageBoxButtons.OK ,MessageBoxIcon.Information);
                txtMaSVV.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtNamSinhh.Text))
            {
                MessageBox.Show("Bạn chưa nhập năm sinh sinh viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaSVV.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtDiaChii.Text))
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ sinh viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaSVV.Focus();
                return false;
            }
            return true;

        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                SinhVien sv = new SinhVien();
                sv.MaSVV = txtMaSVV.Text;
                sv.TenSVV = txtTenSvv.Text;
                sv.NamSinhh = Int32.Parse(txtNamSinhh.Text);
                sv.DiaChii = txtDiaChii.Text;

                if (xlSV.InsertSinhVien(sv))
                    ShowAllSinhVien();
                else
                    MessageBox.Show("Đã có lỗi xảy ra, thử lại sau", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        int ID;
        private void dataGridViewSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0) {
                ID = Int32.Parse(dataGridViewSinhVien.Rows[index].Cells["Idd"].Value.ToString());
                txtMaSVV.Text = dataGridViewSinhVien.Rows[index].Cells["MaSVV"].Value.ToString();
                txtTenSvv.Text = dataGridViewSinhVien.Rows[index].Cells["TenSVV"].Value.ToString();
                txtNamSinhh.Text = dataGridViewSinhVien.Rows[index].Cells["NamSinhh"].Value.ToString();
                txtDiaChii.Text = dataGridViewSinhVien.Rows[index].Cells["DiaChii"].Value.ToString();

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                SinhVien sv = new SinhVien();
                sv.Idd = ID;
                sv.MaSVV = txtMaSVV.Text;
                sv.TenSVV = txtTenSvv.Text;
                sv.NamSinhh = Int32.Parse(txtNamSinhh.Text);
                sv.DiaChii = txtDiaChii.Text;

                if (xlSV.UpDateSinhVien(sv))
                    ShowAllSinhVien();
                else
                    MessageBox.Show("Đã có lỗi xảy ra, thử lại sau", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                SinhVien sv = new SinhVien();
                sv.Idd = ID;
                
                if (xlSV.DeleteSinhVien(sv))
                    ShowAllSinhVien();
                else
                    MessageBox.Show("Đã có lỗi xảy ra, thử lại sau", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            
            }
        }
    }
}
    
