using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;



namespace GUI_Cafe
{
    public partial class Datban : Form
    {
        BUS_Datban BusDatban = new BUS_Datban();
        bool db, db1;
        int Maban;
        public Datban()
        {
            InitializeComponent();
            db = db1 = true;
            Lock_Unlock1(db1);
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void Datban_Load(object sender, EventArgs e)
        {
            dgvDatban.DataSource = BusDatban.getDB();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtBan.Text!="" && txtTKH.Text != "" && txtNgay.Text != "" && txtSDT.Text != "")
            {
                if(BusDatban.insertDatban(txtBan.Text, txtTKH.Text, txtNgay.Text, txtSDT.Text))
                {
                    MessageBox.Show("Thêm bàn đặt thành công !");
                }
                else
                {
                    MessageBox.Show("thông tin chưa đầy đủ!");
                }
            }
            else
            {
                MessageBox.Show("thông tin chưa đầy đủ!");
                txtTKH.Focus();
            }
        }

        private void dgvDatban_Click(object sender, EventArgs e)
        {
            int i = dgvDatban.CurrentRow.Index;
            Maban = int.Parse(dgvDatban[0, i].Value.ToString());
            txtBan.Text = dgvDatban[1, i].Value.ToString();
            txtTKH.Text = dgvDatban[2, 1].Value.ToString();
            txtSDT.Text = dgvDatban[3, 1].Value.ToString();
            txtNgay.Text = dgvDatban[4, 1].Value.ToString();
            db1 = !db1;
            Lock_Unlock1(db1);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (BusDatban.deleteDatban(Maban))
            {
                MessageBox.Show("Xoá thành công!");
                db1 = !db1;
                Lock_Unlock1(db1);
            }
            else
            {
                MessageBox.Show("xoá thất bại!");
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtBan.Text != "" && txtTKH.Text != "" && txtNgay.Text != "" && txtSDT.Text != "")
            {
                if (BusDatban.updateDatban( Maban, txtBan.Text, txtTKH.Text, txtNgay.Text, txtSDT.Text))
                {
                    MessageBox.Show("Chỉnh sửa thành công !");
                    db1 = !db1;
                    Lock_Unlock1(db1);
                }
                else
                {
                    MessageBox.Show("thông tin chưa đầy đủ!");
                }
            }
            else
            {
                MessageBox.Show("thông tin chưa đầy đủ!");
                txtTKH.Focus();
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            db1 = !db1;
            Lock_Unlock1(db1);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            BusDatban.seachDatban(txttimkiem.Text);
        }

        void Lock_Unlock1(bool db1)
        {
            dgvDatban.Enabled = db1;
            btnDelete.Enabled = btnEdit.Enabled = btnShow.Enabled = !db1;
        }
    }
}
