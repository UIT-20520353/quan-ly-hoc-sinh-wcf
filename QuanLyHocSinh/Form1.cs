using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyHocSinh.QuanLyHocSinhService;
using DTO;

namespace QuanLyHocSinh
{
    public partial class Form1 : Form
    {
        BUS_HocSinhClient client;
        public Form1()
        {
            InitializeComponent();
            client = new BUS_HocSinhClient();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = client.LayDanhSachHocSinh();
            dtgvDanhSachHocSinh.DataSource = dt;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string MaHSMoi = "";

            if (dtgvDanhSachHocSinh.Rows[0].Cells[0].Value == null)
                MaHSMoi = "HS1";
            else 
                foreach (DataGridViewRow row in dtgvDanhSachHocSinh.Rows)
                {
                    if (row.Cells[0].Value == null)
                        continue;

                    string MaHS = row.Cells[0].Value.ToString().Trim();
                    string[] array = MaHS.Split(new[] { "HS" }, StringSplitOptions.None);
                    int a = int.Parse(array[1]) + 1;
                    MaHSMoi = "HS" + a.ToString();
                }

            DTO_HocSinh hs = new DTO_HocSinh(MaHSMoi, tbHoTen.Text.Trim(), tbQueQuan.Text.Trim(), int.Parse(tbTuoi.Text));

            if (client.ThemHocSinh(hs))
            {
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearUI();
                DataTable dt = client.LayDanhSachHocSinh();
                dtgvDanhSachHocSinh.DataSource = dt;
            } else
            {
                MessageBox.Show("Thêm không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dtgvDanhSachHocSinh.SelectedRows.Count < 0)
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (dtgvDanhSachHocSinh.SelectedRows[0].Cells[0].Value == null)
                return;

            string id = dtgvDanhSachHocSinh.SelectedRows[0].Cells[0].Value.ToString().Trim();
            if (client.XoaHocSinh(id))
            {
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearUI();
                DataTable dt = client.LayDanhSachHocSinh();
                dtgvDanhSachHocSinh.DataSource = dt;
            } else
            {
                MessageBox.Show("Xóa không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dtgvDanhSachHocSinh_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgvDanhSachHocSinh.SelectedRows.Count <= 0)
            {
                return;
            }
            DataGridViewRow row = dtgvDanhSachHocSinh.SelectedRows[0];

            tbMaHS.Text = row.Cells[0].Value.ToString().Trim();
            tbHoTen.Text = row.Cells[1].Value.ToString().Trim();
            tbQueQuan.Text = row.Cells[2].Value.ToString().Trim();
            tbTuoi.Text = row.Cells[3].Value.ToString().Trim();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dtgvDanhSachHocSinh.SelectedRows.Count < 0)
            {
                MessageBox.Show("Vui lòng chọn dòng cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (dtgvDanhSachHocSinh.SelectedRows[0].Cells[0].Value == null)
                return;

            string MaHS = tbMaHS.Text.Trim();
            string HoTen = tbHoTen.Text.Trim();
            string QueQuan = tbQueQuan.Text.Trim();
            int Tuoi = int.Parse(tbTuoi.Text.Trim());
            DTO_HocSinh hs = new DTO_HocSinh(MaHS, HoTen, QueQuan, Tuoi);

           if (client.SuaHocSinh(hs))
            {
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearUI();
                DataTable dt = client.LayDanhSachHocSinh();
                dtgvDanhSachHocSinh.DataSource = dt;
            } else
            {
                MessageBox.Show("Sửa không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ClearUI()
        {
            tbMaHS.Text = String.Empty;
            tbHoTen.Text = String.Empty;
            tbQueQuan.Text = String.Empty;
            tbTuoi.Text = String.Empty;
        }
    }
}
