using System;
using System.Data;
using System.Windows.Forms;

namespace Lab2
{
    public partial class frm : Form
    {
        private bool isFullClientSize;
        private bool isNeedRecUpd;
        private bool isDoctorUpd;

        private void SetGridDefault()
        {
            grid.AllowUserToAddRows = true;
            grid.AllowUserToDeleteRows = true;
            grid.ReadOnly = false;
        }

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
            try
            {
                this.Validate();
                this.bindingSource.EndEdit();
                this.receptionBindingSource.EndEdit();
                var p = (Lab1DataSet.DoctorsDataTable)lab1DataSet.Doctors.GetChanges(DataRowState.Added);
                this.tableAdapterManager.UpdateAll(lab1DataSet);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void врачиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            doctorsBindingNavigatorSaveItem_Click(sender, e);
            frmAddDoctors frm = new frmAddDoctors(lab1DataSet);
            frm.ShowDialog();
            if (TempDataTransferer.newDoctorsDataTable != null)
            {
                //lab1DataSet.Reception.Clear();
                //lab1DataSet.Reception.Merge(TempDataTransferer.newDataTable);
                for (int i = lab1DataSet.Doctors.Rows.Count - 1; i >= 0; --i)
                {
                    DataRow row = lab1DataSet.Doctors.Rows[i];
                    row.Delete();
                }
                lab1DataSet.Doctors.Merge(TempDataTransferer.newDoctorsDataTable);
                //foreach (DataRow newRow in TempDataTransferer.newDataTable.Rows)
                //{
                //    lab1DataSet.Reception.Rows.Add(newRow.);
                //}
                doctorsBindingNavigatorSaveItem_Click(sender, e);
            }

            this.OnResize(e);
            //nav.Enabled = true;
            //isNeedRecUpd = false;
            //isFullClientSize = true;
            //SetGridDefault();

            //gridRec.Visible = false;
            //bindingSource.DataSource = lab1DataSet.Doctors;
            //bindingSource.AllowNew = true;

            //grid.DataSource = bindingSource;
            //grid.Columns[0].Visible = false;

            //this.OnResize(e);
        }

        private void больныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nav.Enabled = true;
            isNeedRecUpd = false;
            isFullClientSize = true; 
            SetGridDefault();

            gridRec.Visible = false;
            bindingSource.DataSource = lab1DataSet.Patients;
            bindingSource.AllowNew = true;

            grid.DataSource = bindingSource;
            grid.Columns[0].Visible = false;

            this.OnResize(e);
        }

        private void посещенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            doctorsBindingNavigatorSaveItem_Click(sender, e);
            frmAdd frm = new frmAdd(lab1DataSet);
            frm.ShowDialog();
            if (TempDataTransferer.newReceptionDataTable != null)
            {
                //lab1DataSet.Reception.Clear();
                //lab1DataSet.Reception.Merge(TempDataTransferer.newDataTable);
                for (int i = lab1DataSet.Reception.Rows.Count - 1; i >= 0; --i )
                {
                    DataRow row = lab1DataSet.Reception.Rows[i];
                    row.Delete();
                }
                lab1DataSet.Reception.Merge(TempDataTransferer.newReceptionDataTable);
                //foreach (DataRow newRow in TempDataTransferer.newDataTable.Rows)
                //{
                //    lab1DataSet.Reception.Rows.Add(newRow.);
                //}
                doctorsBindingNavigatorSaveItem_Click(sender, e);
            }
            
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
                cloneTable.Columns[0].DataType = typeof(string);
                cloneTable.Columns[1].DataType = typeof(string);

                if (selRowIndex >= 0 && selRowIndex <= grid.RowCount)
                {
                    DataRow[] data;
                    if (isDoctorUpd)
                    {
                        data = lab1DataSet.Doctors.FindByКод(selRowIndex).GetChildRows("ВрачиПрием");
                    }
                    else
                    {
                        data = lab1DataSet.Patients.FindByКод(selRowIndex).GetChildRows("БольныеПрием");
                    }

                    foreach (DataRow cloneRow in data)
                    {
                        cloneTable.ImportRow(cloneRow);
                    }
                }
                gridRec.DataSource = cloneTable;
                gridRec.RowHeadersVisible = false;

