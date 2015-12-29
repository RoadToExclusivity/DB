using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CURS
{
    public partial class frmGridEdit : Form
    {
        public frmGridEdit()
        {
            InitializeComponent();
        }

        private void frmGridEdit_Load(object sender, EventArgs e)
        {
            enrAdapter.Fill(enrolleesDataSet.Enrolee);

            gridEnrollee.Left = 0;
            gridEnrollee.Top = 0;
            gridEnrollee.Width = this.ClientSize.Width;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (gridEnrollee.SelectedRows.Count == 0)
            {
                return;
            }

            int id = Convert.ToInt32(gridEnrollee.SelectedRows[0].Cells[0].Value.ToString());
            Helper.enrID = id;

            frmEdit edit = new frmEdit();
            this.Visible = false;
            edit.ShowDialog();
            this.Close();
        }
    }
}
