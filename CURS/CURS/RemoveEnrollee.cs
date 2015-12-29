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
            enrExamAdapter.Fill(enrolleeDataSet.EnrolleeExams);
            enrSpecAdapter.Fill(enrolleeDataSet.EnroleeSpeciality);

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
            
            var specs = enrolleeDataSet.Enrolee.FindByID_абитуриента(id).GetChildRows("Enrolee_EnroleeSpeciality");
            foreach (var row in specs)
            {
                row.Delete();
            }
            enrSpecAdapter.Update(enrolleeDataSet.EnroleeSpeciality);

            var exams = enrolleeDataSet.Enrolee.FindByID_абитуриента(id).GetChildRows("Enrolee_EnrolleeExams");
            foreach (var row in specs)
            {
                row.Delete();
            }
            enrExamAdapter.Update(enrolleeDataSet.EnrolleeExams);

            var rowEnr = enrolleeDataSet.Enrolee.FindByID_абитуриента(id);
            rowEnr.Delete();
            enrAdapter.Update(enrolleeDataSet.Enrolee);

            gridEnrollee.Update();
        }
    }
}
