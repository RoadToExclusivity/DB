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
    public partial class frmEdit : Form
    {
        public frmEdit()
        {
            InitializeComponent();
        }

        private bool CheckForEmpty(TextBox txt)
        {
            if (txt.Text.Length == 0)
            {
                MessageBox.Show("Пустое текстовое поле : " + txt.Tag, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool CheckForEmpty(ListBox lst)
        {
            if (lst.Items.Count == 0)
            {
                MessageBox.Show("Не выбраны " + lst.Tag, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEdit_Load(object sender, EventArgs e)
        {
            enroleeAdapter.Fill(enroleeDataSet.Enrolee);
            enroleeSpecAdapter.Fill(enroleeDataSet.EnroleeSpeciality);
            specAdapter.Fill(enroleeDataSet.Specialities);
            examAdapter.Fill(enroleeDataSet.Exams);
            enrExamAdapter.Fill(enroleeDataSet.EnrolleeExams);

            int id = Helper.enrID;
            var row = enroleeDataSet.Enrolee.FindByID_абитуриента(id);
            txtF.Text = row[1].ToString();
            txtI.Text = row[2].ToString();
            txtO.Text = row[3].ToString();

            var specRows = row.GetChildRows("Enrolee_EnroleeSpeciality");
            var examRows = row.GetChildRows("Enrolee_EnrolleeExams");

            DataTable newDataSpecTable = new DataTable();
            newDataSpecTable.Columns.Add();
            newDataSpecTable.Columns.Add();
            foreach (var specRow in specRows)
            {
                int specID = Convert.ToInt32(specRow[1].ToString());
                string name = enroleeDataSet.Specialities.FindByID_специальности(specID)[1].ToString();
                string val = specRow[2].ToString();
                if (val == "0")
                {
                    val = "MAX";
                }
                lstSpec.Items.Add(name + " - " + val);

                var newRow = newDataSpecTable.NewRow();
                newRow[0] = name;
                newRow[1] = val;
                newDataSpecTable.Rows.Add(newRow);
            }
            Helper.tempAddSpec = newDataSpecTable;

            DataTable newDataExamTable = new DataTable();
            newDataExamTable.Columns.Add();
            newDataExamTable.Columns.Add();
            foreach (var examRow in examRows)
            {
                int examID = Convert.ToInt32(examRow[1].ToString());
                string name = enroleeDataSet.Exams.FindByID_экзамена(examID)[1].ToString();
                string val = examRow[2].ToString();
                lstExam.Items.Add(name + " - " + val);

                var newRow = newDataExamTable.NewRow();
                newRow[0] = name;
                newRow[1] = val;
                newDataExamTable.Rows.Add(newRow);
            }
            Helper.tempAddExam = newDataExamTable;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!CheckForEmpty(txtF) || !CheckForEmpty(txtI) || !CheckForEmpty(txtO) ||
                !CheckForEmpty(lstSpec) || !CheckForEmpty(lstExam))
            {
                return;
            }
        }

        private void btnSpec_Click(object sender, EventArgs e)
        {
            frmAddSpec addSpec = new frmAddSpec();
            addSpec.ShowDialog();

            if (Helper.tempAddSpec != null)
            {
                lstSpec.Items.Clear();
                foreach (DataRow row in Helper.tempAddSpec.Rows)
                {
                    string name = row[0].ToString();
                    string val = row[1].ToString();
                    lstSpec.Items.Add(name + " - " + val);
                }
            }
        }

        private void btnExam_Click(object sender, EventArgs e)
        {
            frmAddExam addExam = new frmAddExam();
            addExam.ShowDialog();

            if (Helper.tempAddExam != null)
            {
                lstExam.Items.Clear();
                foreach (DataRow row in Helper.tempAddExam.Rows)
                {
                    string name = row[0].ToString();
                    string val = row[1].ToString();
                    lstExam.Items.Add(name + " - " + val);
                }
            }
        }

        private void frmEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
            Helper.tempAddSpec = null;
            Helper.tempAddExam = null;
            Helper.enrID = -1;
        }

        private void txtF_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char pressedKey = e.KeyChar;
            if (Char.IsLetter(pressedKey) || Char.IsControl(pressedKey))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtI_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char pressedKey = e.KeyChar;
            if (Char.IsLetter(pressedKey) || Char.IsControl(pressedKey))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtO_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char pressedKey = e.KeyChar;
            if (Char.IsLetter(pressedKey) || Char.IsControl(pressedKey))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
