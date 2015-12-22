namespace CURS
{
    partial class frmSpecForEnrollee
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
            this.enrSpecAdapter = new CURS.EnrolleesDataSetTableAdapters.EnroleeSpecialityTableAdapter();
            this.enroleeAdapter = new CURS.EnrolleesDataSetTableAdapters.EnroleeTableAdapter();
            this.gridEnrollee = new System.Windows.Forms.DataGridView();
            this.iDАбитуриентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enroleeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridSpec = new System.Windows.Forms.DataGridView();
            this.colSpec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBalls = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specAdapter = new CURS.EnrolleesDataSetTableAdapters.SpecialitiesTableAdapter();
            this.specExamAdapter = new CURS.EnrolleesDataSetTableAdapters.SpecialityExamsTableAdapter();
            this.enrolleeExamAdapter = new CURS.EnrolleesDataSetTableAdapters.EnrolleeExamsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.enrolleeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEnrollee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enroleeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSpec)).BeginInit();
            this.SuspendLayout();
            // 
            // enrolleeDataSet
            // 
            this.enrolleeDataSet.DataSetName = "EnrolleesDataSet";
            this.enrolleeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // enrSpecAdapter
            // 
            this.enrSpecAdapter.ClearBeforeFill = true;
            // 
            // enroleeAdapter
            // 
            this.enroleeAdapter.ClearBeforeFill = true;
            // 
            // gridEnrollee
            // 
            this.gridEnrollee.AllowUserToAddRows = false;
            this.gridEnrollee.AllowUserToDeleteRows = false;
            this.gridEnrollee.AllowUserToOrderColumns = true;
            this.gridEnrollee.AutoGenerateColumns = false;
            this.gridEnrollee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridEnrollee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEnrollee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDАбитуриентаDataGridViewTextBoxColumn,
            this.фамилияDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn,
            this.отчествоDataGridViewTextBoxColumn});
            this.gridEnrollee.DataSource = this.enroleeBindingSource;
            this.gridEnrollee.Location = new System.Drawing.Point(0, 0);
            this.gridEnrollee.MultiSelect = false;
            this.gridEnrollee.Name = "gridEnrollee";
            this.gridEnrollee.ReadOnly = true;
            this.gridEnrollee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridEnrollee.Size = new System.Drawing.Size(388, 150);
            this.gridEnrollee.TabIndex = 0;
            this.gridEnrollee.SelectionChanged += new System.EventHandler(this.gridEnrollee_SelectionChanged);
            // 
            // iDАбитуриентаDataGridViewTextBoxColumn
            // 
            this.iDАбитуриентаDataGridViewTextBoxColumn.DataPropertyName = "ID абитуриента";
            this.iDАбитуриентаDataGridViewTextBoxColumn.HeaderText = "ID абитуриента";
            this.iDАбитуриентаDataGridViewTextBoxColumn.Name = "iDАбитуриентаDataGridViewTextBoxColumn";
            this.iDАбитуриентаDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDАбитуриентаDataGridViewTextBoxColumn.Visible = false;
            // 
            // фамилияDataGridViewTextBoxColumn
            // 
            this.фамилияDataGridViewTextBoxColumn.DataPropertyName = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.Name = "фамилияDataGridViewTextBoxColumn";
            this.фамилияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // имяDataGridViewTextBoxColumn
            // 
            this.имяDataGridViewTextBoxColumn.DataPropertyName = "Имя";
            this.имяDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.имяDataGridViewTextBoxColumn.Name = "имяDataGridViewTextBoxColumn";
            this.имяDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // отчествоDataGridViewTextBoxColumn
            // 
            this.отчествоDataGridViewTextBoxColumn.DataPropertyName = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.Name = "отчествоDataGridViewTextBoxColumn";
            this.отчествоDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // enroleeBindingSource
            // 
            this.enroleeBindingSource.AllowNew = false;
            this.enroleeBindingSource.DataMember = "Enrolee";
            this.enroleeBindingSource.DataSource = this.enrolleeDataSet;
            // 
            // gridSpec
            // 
            this.gridSpec.AllowUserToAddRows = false;
            this.gridSpec.AllowUserToDeleteRows = false;
            this.gridSpec.AllowUserToOrderColumns = true;
            this.gridSpec.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridSpec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSpec.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSpec,
            this.colBalls});
            this.gridSpec.Location = new System.Drawing.Point(0, 209);
            this.gridSpec.Name = "gridSpec";
            this.gridSpec.ReadOnly = true;
            this.gridSpec.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridSpec.Size = new System.Drawing.Size(507, 165);
            this.gridSpec.TabIndex = 1;
            // 
            // colSpec
            // 
            this.colSpec.HeaderText = "Специальность";
            this.colSpec.Name = "colSpec";
            this.colSpec.ReadOnly = true;
            // 
            // colBalls
            // 
            this.colBalls.HeaderText = "Баллы";
            this.colBalls.Name = "colBalls";
            this.colBalls.ReadOnly = true;
            // 
            // specAdapter
            // 
            this.specAdapter.ClearBeforeFill = true;
            // 
            // specExamAdapter
            // 
            this.specExamAdapter.ClearBeforeFill = true;
            // 
            // enrolleeExamAdapter
            // 
            this.enrolleeExamAdapter.ClearBeforeFill = true;
            // 
            // frmSpecForEnrollee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 576);
            this.Controls.Add(this.gridSpec);
            this.Controls.Add(this.gridEnrollee);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmSpecForEnrollee";
            this.Text = "Список специальностей для абитуриентов";
            this.Load += new System.EventHandler(this.frmSpecForEnrollee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.enrolleeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEnrollee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enroleeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSpec)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private EnrolleesDataSet enrolleeDataSet;
        private EnrolleesDataSetTableAdapters.EnroleeSpecialityTableAdapter enrSpecAdapter;
        private EnrolleesDataSetTableAdapters.EnroleeTableAdapter enroleeAdapter;
        private System.Windows.Forms.DataGridView gridEnrollee;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDАбитуриентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отчествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView gridSpec;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSpec;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBalls;
        private System.Windows.Forms.BindingSource enroleeBindingSource;
        private EnrolleesDataSetTableAdapters.SpecialitiesTableAdapter specAdapter;
        private EnrolleesDataSetTableAdapters.SpecialityExamsTableAdapter specExamAdapter;
        private EnrolleesDataSetTableAdapters.EnrolleeExamsTableAdapter enrolleeExamAdapter;
    }
}