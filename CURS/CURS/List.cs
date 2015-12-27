using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CURS
{
    public partial class frmList : Form
    {
        struct SortedBall
        {
            public int ball;
            public int id;
            public int prior;

            public int CompareTo(SortedBall b)
            {
                if (ball > b.ball)
                {
                    return 1;
                }
                else
                {
                    if (ball < b.ball)
                    {
                        return -1;
                    }
                    else
                    {
                        if (prior < b.prior)
                        {
                            return 1;
                        }
                        else
                        {
                            if (prior > b.prior)
                            {
                                return -1;
                            }

                            return 0;
                        }
                    }
                }
            }
        };

        int Compare(SortedBall a, SortedBall b)
        {
            return a.CompareTo(b);
        }

        List<List<SortedBall>> specSorted = new List<List<SortedBall>>();
        List<int> rest = new List<int>();
        List<List<int>> enrBall = new List<List<int>>();
        List<bool> enrUsed = new List<bool>();
        List<List<int>> enrSpec = new List<List<int>>();
        List<List<int>> resList = new List<List<int>>();

        public frmList()
        {
            InitializeComponent();
        }

        private void frmList_Load(object sender, EventArgs e)
        {
            enrolleeAdapter.Fill(enrolleeDataSet.Enrolee);
            enrSpecAdapter.Fill(enrolleeDataSet.EnroleeSpeciality);
            specAdapter.Fill(enrolleeDataSet.Specialities);
            enrExamAdapter.Fill(enrolleeDataSet.EnrolleeExams);
            specExamAdapter.Fill(enrolleeDataSet.SpecialityExams);

            gridSpec.Left = 0;
            gridSpec.Top = 0;
            gridSpec.Width = this.ClientSize.Width;
            gridSpec.Height = this.ClientSize.Height / 2 - 5;

            gridEnrollee.Left = 0;
            gridEnrollee.Top = this.ClientSize.Height / 2 + 5;
            gridEnrollee.Width = this.ClientSize.Width;
            gridEnrollee.Height = this.ClientSize.Height / 2 - 5;

            int enrCount = enrolleeDataSet.Enrolee.Rows.Count;
            int specCount = enrolleeDataSet.Specialities.Rows.Count;

            foreach (DataRow enr in enrolleeDataSet.Enrolee.Rows)
            {
                SortedDictionary<int, int> exams = new SortedDictionary<int, int>();
                List<int> curSpecBalls = new List<int>();
                int id = Convert.ToInt32(enr[0].ToString());
                enrUsed.Add(false);

                var examRows = enrolleeDataSet.Enrolee.FindByID_абитуриента(id).GetChildRows("Enrolee_EnrolleeExams");
                foreach (var examRow in examRows)
                {
                    int examID = Convert.ToInt32(examRow[1].ToString());
                    int ball = Convert.ToInt32(examRow[2].ToString());

                    exams.Add(examID, ball);
                }

                foreach (DataRow row in enrolleeDataSet.Specialities.Rows)
                {
                    int sum = 0;
                    var specExamsRows = enrolleeDataSet.Specialities.FindByID_специальности(Convert.ToInt32(row[0].ToString())).GetChildRows("Specialities_SpecialityExams");
                    foreach (var specExam in specExamsRows)
                    {
                        int examID = Convert.ToInt32(specExam[1].ToString());
                        if (exams.ContainsKey(examID))
                        {
                            sum += exams[examID];
                        }
                    }
                    curSpecBalls.Add(sum);
                }
                enrBall.Add(curSpecBalls);

                List<int> specs = new List<int>();
                List<int> priors = new List<int>();

                var specRows = enrolleeDataSet.Enrolee.FindByID_абитуриента(id).GetChildRows("Enrolee_EnroleeSpeciality");
                specs.AddRange(Enumerable.Repeat(-1, specRows.Length));
                foreach (var specRow in specRows)
                {
                    int idSpec = Convert.ToInt32(specRow[1].ToString());
                    int prior = Convert.ToInt32(specRow[2].ToString());

                    specs[prior] = idSpec - 1;
                }

                enrSpec.Add(specs);
            }

            foreach (DataRow row in enrolleeDataSet.Specialities.Rows)
            {
                List<SortedBall> curSpecBalls = new List<SortedBall>();
                int idSpec = Convert.ToInt32(row[0].ToString());
                rest.Add(Convert.ToInt32(row[2].ToString()));

                var enrRows = enrolleeDataSet.Specialities.FindByID_специальности(idSpec).GetChildRows("Specialities_EnroleeSpeciality");
                foreach (var enrRow in enrRows)
                {
                    int id = Convert.ToInt32(enrRow[0].ToString());
                    SortedBall b;
                    b.ball = enrBall[id - 1][idSpec - 1];
                    b.id = id - 1;
                    b.prior = Convert.ToInt32(enrRow[2].ToString());
                    curSpecBalls.Add(b);
                }

                curSpecBalls.Sort(Compare);
                curSpecBalls.Reverse();
                specSorted.Add(curSpecBalls);
            }

            int curPrior = 0;
            int resEnr = enrCount;
            resList.AddRange(Enumerable.Repeat(new List<int>(), specCount));
            while (resEnr > 0)
            {
                bool wasAdded = false;
                List<int> need = new List<int>();
                List<int> other = new List<int>();

                for (int i = 0; i < enrCount; ++i)
                {
                    if (!enrUsed[i])
                    {
                        if (enrSpec[i].Count > curPrior)
                        {
                            int idSpec = enrSpec[i][curPrior];
                            if (rest[idSpec] > 0)
                            {
                               bool found = false;
                               int m = rest[idSpec];
                               if (m > specSorted[idSpec].Count)
                               {
                                   m = specSorted[idSpec].Count;
                               }

                               for (int ii = 0; ii < m; ++ii )
                               {
                                   if (specSorted[idSpec][ii].id == i)
                                   {
                                       found = true;
                                       break;
                                   }
                               }

                               if (found)
                               {
                                   bool reallyNeed = true;
                                   for (int ii = 0; ii < curPrior; ++ii )
                                   {
                                       if (rest[enrSpec[i][ii]] != 0)
                                       {
                                           reallyNeed = false;
                                           break;
                                       }
                                   }

                                   if (reallyNeed)
                                   {
                                       need.Add(i);
                                   }
                                   else
                                   {
                                       other.Add(i);
                                   }
                               }
                            }
                        }
                    }
                }

                int index = -1;
                if (need.Count > 0)
                {
                    index = need[0];
                }
                else
                {
                    if (other.Count > 0)
                    {
                        index = other[0];
                    }
                }

                if (index != -1)
                {
                    int idSpec = enrSpec[index][curPrior];
                    rest[idSpec]--;
                    List<int> list = new List<int>(resList[idSpec]);
                    resList[idSpec] = new List<int>();
                    list.Add(index + 1);
                    resList[idSpec] = list;
                    resEnr--;
                    enrUsed[index] = true;
                    for (int j = 0; j < enrSpec[index].Count; ++j)
                    {
                        for (int k = 0; k < specSorted[enrSpec[index][j]].Count; ++k)
                        {
                            if (specSorted[enrSpec[index][j]][k].id == index)
                            {
                                specSorted[enrSpec[index][j]].RemoveAt(k);
                                break;
                            }
                        }
                    }
                    wasAdded = true;
                }

                if (!wasAdded)
                {
                    curPrior++;
                    if (curPrior > 21)
                    {
                        string message = "Нет вариантов для " + resEnr.ToString() + " абитуриентa(-ов): " + Environment.NewLine;
                        for (int i = 0; i < enrCount; ++i)
                        {
                            if (!enrUsed[i])
                            {
                                var row = enrolleeDataSet.Enrolee.FindByID_абитуриента(i + 1);
                                message = message + row[1].ToString() + " " + row[2].ToString() + " " + row[3].ToString() + " " + Environment.NewLine;
                            }
                        }
                        MessageBox.Show(message, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                }
                else
                {
                    curPrior = 0;
                }
            }

            gridSpec_SelectionChanged(sender, e);
        }

        private void gridSpec_SelectionChanged(object sender, EventArgs e)
        {
            if (gridSpec.SelectedRows.Count == 0)
            {
                return;
            }

            gridEnrollee.Rows.Clear();
            int id = Convert.ToInt32(gridSpec.SelectedRows[0].Cells[0].Value.ToString());
            if (resList.Count == 0) return;
            for(int i = 0; i < resList[id - 1].Count; ++i)
            {
                gridEnrollee.Rows.Add();
                var enr = enrolleeDataSet.Enrolee.FindByID_абитуриента(resList[id - 1][i]);
                gridEnrollee.Rows[gridEnrollee.Rows.Count - 1].Cells[0].Value = enr[1].ToString();
                gridEnrollee.Rows[gridEnrollee.Rows.Count - 1].Cells[1].Value = enr[2].ToString();
                gridEnrollee.Rows[gridEnrollee.Rows.Count - 1].Cells[2].Value = enr[3].ToString();
                gridEnrollee.Rows[gridEnrollee.Rows.Count - 1].Cells[3].Value = enrBall[resList[id - 1][i] - 1][id - 1].ToString();
            }
        }
    }
}
