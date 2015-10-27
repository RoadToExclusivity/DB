using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class frm : Form
    {
        private bool isFullClientSize;
        private bool isNeedRecUpd;
        private bool isDoctorUpd;

        public frm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            doctorsTableAdapter.Fill(lab1DataSet.Doctors);
            patientsTableAdapter.Fill(lab1DataSet.Patients);
            receptionTableAdapter.Fill(lab1DataSet.Reception);

            tableAdapterManager.DoctorsTableAdapter = doctorsTableAdapter;
            tableAdapterManager.PatientsTableAdapter = patientsTableAdapter;
            tableAdapterManager.ReceptionTableAdapter = receptionTableAdapter;
            
            isFullClientSize = true;
            isNeedRecUpd = false;
            isDoctorUpd = true;

            this.OnResize(e);
        }

        private void doctorsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bindingSource.EndEdit();
            this.receptionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(lab1DataSet);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            int gridHeight = this.ClientSize.Height - mnu.Height - nav.Height;
            if (!isFullClientSize)
            {
                gridHeight /= 2;
            }

            grid.Top = mnu.Height;
            grid.Left = 0;
            grid.Width = Width;
            grid.Height = gridHeight;

            gridRec.Top = grid.Height + grid.Top;
            gridRec.Left = 0;
            gridRec.Width = Width;
            gridRec.Height = gridHeight;
        }

        private void поВрачамToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isNeedRecUpd = true;
            isDoctorUpd = true;

            isFullClientSize = false;
            bindingSource.DataSource = lab1DataSet.Doctors;
            grid.DataSource = bindingSource;
            grid.ReadOnly = true;

            gridRec.Visible = true;
            this.OnResize(e);
        }

        private void врачиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isNeedRecUpd = false;
            isFullClientSize = true;

            gridRec.Visible = false;
            bindingSource.DataSource = lab1DataSet.Doctors;
            grid.DataSource = bindingSource;
            grid.ReadOnly = false;

            this.OnResize(e);
        }

        private void больныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isNeedRecUpd = false;
            isFullClientSize = true;

            gridRec.Visible = false;
            bindingSource.DataSource = lab1DataSet.Patients;
            grid.DataSource = bindingSource;
            grid.ReadOnly = false;

            this.Validate();
            this.bindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(lab1DataSet);

            this.OnResize(e);
        }

        private void посещенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isNeedRecUpd = false;
            isFullClientSize = true;

            gridRec.Visible = false;
            bindingSource.DataSource = lab1DataSet.Reception;
            grid.DataSource = bindingSource;
            grid.ReadOnly = false;

            this.Validate();
            this.bindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(lab1DataSet);

            this.OnResize(e);
        }

        private void grid_SelectionChanged(object sender, EventArgs e)
        {
            if (!isNeedRecUpd)
            {
                return;
            }

            var rows = grid.SelectedRows;
            if (rows.Count == 1)
            {
                var row = rows[0];
                int selRowIndex = (int)row.Cells[0].Value;
                DataTable cloneTable = lab1DataSet.Reception.Clone();
                if (selRowIndex >= 0 && selRowIndex < grid.RowCount)
                {
                    DataRow[] patients;
                    if (isDoctorUpd)
                    {
                        patients = lab1DataSet.Doctors.FindByКод(selRowIndex).GetChildRows("ВрачиПрием");
                    }
                    else
                    {
                        patients = lab1DataSet.Patients.FindByКод(selRowIndex).GetChildRows("БольныеПрием");
                    }
                    
                    foreach (DataRow cloneRow in patients)
                    {
                        cloneTable.ImportRow(cloneRow);
                    }
                }
                gridRec.DataSource = cloneTable;
            }
        }

        private void поПацентамToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isNeedRecUpd = true;
            isDoctorUpd = false;
            isFullClientSize = false;

            bindingSource.DataSource = lab1DataSet.Patients;
            grid.DataSource = bindingSource;
            grid.ReadOnly = true;

            gridRec.Visible = true;
            this.OnResize(e);
        }
    }
}
