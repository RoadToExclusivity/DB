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
    public partial class frmEnrolees : Form
    {
        public frmEnrolees()
        {
            InitializeComponent();
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdd frmAddEnrolee = new frmAdd();
            frmAddEnrolee.ShowDialog();
        }

        private void посмотретьСпискиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSpecForEnrollee frmSpecForEnrollee = new frmSpecForEnrollee();
            frmSpecForEnrollee.Show();
        }

        private void показатьПоСпециальностямToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEnrForSpec frmShowEnrollees = new frmEnrForSpec();
            frmShowEnrollees.Show();
        }

        private void сформироватьСпискиПоступившихToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmList newList = new frmList();
            newList.Show();
        }
    }
}
