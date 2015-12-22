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
    public partial class frmEnrForSpec : Form
    {
        public frmEnrForSpec()
        {
            InitializeComponent();
        }

        private void frmEnrForSpec_Load(object sender, EventArgs e)
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
        }

        private void gridSpec_SelectionChanged(object sender, EventArgs e)
        {
            if (gridSpec.SelectedRows.Count == 0)
            {
                return;
            }

            gridEnrollee.Rows.Clear();
            var row = gridSpec.SelectedRows[0];
            int idSpec = Convert.ToInt32(row.Cells[0].Value.ToString());
            var rows = enrolleeDataSet.Specialities.FindByID_специальности(idSpec).GetChildRows("Specialities_EnroleeSpeciality");
            foreach (var newRow in rows)
            {
                int id = Convert.ToInt32(newRow[0].ToString());
                gridEnrollee.Rows.Add();
                var foundRow = enrolleeDataSet.Enrolee.FindByID_абитуриента(id);
                gridEnrollee.Rows[gridEnrollee.Rows.Count - 1].Cells[0].Value = foundRow[1].ToString();
                gridEnrollee.Rows[gridEnrollee.Rows.Count - 1].Cells[1].Value = foundRow[2].ToString();
                gridEnrollee.Rows[gridEnrollee.Rows.Count - 1].Cells[2].Value = foundRow[3].ToString();
                string prior = newRow[2].ToString();
                if (prior == "0")
                {
                    prior = "MAX";
                }
                gridEnrollee.Rows[gridEnrollee.Rows.Count - 1].Cells[3].Value = prior;
            }
        }
    }
}
