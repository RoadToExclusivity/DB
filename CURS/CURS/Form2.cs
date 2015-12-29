using System;
using System.Data;
using System.Windows.Forms;

namespace CURS
{
    public partial class frmAdd : Form
    {
        public frmAdd()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!CheckForEmpty(txtF) || !CheckForEmpty(txtI) || !CheckForEmpty(txtO) || 
                !CheckForEmpty(lstSpec) || !CheckForEmpty(lstExam))
            {
                return;
            }

            string surname = txtF.Text;
            string name = txtI.Text;
            string patronymic = txtO.Text;

            //create new enrolee
            var newEnrolee = enroleeDataSet.Enrolee.NewEnroleeRow();
            newEnrolee.Имя = name;
            newEnrolee.Фамилия = surname;
            newEnrolee.Отчество = patronymic;
            newEnrolee.ID_абитуриента = enroleeDataSet.Enrolee.Rows.Count + 1;
            
            enroleeDataSet.Enrolee.Rows.Add(newEnrolee);
            enroleeAdapter.Update(enroleeDataSet.Enrolee);

            foreach (var item in lstSpec.Items)
            {
                var newSpec = enroleeDataSet.EnroleeSpeciality.NewEnroleeSpecialityRow();
                newSpec.ID_абитуриента = Convert.ToInt32(enroleeDataSet.Enrolee.Rows[enroleeDataSet.Enrolee.Rows.Count - 1][0].ToString());
                
                string[] spl = item.ToString().Split('-');
                string spec = spl[0].Substring(0, spl[0].Length - 1);
                string priorStr = spl[1].Substring(1, spl[1].Length - 1);
                int prior = 0;
                if (priorStr != "MAX")
                {
                    prior = Convert.ToInt32(priorStr);
                }

                foreach (var row in enroleeDataSet.Specialities)
                {
                    if (row.Название_специальности == spec)
                    {
                        newSpec.ID_специальности = row.ID_специальности;
                        break;
                    }
                }
                newSpec.Приоритет = prior;

                enroleeDataSet.EnroleeSpeciality.Rows.Add(newSpec);
            }
            enroleeSpecAdapter.Update(enroleeDataSet.EnroleeSpeciality);

            foreach (var item in lstExam.Items)
            {
                var newExam = enroleeDataSet.EnrolleeExams.NewEnrolleeExamsRow();
                newExam.ID_абитуриента = Convert.ToInt32(enroleeDataSet.Enrolee.Rows[enroleeDataSet.Enrolee.Rows.Count - 1][0].ToString());

                string[] spl = item.ToString().Split('-');
                string exam = spl[0].Substring(0, spl[0].Length - 1);
                int ball = Convert.ToInt32(spl[1].Substring(1, spl[1].Length - 1));

                foreach (var row in enroleeDataSet.Exams)
                {
                    if (row.Название_экзамена == exam)
                    {
                        newExam.ID_экзамена = row.ID_экзамена;
                        break;
                    }
                }
                newExam.Количество_баллов_за_экзамен = ball;

                enroleeDataSet.EnrolleeExams.Rows.Add(newExam);
            }
            enroleeExamAdapter.Update(enroleeDataSet.EnrolleeExams);

            this.Close();
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

        private void frmAdd_FormClosed(object sender, FormClosedEventArgs e)
        {
            Helper.tempAddSpec = null;
            Helper.tempAddExam = null;
        }

        private void frmAdd_Load(object sender, EventArgs e)
        {
            enroleeAdapter.Fill(enroleeDataSet.Enrolee);
            enroleeSpecAdapter.Fill(enroleeDataSet.EnroleeSpeciality);
            specAdapter.Fill(enroleeDataSet.Specialities);
            examAdapter.Fill(enroleeDataSet.Exams);
            enroleeExamAdapter.Fill(enroleeDataSet.EnrolleeExams);
        }
    }
}
