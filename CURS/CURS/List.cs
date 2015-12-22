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
    public partial class frmList : Form
    {
        List<List<int>> spec = new List<List<int>>();
        List<int> rest = new List<int>();
        List<int> enrBall = new List<int>();

        public frmList()
        {
            InitializeComponent();
        }

        private void frmList_Load(object sender, EventArgs e)
        {
            enrolleeAdapter.Fill(enrolleeDataSet.Enrolee);
            enrSpecAdapter.Fill(enrolleeDataSet.EnroleeSpeciality);
            specAdapter.Fill(enrolleeDataSet.Specialities);

            gridSpec.Left = 0;
            gridSpec.Top = 0;
            gridSpec.Width = this.ClientSize.Width;
            gridSpec.Height = this.ClientSize.Height / 2 - 5;

            gridEnrollee.Left = 0;
            gridEnrollee.Top = this.ClientSize.Height / 2 + 5;
            gridEnrollee.Width = this.ClientSize.Width;
            gridEnrollee.Height = this.ClientSize.Height / 2 - 5;

            SortedDictionary<int, int> exams = new SortedDictionary<int, int>();
            foreach (DataRow enr in enrolleeDataSet.Enrolee.Rows)
            {
                int id = Convert.ToInt32(enr[0].ToString());
               
                var examRows = enrolleeDataSet.Enrolee.FindByID_абитуриента(id).GetChildRows("Enrolee_EnrolleeExams");
                foreach (var examRow in examRows)
                {
                    int examID = Convert.ToInt32(examRow[1].ToString());
                    int ball = Convert.ToInt32(examRow[2].ToString());

                    exams.Add(examID, ball);
                }

                //int sum = 0;
                //var specExamsRows = enrolleeDataSet.Specialities.FindByID_специальности(idSpec).GetChildRows("Specialities_SpecialityExams");
                //foreach (var specExam in specExamsRows)
                //{
                //    int examID = Convert.ToInt32(specExam[1].ToString());
                //    if (exams.ContainsKey(examID))
                //    {
                //        sum += exams[examID];
                //    }
                //}
            }

            foreach (DataGridViewRow row in gridSpec.Rows)
            {
                List<int> curSpec = new List<int>();
                int idSpec = Convert.ToInt32(row.Cells[0].Value.ToString());
                var specRow = enrolleeDataSet.Specialities.FindByID_специальности(idSpec);
                rest.Add(Convert.ToInt32(specRow[2].ToString()));

                var enrRows = enrolleeDataSet.Specialities.FindByID_специальности(idSpec).GetChildRows("Specialities_EnroleeSpeciality");
                foreach (var enrRow in enrRows)
                {
                    int id = Convert.ToInt32(enrRow[0].ToString());
                    curSpec.Add(id);
                }
            }
        }
    }
}
