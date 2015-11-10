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
    public partial class frmAdd : Form
    {
        private Lab1DataSet ds;
        private int count;
        private int curRecord;

        private struct DBData
        {
            public int doctorIndex;
            public int patientIndex;
            public DateTime curDate;
            public bool isPaid;
        };

        private List<DBData> list;

        public frmAdd(Lab1DataSet dataSet)
        {
            InitializeComponent();
            ds = dataSet;
            count = 0;
            curRecord = 0;
            list = new List<DBData>();
            dt.CustomFormat = " dd/MMMM/yyyy  HH:mm";
        }

        private void ShowRecord()
        {
            if (count == 0)
            {
                return;
            }

            cbDoctors.SelectedIndex = list[curRecord - 1].doctorIndex - 1;
            cbPatients.SelectedIndex = list[curRecord - 1].patientIndex - 1;
            dt.Value = list[curRecord - 1].curDate;
            chkPaid.Checked = list[curRecord - 1].isPaid;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            var receptions = ds.Reception;
            foreach (DataRow row in ds.Doctors.Rows)
            {
                cbDoctors.Items.Add(row[1].ToString());
            }

            foreach (DataRow row in ds.Patients.Rows)
            {
                cbPatients.Items.Add(row[1].ToString());
            }

            foreach (DataRow row in receptions.Rows)
            {
                DBData curData;
                int doctorIndex = Convert.ToInt32(row[0]);
                int patientIndex = Convert.ToInt32(row[1]);
                
                curData.doctorIndex = doctorIndex;
                curData.patientIndex = patientIndex;

                string d = row[2].ToString();
                string t = row[3].ToString();
                DateTime date = Convert.ToDateTime(Convert.ToDateTime(row[2].ToString()).ToString("d")
                                + " " + Convert.ToDateTime(row[3].ToString()).ToString("HH:mm"));
                curData.curDate = date;
                curData.isPaid = Convert.ToBoolean(row[4]);

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

        private void chkPaid_CheckedChanged(object sender, EventArgs e)
        {
            var item = list[curRecord - 1];
            item.isPaid = chkPaid.Checked;
            list[curRecord - 1] = item;
        }

        private void dt_ValueChanged(object sender, EventArgs e)
        {
            var item = list[curRecord - 1];
            item.curDate = dt.Value;
            list[curRecord - 1] = item;
        }

        private void cbDoctors_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = list[curRecord - 1];
            item.doctorIndex = cbDoctors.SelectedIndex + 1;
            list[curRecord - 1] = item;
        }

        private void cbPatients_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = list[curRecord - 1];
            item.patientIndex = cbPatients.SelectedIndex + 1;
            list[curRecord - 1] = item;
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
            newData.doctorIndex = 1;
            newData.patientIndex = 1;
            newData.isPaid = false;
            newData.curDate = DateTime.Now;
            list.Add(newData);

            btnNext.Enabled = false;
            if (curRecord > 1)
            {
                btnPrev.Enabled = true;
            }

            cbDoctors.SelectedIndex = 0;
            cbPatients.SelectedIndex = 0;
            dt.Value = DateTime.Now;
            chkPaid.Checked = false;
            
            MessageBox.Show("Добавлена новая запись !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmAdd_FormClosed(object sender, FormClosedEventArgs e)
        {
            Lab1DataSet.ReceptionDataTable table = new Lab1DataSet.ReceptionDataTable();

            for (int i = 0; i < count; ++i)
            {
                Lab1DataSet.ReceptionRow row = table.NewReceptionRow();
                
                row.Код_врача = list[i].doctorIndex;
                row.Код_больного = list[i].patientIndex;
                row.Дата_приема = Convert.ToDateTime(list[i].curDate.ToString("d"));
                row.Время_приема = list[i].curDate.ToString("HH:mm");
                row.Платный_прием = list[i].isPaid;

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

            TempDataTransferer.newDataTable = table;
        }
    }
}
