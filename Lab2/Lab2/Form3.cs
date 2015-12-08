using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Lab2
{
    public partial class frmAddDoctors : Form
    {
        private Lab1DataSet ds;
        private int count;
        private int curRecord;

        private struct DBData
        {
            public string doctorF;
            public string doctorI;
            public string doctorO;
            public int doctorCab;
            public string doctorPhotoString;
        };

        private List<DBData> list;

        public frmAddDoctors(Lab1DataSet dataSet)
        {
            InitializeComponent();
            ds = dataSet;
            count = 0;
            curRecord = 0;
            list = new List<DBData>();
        }

        private void ShowPicture(string fileName)
        {
            try
            {
                pic.Image = Image.FromFile(fileName);
            }
            catch
            {
                pic.Image = Image.FromFile("error.png");
            }
        }

        private void ShowRecord()
        {
            if (count == 0)
            {
                return;
            }

            txtFam.Text = list[curRecord - 1].doctorF;
            txtName.Text = list[curRecord - 1].doctorI;
            txtOt.Text = list[curRecord - 1].doctorO;
            txtCab.Text = list[curRecord - 1].doctorCab.ToString();
            ShowPicture(list[curRecord - 1].doctorPhotoString);
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            var doctors = ds.Doctors;

            foreach (DataRow row in doctors.Rows)
            {
                DBData curData;
                
                curData.doctorF = row[1].ToString();
                curData.doctorI = row[2].ToString();
                curData.doctorO = row[3].ToString();
                curData.doctorCab = Convert.ToInt32(row[4].ToString());
                curData.doctorPhotoString = row[5].ToString();

                list.Add(curData);
                count++;
            }
            curRecord = 1;
            ShowRecord();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            curRecord++;
            if (!btnPrev.Enabled)
            {
                btnPrev.Enabled = true;
            }

            if (curRecord >= count)
            {
                btnNext.Enabled = false;
                curRecord = count;
            }

            ShowRecord();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            curRecord--;
            if (!btnNext.Enabled)
            {
                btnNext.Enabled = true;
            }

            if (curRecord < 2)
            {
                btnPrev.Enabled = false;
                curRecord = 1;
            }

            ShowRecord();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (count > 0)
            {
                list.RemoveAt(curRecord - 1);
                count--;
                if (curRecord >= count)
                {
                    curRecord = count;
                    btnNext.Enabled = false;
                }
                ShowRecord();
            }
            else
            {
                MessageBox.Show("Больше нет записей !", "Ошибка !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            count++;
            curRecord = count;
            
            DBData newData;
            newData.doctorF = "";
            newData.doctorI = "";
            newData.doctorO = "";
            newData.doctorCab = 0;
            newData.doctorPhotoString = "";
            list.Add(newData);

            btnNext.Enabled = false;
            if (curRecord > 1)
            {
                btnPrev.Enabled = true;
            }

            txtFam.Text = "";
            txtCab.Text = "";
            txtName.Text = "";
            txtOt.Text = "";
            pic.Image = null;
            
            MessageBox.Show("Добавлена новая запись !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmAdd_FormClosed(object sender, FormClosedEventArgs e)
        {
            Lab1DataSet.DoctorsDataTable table = new Lab1DataSet.DoctorsDataTable();
            for (int i = 0; i < count; ++i)
            {
                Lab1DataSet.DoctorsRow row = table.NewDoctorsRow();
                
                row.Фамилия = list[i].doctorF;
                row.Имя = list[i].doctorI;
                row.Отчество = list[i].doctorO;
                row.Кабинет = list[i].doctorCab;
                row.Фотография = list[i].doctorPhotoString;
                row.Код = i + 1;

                try
                {
                    table.Rows.Add(row);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            TempDataTransferer.newDoctorsDataTable = table;
        }

        private void pic_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = false;
            ofd.ShowDialog();
            string fileName = ofd.FileName;
            if (fileName != "")
            {
                var item = list[curRecord - 1];
                item.doctorPhotoString = Path.GetFileName(fileName);
                list[curRecord - 1] = item;

                ShowPicture(fileName);
            }
        }

        private void txtFam_TextChanged(object sender, EventArgs e)
        {
            var item = list[curRecord - 1];
            item.doctorF = txtFam.Text;
            list[curRecord - 1] = item;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            var item = list[curRecord - 1];
            item.doctorI = txtName.Text;
            list[curRecord - 1] = item;
        }

        private void txtOt_TextChanged(object sender, EventArgs e)
        {
            var item = list[curRecord - 1];
            item.doctorO = txtOt.Text;
            list[curRecord - 1] = item;
        }

        private void txtCab_TextChanged(object sender, EventArgs e)
        {
            var item = list[curRecord - 1];
            try
            {
                item.doctorCab = Convert.ToInt32(txtCab.Text);
            }
            catch
            {
                item.doctorCab = 0;
            }

            list[curRecord - 1] = item;
        }
    }
}
