namespace CURS
{
    partial class frmList
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
            this.components = new System.ComponentModel.Container();
            this.enrolleeDataSet = new CURS.EnrolleesDataSet();
            this.specAdapter = new CURS.EnrolleesDataSetTableAdapters.SpecialitiesTableAdapter();
            this.enrolleeAdapter = new CURS.EnrolleesDataSetTableAdapters.EnroleeTableAdapter();
            this.enrSpecAdapter = new CURS.EnrolleesDataSetTableAdapters.EnroleeSpecialityTableAdapter();
            this.gridSpec = new System.Windows.Forms.DataGridView();
            this.iDСпециальностиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеСпециальностиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоВакантныхМестDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialitiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridEnrollee = new System.Windows.Forms.DataGridView();
            this.colSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPatr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBalls = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enrExamAdapter = new CURS.EnrolleesDataSetTableAdapters.EnrolleeExamsTableAdapter();
            this.specExamAdapter = new CURS.EnrolleesDataSetTableAdapters.SpecialityExamsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.enrolleeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSpec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialitiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEnrollee)).BeginInit();
            this.SuspendLayout();
            // 
            // enrolleeDataSet
            // 
            this.enrolleeDataSet.DataSetName = "EnrolleesDataSet";
            this.enrolleeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // specAdapter
            // 
            this.specAdapter.ClearBeforeFill = true;
            // 
            // enrolleeAdapter
            // 
            this.enrolleeAdapter.ClearBeforeFill = true;
            // 
            // enrSpecAdapter
            // 
            this.enrSpecAdapter.ClearBeforeFill = true;
            // 
            // gridSpec
            // 
            this.gridSpec.AllowUserToAddRows = false;
            this.gridSpec.AllowUserToDeleteRows = false;
            this.gridSpec.AllowUserToOrderColumns = true;
            this.gridSpec.AutoGenerateColumns = false;
            this.gridSpec.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridSpec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSpec.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDСпециальностиDataGridViewTextBoxColumn,
            this.названиеСпециальностиDataGridViewTextBoxColumn,
            this.количествоВакантныхМестDataGridViewTextBoxColumn});
            this.gridSpec.DataSource = this.specialitiesBindingSource;
            this.gridSpec.Location = new System.Drawing.Point(0, 0);
            this.gridSpec.MultiSelect = false;
            this.gridSpec.Name = "gridSpec";
            this.gridSpec.ReadOnly = true;
            this.gridSpec.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridSpec.Size = new System.Drawing.Size(240, 150);
            this.gridSpec.TabIndex = 0;
            this.gridSpec.SelectionChanged += new System.EventHandler(this.gridSpec_SelectionChanged);
            // 
            // iDСпециальностиDataGridViewTextBoxColumn
            // 
            this.iDСпециальностиDataGridViewTextBoxColumn.DataPropertyName = "ID специальности";
            this.iDСпециальностиDataGridViewTextBoxColumn.HeaderText = "ID специальности";
            this.iDСпециальностиDataGridViewTextBoxColumn.Name = "iDСпециальностиDataGridViewTextBoxColumn";
            this.iDСпециальностиDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDСпециальностиDataGridViewTextBoxColumn.Visible = false;
            // 
            // названиеСпециальностиDataGridViewTextBoxColumn
            // 
            this.названиеСпециальностиDataGridViewTextBoxColumn.DataPropertyName = "Название специальности";
            this.названиеСпециальностиDataGridViewTextBoxColumn.HeaderText = "Название специальности";
            this.названиеСпециальностиDataGridViewTextBoxColumn.Name = "названиеСпециальностиDataGridViewTextBoxColumn";
            this.названиеСпециальностиDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // количествоВакантныхМестDataGridViewTextBoxColumn
            // 
            this.количествоВакантныхМестDataGridViewTextBoxColumn.DataPropertyName = "Количество вакантных мест";
            this.количествоВакантныхМестDataGridViewTextBoxColumn.HeaderText = "Количество вакантных мест";
            this.количествоВакантныхМестDataGridViewTextBoxColumn.Name = "количествоВакантныхМестDataGridViewTextBoxColumn";
            this.количествоВакантныхМестDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // specialitiesBindingSource
            // 
            this.specialitiesBindingSource.DataMember = "Specialities";
            this.specialitiesBindingSource.DataSource = this.enrolleeDataSet;
            // 
            // gridEnrollee
            // 
            this.gridEnrollee.AllowUserToAddRows = false;
            this.gridEnrollee.AllowUserToDeleteRows = false;
            this.gridEnrollee.AllowUserToOrderColumns = true;
            this.gridEnrollee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridEnrollee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEnrollee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSurname,
            this.colName,
            this.colPatr,
            this.colBalls});
            this.gridEnrollee.Location = new System.Drawing.Point(12, 169);
            this.gridEnrollee.Name = "gridEnrollee";
            this.gridEnrollee.ReadOnly = true;
            this.gridEnrollee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridEnrollee.Size = new System.Drawing.Size(240, 150);
            this.gridEnrollee.TabIndex = 1;
            // 
            // colSurname
            // 
            this.colSurname.HeaderText = "Фамилия абитуриента";
            this.colSurname.Name = "colSurname";
            this.colSurname.ReadOnly = true;
            // 
            // colName
            // 
            this.colName.HeaderText = "Имя абитуриента";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colPatr
            // 
            this.colPatr.HeaderText = "Отчество абитуриента";
            this.colPatr.Name = "colPatr";
            this.colPatr.ReadOnly = true;
            // 
            // colBalls
            // 
            this.colBalls.HeaderText = "Набранные баллы";
            this.colBalls.Name = "colBalls";
            this.colBalls.ReadOnly = true;
            // 
            // enrExamAdapter
            // 
            this.enrExamAdapter.ClearBeforeFill = true;
            // 
            // specExamAdapter
            // 
            this.specExamAdapter.ClearBeforeFill = true;
            // 
            // frmList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 631);
            this.Controls.Add(this.gridEnrollee);
            this.Controls.Add(this.gridSpec);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmList";
            this.Text = "Списки поступивших";
            this.Load += new System.EventHandler(this.frmList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.enrolleeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSpec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialitiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEnrollee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private EnrolleesDataSet enrolleeDataSet;
        private EnrolleesDataSetTableAdapters.SpecialitiesTableAdapter specAdapter;
        private EnrolleesDataSetTableAdapters.EnroleeTableAdapter enrolleeAdapter;
        private EnrolleesDataSetTableAdapters.EnroleeSpecialityTableAdapter enrSpecAdapter;
        private System.Windows.Forms.DataGridView gridSpec;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDСпециальностиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеСпециальностиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоВакантныхМестDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource specialitiesBindingSource;
        private System.Windows.Forms.DataGridView gridEnrollee;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPatr;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBalls;
        private EnrolleesDataSetTableAdapters.EnrolleeExamsTableAdapter enrExamAdapter;
        private EnrolleesDataSetTableAdapters.SpecialityExamsTableAdapter specExamAdapter;
    }
}