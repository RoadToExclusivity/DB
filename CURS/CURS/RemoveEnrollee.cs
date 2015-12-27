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
    public partial class frmRemove : Form
    {
        public frmRemove()
        {
            InitializeComponent();
        }

        private void frmRemove_Load(object sender, EventArgs e)
        {
            enrAdapter.Fill(enrolleeDataSet.Enrolee);

            gridEnrollee.Left = 0;
            gridEnrollee.Top = 0;
            gridEnrollee.Width = this.ClientSize.Width;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
