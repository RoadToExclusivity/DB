namespace CURS
{
    partial class frmAddExam
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.enroleeDataSet = new CURS.EnrolleesDataSet();
            this.adapterManager = new CURS.EnrolleesDataSetTableAdapters.TableAdapterManager();
            this.examsAdapter = new CURS.EnrolleesDataSetTableAdapters.ExamsTableAdapter();
            this.grid = new System.Windows.Forms.DataGridView();
            this.colExamName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBalls = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.enroleeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // enroleeDataSet
            // 
            this.enroleeDataSet.DataSetName = "EnrolleesDataSet";
            this.enroleeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adapterManager
            // 
            this.adapterManager.BackupDataSetBeforeUpdate = false;
            this.adapterManager.EnroleeSpecialityTableAdapter = null;
            this.adapterManager.EnroleeTableAdapter = null;
            this.adapterManager.EnrolleeExamsTableAdapter = null;
            this.adapterManager.ExamsTableAdapter = this.examsAdapter;
            this.adapterManager.SpecialitiesTableAdapter = null;
            this.adapterManager.SpecialityExamsTableAdapter = null;
            this.adapterManager.UpdateOrder = CURS.EnrolleesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // examsAdapter
            // 
            this.examsAdapter.ClearBeforeFill = true;
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colExamName,
            this.colBalls});
            this.grid.Location = new System.Drawing.Point(-5, 2);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(240, 311);
            this.grid.TabIndex = 0;
            // 
            // colExamName
            // 
            this.colExamName.HeaderText = "Название экзамена";
            this.colExamName.Name = "colExamName";
            this.colExamName.ReadOnly = true;
            // 
            // colBalls
            // 
            this.colBalls.HeaderText = "Баллы";
            this.colBalls.Name = "colBalls";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(246, 338);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(133, 338);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmAddExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 373);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmAddExam";
            this.Text = "Выбрать экзамены";
            this.Load += new System.EventHandler(this.frmAddExam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.enroleeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private EnrolleesDataSet enroleeDataSet;
        private EnrolleesDataSetTableAdapters.TableAdapterManager adapterManager;
        private EnrolleesDataSetTableAdapters.ExamsTableAdapter examsAdapter;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExamName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBalls;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAdd;
    }
}