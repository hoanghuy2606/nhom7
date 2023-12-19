using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmfind
{
    public partial class Form1 : Form
    {
        SqlConnection connsql = new SqlConnection(Ketnoi.stringConnect);

        public Form1()
        {
            InitializeComponent();
            DisplayData();

        }

        private void btn_FindProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_Lookup.Text))
                {
                    MessageBox.Show("Thông tin tìm kiếm không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                dataGridView1.Rows.Clear();
                string select_string = $"SELECT sp.*, lsp.TENLOAI FROM SANPHAM sp INNER JOIN LOAISANPHAM lsp ON sp.LOAISP = lsp.LOAISP WHERE sp.MASP='{txt_Lookup.Text}'";
                SqlDataAdapter sda = new SqlDataAdapter(select_string, connsql);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);
                dataGridView1.DataSource = dtable;
            }
            catch (Exception)
            {


            }
        }

        private void dtgv_Product_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DisplayData();
        }
        private void DisplayData()
        {
            try
            {
                dtgv_Product.Rows.Clear();
                string selectAll_string = "SELECT sp.*, lsp.TENLOAI FROM SANPHAM sp INNER JOIN LOAISANPHAM lsp ON sp.LOAISP = lsp.LOAISP";
                SqlDataAdapter sda = new SqlDataAdapter(selectAll_string, connsql);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);
                dtgv_Product.DataSource = dtable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}