                gridRec.Columns[0].HeaderText = "Фамилия врача";
                gridRec.Columns[1].HeaderText = "Фамилия больного";
                gridRec.Columns[0].ValueType = typeof(string);
                gridRec.Columns[1].ValueType = typeof(string);

                foreach (DataGridViewRow cloneRow in gridRec.Rows)
                {
                    string time = (Convert.ToDateTime(cloneRow.Cells[3].Value)).ToString("HH:mm");
                    cloneRow.Cells[3].Value = time;

                    int doctorIndex = Convert.ToInt32(cloneRow.Cells[0].Value);
                    int patientIndex = Convert.ToInt32(cloneRow.Cells[1].Value);
                    DataRow doctorRow = lab1DataSet.Doctors.FindByКод(doctorIndex);
                    DataRow patientRow = lab1DataSet.Patients.FindByКод(patientIndex);

                    cloneRow.Cells[0].Value = doctorRow[1].ToString();
                    cloneRow.Cells[1].Value = patientRow[1].ToString();
                }
            }
        }

        private void поВрачамToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nav.Enabled = true;
            isNeedRecUpd = true;
            isDoctorUpd = true;
            isFullClientSize = false;

            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;

            grid.ReadOnly = true;
            bindingSource.DataSource = lab1DataSet.Doctors;
            bindingSource.AllowNew = false;
            grid.DataSource = bindingSource;
            
            grid.Columns[0].Visible = false;

            gridRec.Visible = true;
            gridRec.Columns[0].Visible = false;
            gridRec.Columns[1].Visible = true;

            this.OnResize(e);
        }

        private void поПацентамToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nav.Enabled = true;
            isNeedRecUpd = true;
            isDoctorUpd = false;
            isFullClientSize = false;

            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            bindingSource.AllowNew = false;

            bindingSource.DataSource = lab1DataSet.Patients;
            grid.DataSource = bindingSource;
            grid.ReadOnly = true;
            grid.Columns[0].Visible = false;

            gridRec.Visible = true;
            gridRec.Columns[0].Visible = true;
            gridRec.Columns[1].Visible = false;

            this.OnResize(e);
        }

        private void всеПосещенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isNeedRecUpd = false;
            isFullClientSize = true;
            SetGridDefault();

            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;

            var cloneReception = lab1DataSet.Reception.Clone();
            cloneReception.Columns[0].DataType = typeof(string);
            cloneReception.Columns[1].DataType = typeof(string);
            foreach (DataRow cloneRow in lab1DataSet.Reception.Rows)
            {
                cloneReception.ImportRow(cloneRow);
            }

            grid.DataSource = cloneReception;
            grid.ReadOnly = true;

            grid.Columns[0].HeaderText = "Фамилия врача";
            grid.Columns[1].HeaderText = "Фамилия больного";

            grid.Columns[0].ValueType = typeof(string);
            grid.Columns[1].ValueType = typeof(string);

            foreach (DataGridViewRow cloneRow in grid.Rows)
            {
                string time = (Convert.ToDateTime(cloneRow.Cells[3].Value)).ToString("HH:mm");
                cloneRow.Cells[3].Value = time;

                int doctorIndex = Convert.ToInt32(cloneRow.Cells[0].Value);
                int patientIndex = Convert.ToInt32(cloneRow.Cells[1].Value);
                DataRow doctorRow = lab1DataSet.Doctors.FindByКод(doctorIndex);
                DataRow patientRow = lab1DataSet.Patients.FindByКод(patientIndex);

                cloneRow.Cells[0].Value = doctorRow[1].ToString();
                cloneRow.Cells[1].Value = patientRow[1].ToString();
            }

            gridRec.Visible = false;
            nav.Enabled = false;

            this.OnResize(e);
        }
    }
}
