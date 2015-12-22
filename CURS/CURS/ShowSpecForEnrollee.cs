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
    public partial class frmSpecForEnrollee : Form
    {
        public frmSpecForEnrollee()
        {
            InitializeComponent();
        }

        private void frmSpecForEnrollee_Load(object sender, EventArgs e)
        {
            enroleeAdapter.Fill(enrolleeDataSet.Enrolee);
            enrSpecAdapter.Fill(enrolleeDataSet.EnroleeSpeciality);
            specAdapter.Fill(enrolleeDataSet.Specialities);
            enrolleeExamAdapter.Fill(enrolleeDataSet.EnrolleeExams);
            specExamAdapter.Fill(enrolleeDataSet.SpecialityExams);

            gridEnrollee.Left = 0;
            gridEnrollee.Top = 0;
            gridEnrollee.Width = this.ClientSize.Width;
            gridEnrollee.Height = this.ClientSize.Height / 2 - 5;

            gridSpec.Left = 0;
            gridSpec.Width = this.ClientSize.Width;
            gridSpec.Top = this.ClientSize.Height / 2 + 5;
            gridSpec.Height = this.ClientSize.Height / 2 - 5;

            gridEnrollee_SelectionChanged(sender, e);
        }

        private void gridEnrollee_SelectionChanged(object sender, EventArgs e)
        {
            if (gridEnrollee.SelectedRows.Count == 0)
            {
                return;
            }

            gridSpec.Rows.Clear();
            var row = gridEnrollee.SelectedRows[0];
            int id = Convert.ToInt32(row.Cells[0].Value.ToString());
            var rows = enrolleeDataSet.Enrolee.FindByID_абитуриента(id).GetChildRows("Enrolee_EnroleeSpeciality");
            foreach (var newRow in rows)
            {
                int idSpec = Convert.ToInt32(newRow[1].ToString());
                gridSpec.Rows.Add();
                gridSpec.Rows[gridSpec.Rows.Count - 1].Cells[0].Value = enrolleeDataSet.Specialities.FindByID_специальности(idSpec)[1].ToString();

                SortedDictionary<int, int> exams = new SortedDictionary<int, int>();
                var examRows = enrolleeDataSet.Enrolee.FindByID_абитуриента(id).GetChildRows("Enrolee_EnrolleeExams");
                foreach (var examRow in examRows)
                {
                    int examID = Convert.ToInt32(examRow[1].ToString());
                    int ball = Convert.ToInt32(examRow[2].ToString());

                    exams.Add(examID, ball);
                }

                int sum = 0;
                var specExamsRows = enrolleeDataSet.Specialities.FindByID_специальности(idSpec).GetChildRows("Specialities_SpecialityExams");
                foreach (var specExam in specExamsRows)
                {
                    int examID = Convert.ToInt32(specExam[1].ToString());
                    if (exams.ContainsKey(examID))
                    {
                        sum += exams[examID];
                    }
                }

                gridSpec.Rows[gridSpec.Rows.Count - 1].Cells[1].Value = sum.ToString();
            }
        }
    }
}
