using System;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;

namespace CURS
{
    public partial class frmAddSpec : Form
    {
        private int curPrior = 0;
        private bool stillLoad = true;

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
                for (int j = 0; j <= Helper.tempAddSpec.Rows.Count; ++j )
                {
                    string pr = j.ToString();
                    if (pr == "0")
                    {
                        pr = "MAX";
                    }
                    this.colPrior.Items.Add(pr);
                }
                curPrior = Helper.tempAddSpec.Rows.Count;

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
                                int pr = 0;
                                if (prevRow[1].ToString() != "MAX")
                                {
                                    pr = Convert.ToInt32(prevRow[1].ToString());
                                }
                                grid.Rows[i].Cells[1].Value = (grid.Rows[i].Cells[1] as DataGridViewComboBoxCell).Items[pr + 1];
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
                this.colPrior.Items.Add("MAX");
                foreach (DataRow row in enroleeDataSet.Specialities.Rows)
                {
                    grid.Rows.Add();
                    grid.Rows[i].Cells[0].Value = row[1];
                    grid.Rows[i].Cells[1].Value = (grid.Rows[i].Cells[1] as DataGridViewComboBoxCell).Items[0];
                    i++;
                }
            }

            stillLoad = false;
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

        private void grid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex  < 0 || stillLoad || e.ColumnIndex != 1)
            {
                return;
            }

            string newValue = grid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            int newPrior = -1;
            if (newValue == "MAX")
            {
                newPrior = 0;
            }
            else
            {
                if (newValue != "Нет")
                {
                    newPrior = Convert.ToInt32(newValue);
                }
            }

            if (newPrior == curPrior)
            {
                curPrior++;
                this.colPrior.Items.Add(curPrior.ToString());
            }
            else
            {
                if (newPrior > -1)
                {
                    for (int i = 0; i < grid.Rows.Count; ++i)
                    {
                        string pr = grid.Rows[i].Cells[1].Value.ToString();
                        int newPr = -1;
                        if (pr == "MAX")
                        {
                            newPr = 0;
                        }
                        else
                        {
                            if (pr != "Нет")
                            {
                                newPr = Convert.ToInt32(pr);
                            }   
                        }

                        if (newPr == newPrior)
                        {
                            grid.Rows[i].Cells[1].Value = (grid.Rows[i].Cells[1] as DataGridViewComboBoxCell).Items[0];
                            break;
                        }
                    }
                }
                else
                {
                    //for (int i = 0; i < grid.Rows.Count; ++i)
                    //{
                    //    string pr = grid.Rows[i].Cells[1].Value.ToString();
                    //    int newPr = -1;
                    //    if (pr == "MAX")
                    //    {
                    //        newPr = 0;
                    //    }
                    //    else
                    //    {
                    //        newPr = Convert.ToInt32(pr);
                    //    }

                    //    if (newPr == newPrior)
                    //    {
                    //        grid.Rows[i].Cells[1].Value = (grid.Rows[i].Cells[1] as DataGridViewComboBoxCell).Items[0];
                    //        break;
                    //    }
                    //}
                }
            }
        }
    }
}
