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
        public frm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lab1DataSet.Doctors". При необходимости она может быть перемещена или удалена.
            //this.doctorTableAdapter.Fill(this.lab1DataSet.Doctors);
            this.OnResize(e);
        }

        private void doctorsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lab1DataSet);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            grid.Top = mnu.Height;
            grid.Left = 0;
            grid.Size = this.ClientSize;
            grid.Height -= nav.Height + mnu.Height;
        }

        private void поВрачамToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingSource.DataSource = lab1DataSet.Doctors;
            doctorsTableAdapter.Fill(lab1DataSet.Doctors);
            tableAdapterManager.DoctorsTableAdapter = doctorsTableAdapter;
            grid.DataSource = bindingSource;

            this.Validate();
            this.bindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(lab1DataSet);
        }

        private void врачиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingSource.DataSource = lab1DataSet.Doctors;
            doctorsTableAdapter.Fill(lab1DataSet.Doctors);
            tableAdapterManager.DoctorsTableAdapter = doctorsTableAdapter;
            grid.DataSource = bindingSource;

            this.Validate();
            this.bindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(lab1DataSet);
        }

        private void больныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingSource.DataSource = lab1DataSet.Patients;
            patientsTableAdapter.Fill(lab1DataSet.Patients);
            tableAdapterManager.PatientsTableAdapter = patientsTableAdapter;
            grid.DataSource = bindingSource;

            this.Validate();
            this.bindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(lab1DataSet);
        }

        private void посещенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingSource.DataSource = lab1DataSet.Reception;
            receptionTableAdapter.Fill(lab1DataSet.Reception);
            tableAdapterManager.ReceptionTableAdapter = receptionTableAdapter;
            grid.DataSource = bindingSource;

            this.Validate();
            this.bindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(lab1DataSet);
        }

        private void grid_SelectionChanged(object sender, EventArgs e)
        { 
            var patients = lab1DataSet.Doctors.FindByКод(2).GetChildRows("ВрачиПрием");
            
            MessageBox.Show(patients.Length.ToString());
        }
    }
}
