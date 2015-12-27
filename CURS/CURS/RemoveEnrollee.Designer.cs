namespace CURS
{
    partial class frmRemove
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
            this.gridEnrollee = new System.Windows.Forms.DataGridView();
            this.enroleeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.enrAdapter = new CURS.EnrolleesDataSetTableAdapters.EnroleeTableAdapter();
            this.iDАбитуриентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.enrolleeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEnrollee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enroleeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // enrolleeDataSet
            // 
            this.enrolleeDataSet.DataSetName = "EnrolleesDataSet";
            this.enrolleeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.gridEnrollee.Location = new System.Drawing.Point(12, 0);
            this.gridEnrollee.MultiSelect = false;
            this.gridEnrollee.Name = "gridEnrollee";
            this.gridEnrollee.ReadOnly = true;
            this.gridEnrollee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridEnrollee.Size = new System.Drawing.Size(240, 404);
            this.gridEnrollee.TabIndex = 0;
            // 
            // enroleeBindingSource
            // 
            this.enroleeBindingSource.DataMember = "Enrolee";
            this.enroleeBindingSource.DataSource = this.enrolleeDataSet;
            // 
            // enrAdapter
            // 
            this.enrAdapter.ClearBeforeFill = true;
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
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(191, 433);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(96, 32);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Удалить";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(293, 433);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(96, 32);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmRemove
            // 
            this.AcceptButton = this.btnRemove;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 477);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.gridEnrollee);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmRemove";
            this.Text = "Удалить абитуриента";
            this.Load += new System.EventHandler(this.frmRemove_Load);
            ((System.ComponentModel.ISupportInitialize)(this.enrolleeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEnrollee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enroleeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private EnrolleesDataSet enrolleeDataSet;
        private System.Windows.Forms.DataGridView gridEnrollee;
        private System.Windows.Forms.BindingSource enroleeBindingSource;
        private EnrolleesDataSetTableAdapters.EnroleeTableAdapter enrAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDАбитуриентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отчествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnClose;
    }
}