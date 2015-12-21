using System;
using System.Data;
using System.Windows.Forms;

namespace CURS
{
    public partial class frmAddExam : Form
    {
        public frmAddExam()
        {
            InitializeComponent();
        }

        private void frmAddExam_Load(object sender, EventArgs e)
        {
            examsAdapter.Fill(enroleeDataSet.Exams);
            grid.Top = 0;
            grid.Left = 0;
            grid.Width = this.ClientSize.Width;

            if (Helper.tempAddExam != null)
            {
                int i = 0;
                foreach (DataRow row in enroleeDataSet.Exams.Rows)
                {
                    grid.Rows.Add();
                    grid.Rows[i].Cells[0].Value = row[1];
                    bool wasPrev = false;
                    foreach (DataRow prevRow in Helper.tempAddExam.Rows)
                    {
                        if (prevRow[0].ToString() == row[1].ToString())
                        {
                            wasPrev = true;
                            grid.Rows[i].Cells[1].Value = prevRow[1];
                            break;
                        }
                    }

                    if (!wasPrev)
                    {
                        grid.Rows[i].Cells[1].Value = "";
                    }
                    i++;
                }
            }
            else
            {
                int i = 0;
                foreach (DataRow row in enroleeDataSet.Exams.Rows)
                {
                    grid.Rows.Add();
                    grid.Rows[i].Cells[0].Value = row[1];
                    grid.Rows[i].Cells[1].Value = "";
                    i++;
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataTable newDataTable = new DataTable();
            newDataTable.Columns.Add();
            newDataTable.Columns.Add();
            foreach (DataGridViewRow row in grid.Rows)
            {
                if (row.Cells[1].Value != null && row.Cells[1].Value.ToString() != "")
                {
                    int result = 0;
                    if (!Int32.TryParse(row.Cells[1].Value.ToString(), out result))
                    {
                        MessageBox.Show("Неверный формат данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (result < 0 || result > 100)
                    {
                        MessageBox.Show("Неверный формат данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    var newRow = newDataTable.NewRow();
                    newRow[0] = row.Cells[0].Value;
                    newRow[1] = row.Cells[1].Value;
                    newDataTable.Rows.Add(newRow);
                }
            }

            Helper.tempAddExam = newDataTable;

            this.Close();
        }
    }
}
