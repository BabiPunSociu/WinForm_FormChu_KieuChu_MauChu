using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai9Trang70
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn thoát không?", "Cảnh báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void ckbBold_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbBold.Checked)
                txtHienThi.Font = new Font(txtHienThi.Font, txtHienThi.Font.Style ^ FontStyle.Bold);
            else
                txtHienThi.Font = new Font(txtHienThi.Font, txtHienThi.Font.Style ^ FontStyle.Bold);
        }

        private void ckbItalic_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbItalic.Checked)
                txtHienThi.Font = new Font(txtHienThi.Font, txtHienThi.Font.Style ^ FontStyle.Italic);
            else
                txtHienThi.Font = new Font(txtHienThi.Font, txtHienThi.Font.Style ^ FontStyle.Italic);
        }

        private void ckbStrikeout_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbStrikeout.Checked)
                txtHienThi.Font = new Font(txtHienThi.Font, txtHienThi.Font.Style ^ FontStyle.Strikeout);
            else
                txtHienThi.Font = new Font(txtHienThi.Font, txtHienThi.Font.Style ^ FontStyle.Strikeout);
        }

        private void ckbUnderline_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbUnderline.Checked)
                txtHienThi.Font = new Font(txtHienThi.Font, txtHienThi.Font.Style ^ FontStyle.Underline);
            else
                txtHienThi.Font = new Font(txtHienThi.Font, txtHienThi.Font.Style ^ FontStyle.Underline);
        }

        private void rdoRed_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoRed.Checked)
                txtHienThi.ForeColor = Color.Red;
            if (rdoOrange.Checked)
                txtHienThi.ForeColor = Color.Orange;
            if (rdoPink.Checked)
                txtHienThi.ForeColor = Color.Pink;
            if (rdoYellow.Checked)
                txtHienThi.ForeColor = Color.Yellow;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtHienThi.Font = new Font("Microsoft Sans Serif", 24);
            txtHienThi.Font = new Font(txtHienThi.Font,FontStyle.Regular);
            txtHienThi.ForeColor = Color.Black;
        }
    }
}
