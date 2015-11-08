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

        private void врачиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isNeedRecUpd = false;
            isFullClientSize = true;
            SetGridDefault();

            gridRec.Visible = false;
            bindingSource.DataSource = lab1DataSet.Doctors;
            bindingSource.AllowNew = true;
            grid.DataSource = bindingSource;
            grid.Columns[0].Visible = false;

            this.OnResize(e);
        }

        private void больныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
            isNeedRecUpd = false;
            isFullClientSize = true;
            SetGridDefault();

            gridRec.Visible = false;
            bindingSource.DataSource = lab1DataSet.Reception;
            bindingSource.AllowNew = true;

            grid.DataSource = bindingSource;

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
                cloneTable.Columns[0].Caption = "Фамилия врача";
                cloneTable.Columns[1].Caption = "Фамилия больного";
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
                        string time = (Convert.ToDateTime(cloneRow["Время приема"])).ToString("hh:mm");

                        if (isDoctorUpd)
                        {

                        }
                        else
                        {

                        }

                        cloneRow["Время приема"] = time; 
                        cloneTable.ImportRow(cloneRow);
                    }
                }
                gridRec.DataSource = cloneTable;
            }
        }

        private void поВрачамToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
    }
}
