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
            Helper.tempAddSpec = null;
            Helper.tempAddExam = null;
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
    }
}
