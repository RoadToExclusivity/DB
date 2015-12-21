using System;
using System.Data;
using System.Windows.Forms;

namespace CURS
{
    public partial class frmAddSpec : Form
    {
        public frmAddSpec()
        {
            InitializeComponent();
        }

        private void frmAddSpec_Load(object sender, EventArgs e)
        {
            specAdapter.Fill(enroleeDataSet.Specialities);
            grid.Top = 0;
            grid.Left = 0;
            grid.Width = this.ClientSize.Width;

            if (Helper.tempAddSpec != null)
            {
                int i = 0;
                foreach (DataRow row in enroleeDataSet.Specialities.Rows)
                {
                    grid.Rows.Add();
                    grid.Rows[i].Cells[0].Value = row[1];
                    bool wasPrev = false;
                    foreach (DataRow prevRow in Helper.tempAddSpec.Rows)
                    {
                        if (prevRow[0].ToString() == row[1].ToString())
                        {
                            if (prevRow[1] !=
                            (grid.Rows[i].Cells[1] as DataGridViewComboBoxCell).Items[0])
                            {
                                wasPrev = true;
                                grid.Rows[i].Cells[1].Value = prevRow[1];
                                break;
                            }
                        }
                    }

                    if (!wasPrev)
                    {
                        grid.Rows[i].Cells[1].Value = (grid.Rows[i].Cells[1] as DataGridViewComboBoxCell).Items[0];
                    }
                    i++;
                }
            }
            else
            {
                int i = 0;
                foreach (DataRow row in enroleeDataSet.Specialities.Rows)
                {
                    grid.Rows.Add();
                    grid.Rows[i].Cells[0].Value = row[1];
                    grid.Rows[i].Cells[1].Value = (grid.Rows[i].Cells[1] as DataGridViewComboBoxCell).Items[0];
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
            bool wasMax = false;
            foreach (DataGridViewRow row in grid.Rows)
            {
                if (row.Cells[1].Value.ToString() != (row.Cells[1] as DataGridViewComboBoxCell).Items[0].ToString())
                {
                    if (row.Cells[1].Value.ToString() == "MAX")
                    {
                        if (!wasMax)
                        {
                            wasMax = true;
                        }
                        else
                        {
                            MessageBox.Show("Выбрано несколько специальностей с максимальным приоритетом", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    var newRow = newDataTable.NewRow();
                    newRow[0] = row.Cells[0].Value;
                    newRow[1] = row.Cells[1].Value;
                    newDataTable.Rows.Add(newRow);
                }
            }

            Helper.tempAddSpec = newDataTable;

            this.Close();
        }
    }
}
