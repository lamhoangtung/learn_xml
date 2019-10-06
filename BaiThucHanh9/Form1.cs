using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace BaiThucHanh9
{
    public partial class Form1 : Form
    {
        XmlDocument doc = new XmlDocument();
        public static string path = "../../csdl.xml";

        private void load_combobox()
        {
            DataSet dts = new DataSet();
            dts.ReadXml(path);
            cmbMaSinhVien.DataSource = dts.Tables["sinhvien"];
            cmbMaSinhVien.DisplayMember = "masv";
            cmbMonHoc.DataSource = dts.Tables["sinhvien"];
            cmbMonHoc.DisplayMember = "monhoc";
        }

        private void hien_thi()
        {
            listView1.Items.Clear();
            DataSet dts = new DataSet();
            DataTable dtl = new DataTable();
            dts.ReadXml(path);
            dtl = dts.Tables["sinhvien"];
            if (dtl.Rows.Count > 0)
            {
                int i = 1;
                foreach (DataRow dr in dtl.Rows)
                {
                    ListViewItem lvi = new ListViewItem(i.ToString());
                    lvi.SubItems.Add(dr["masv"].ToString());
                    lvi.SubItems.Add(dr["monhoc"].ToString());
                    lvi.SubItems.Add(dr["diemlan1"].ToString());
                    lvi.SubItems.Add(dr["diemlan2"].ToString());
                    i++;
                    listView1.Items.Add(lvi);
                }
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để hiển thị!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        public Form1()
        {
            InitializeComponent();
            load_combobox();
            hien_thi();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                cmbMaSinhVien.Text = item.SubItems[1].Text;
                cmbMonHoc.Text = item.SubItems[2].Text;
                txtDiemLan1.Text = item.SubItems[3].Text;
                txtDiemLan2.Text = item.SubItems[4].Text;
            }
        }
    }
}
