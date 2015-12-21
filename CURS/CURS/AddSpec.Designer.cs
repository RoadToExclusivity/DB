namespace CURS
{
    partial class frmAddSpec
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
            this.specAdapter = new CURS.EnrolleesDataSetTableAdapters.SpecialitiesTableAdapter();
            this.adapterManager = new CURS.EnrolleesDataSetTableAdapters.TableAdapterManager();
            this.grid = new System.Windows.Forms.DataGridView();
            this.colSpec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrior = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.enroleeDataSet = new CURS.EnrolleesDataSet();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enroleeDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // specAdapter
            // 
            this.specAdapter.ClearBeforeFill = true;
            // 
            // adapterManager
            // 
            this.adapterManager.BackupDataSetBeforeUpdate = false;
            this.adapterManager.EnroleeSpecialityTableAdapter = null;
            this.adapterManager.EnroleeTableAdapter = null;
            this.adapterManager.EnrolleeExamsTableAdapter = null;
            this.adapterManager.ExamsTableAdapter = null;
            this.adapterManager.SpecialitiesTableAdapter = this.specAdapter;
            this.adapterManager.SpecialityExamsTableAdapter = null;
            this.adapterManager.UpdateOrder = CURS.EnrolleesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSpec,
            this.colPrior});
            this.grid.Location = new System.Drawing.Point(0, 0);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(262, 492);
            this.grid.TabIndex = 0;
            // 
            // colSpec
            // 
            this.colSpec.HeaderText = "Специальность";
            this.colSpec.Name = "colSpec";
            this.colSpec.ReadOnly = true;
            // 
            // colPrior
            // 
            this.colPrior.HeaderText = "Приоритет";
            this.colPrior.Items.AddRange(new object[] {
            "Нет",
            "MAX",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21"});
            this.colPrior.Name = "colPrior";
            this.colPrior.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // enroleeDataSet
            // 
            this.enroleeDataSet.DataSetName = "EnrolleesDataSet";
            this.enroleeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(205, 511);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(318, 511);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmAddSpec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 544);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmAddSpec";
            this.Text = "Добавить специальности";
            this.Load += new System.EventHandler(this.frmAddSpec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enroleeDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private EnrolleesDataSetTableAdapters.SpecialitiesTableAdapter specAdapter;
        private EnrolleesDataSetTableAdapters.TableAdapterManager adapterManager;
        private System.Windows.Forms.DataGridView grid;
        private EnrolleesDataSet enroleeDataSet;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSpec;
        private System.Windows.Forms.DataGridViewComboBoxColumn colPrior;
    }
}