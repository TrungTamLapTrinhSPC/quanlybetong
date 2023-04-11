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

namespace quanlybetong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {

            //int i = 0;
            quanlyvatlieu ql = new quanlyvatlieu();
            //ql.STT.Add[i].Cells[0].Value = i+1;
            ql.Name = txt_name.Text;

            ql.chieudai = txt_l.Text;

            ql.berong = txt_b.Text;

            ql.Chieucao = txt_h.Text;

            // Thêm đối tượng vào DataGridView
            dgr_danhsach.Rows.Add(ql.STT,ql.Name, ql.berong,ql.chieudai,ql.Chieucao);

            double chieuDai = double.Parse(txt_l.Text);
            double chieuRong = double.Parse(txt_b.Text);

            // Tính diện tích hình chữ nhật
            double dienTich = chieuDai * chieuRong;

            // Hiển thị kết quả trong ô textbox
            txt_dientich.Text = dienTich.ToString();

            txt_name.Clear();
            txt_l.Clear();
            txt_b.Clear();
            txt_h.Clear();


            //kiem tra dieu kien
            for (int i = 0; i < dgr_danhsach.Rows.Count; i++)
            {
                DataGridViewRow row = dgr_danhsach.Rows[i];
                int dientich = Convert.ToInt32(txt_dientich.Text);
                if (dientich > 500)
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                }
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult xoa = MessageBox.Show("Bạn có chắc chắm muốn bỏ quản lý thư mục này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (xoa == DialogResult.Yes)
            {
                try
                {
                    int index;
                    index = dgr_danhsach.CurrentRow.Index;

                    dgr_danhsach.Rows.RemoveAt(index);

                }
                catch
                {

                }

            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            int index;
            index = dgr_danhsach.CurrentRow.Index;

            txt_name.Text = Convert.ToString(dgr_danhsach.Rows[index].Cells[1].Value);
            txt_b.Text = Convert.ToString(dgr_danhsach.Rows[index].Cells[2].Value);
            txt_l.Text = Convert.ToString(dgr_danhsach.Rows[index].Cells[3].Value);
            txt_h.Text = Convert.ToString(dgr_danhsach.Rows[index].Cells[4].Value);
        }

        private void txt_dientich_TextChanged(object sender, EventArgs e)
        {
            double dienTich = double.Parse(txt_dientich.Text);
            if (dienTich < 500)
            {
                lb_dau.Text = string.Format(">", txt_dientich.Text);
                lb_ketqua.Text = string.Format("Thỏa Mãn", txt_dientich.Text);
                lb_ketqua.ForeColor = Color.Green;
            }
            else if (dienTich > 500)
            {
                lb_dau.Text = string.Format("<", txt_dientich.Text);
                lb_ketqua.Text = string.Format("Chọn Lại", txt_dientich.Text);
                lb_ketqua.ForeColor = Color.Red;

                MessageBox.Show("Chọn lại tiết diện cấu kiện", "Thông báo");
            }
        }

        private void dgr_danhsach_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgr_danhsach.Columns[e.ColumnIndex].Name.Equals("")) // kiểm tra cột cần bôi đỏ
            {
                DataGridViewCell cell = this.dgr_danhsach.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (cell.Value != null)
                {
                    int dientich;
                    if (int.TryParse(cell.Value.ToString(), out dientich)) // kiểm tra giá trị của ô
                    {
                        if (dientich < 500 || dientich > 500) // nếu giá trị không hợp lệ, bôi đỏ ô đó
                        {
                            e.CellStyle.BackColor = Color.Red;
                        }
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgr_danhsach.CellFormatting += new DataGridViewCellFormattingEventHandler(dgr_danhsach_CellFormatting);
        }
    }
}
