namespace CURS
{
    partial class frmEdit
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
            this.lstExam = new System.Windows.Forms.ListBox();
            this.lstSpec = new System.Windows.Forms.ListBox();
            this.btnExam = new System.Windows.Forms.Button();
            this.txtO = new System.Windows.Forms.TextBox();
            this.txtI = new System.Windows.Forms.TextBox();
            this.txtF = new System.Windows.Forms.TextBox();
            this.btnSpec = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.enroleeDataSet = new CURS.EnrolleesDataSet();
            this.enroleeAdapter = new CURS.EnrolleesDataSetTableAdapters.EnroleeTableAdapter();
            this.enroleeSpecAdapter = new CURS.EnrolleesDataSetTableAdapters.EnroleeSpecialityTableAdapter();
            this.enrExamAdapter = new CURS.EnrolleesDataSetTableAdapters.EnrolleeExamsTableAdapter();
            this.examAdapter = new CURS.EnrolleesDataSetTableAdapters.ExamsTableAdapter();
            this.specAdapter = new CURS.EnrolleesDataSetTableAdapters.SpecialitiesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.enroleeDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lstExam
            // 
            this.lstExam.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lstExam.FormattingEnabled = true;
            this.lstExam.ItemHeight = 17;
            this.lstExam.Location = new System.Drawing.Point(362, 71);
            this.lstExam.MultiColumn = true;
            this.lstExam.Name = "lstExam";
            this.lstExam.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstExam.Size = new System.Drawing.Size(138, 225);
            this.lstExam.TabIndex = 23;
            this.lstExam.Tag = "экзамены";
            // 
            // lstSpec
            // 
            this.lstSpec.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lstSpec.FormattingEnabled = true;
            this.lstSpec.ItemHeight = 17;
            this.lstSpec.Location = new System.Drawing.Point(204, 71);
            this.lstSpec.Name = "lstSpec";
            this.lstSpec.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstSpec.Size = new System.Drawing.Size(138, 225);
            this.lstSpec.TabIndex = 22;
            this.lstSpec.Tag = "специальности";
            // 
            // btnExam
            // 
            this.btnExam.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExam.Location = new System.Drawing.Point(362, 12);
            this.btnExam.Name = "btnExam";
            this.btnExam.Size = new System.Drawing.Size(138, 44);
            this.btnExam.TabIndex = 21;
            this.btnExam.Text = "Выбрать экзамены";
            this.btnExam.UseVisualStyleBackColor = true;
            this.btnExam.Click += new System.EventHandler(this.btnExam_Click);
            // 
            // txtO
            // 
            this.txtO.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtO.Location = new System.Drawing.Point(75, 80);
            this.txtO.MaxLength = 50;
            this.txtO.Name = "txtO";
            this.txtO.Size = new System.Drawing.Size(99, 25);
            this.txtO.TabIndex = 20;
            this.txtO.Tag = "Отчество";
            this.txtO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtO_KeyPress);
            // 
            // txtI
            // 
            this.txtI.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtI.Location = new System.Drawing.Point(75, 47);
            this.txtI.MaxLength = 50;
            this.txtI.Name = "txtI";
            this.txtI.Size = new System.Drawing.Size(99, 25);
            this.txtI.TabIndex = 19;
            this.txtI.Tag = "Имя";
            this.txtI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtI_KeyPress);
            // 
            // txtF
            // 
            this.txtF.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtF.Location = new System.Drawing.Point(75, 12);
            this.txtF.MaxLength = 50;
            this.txtF.Name = "txtF";
            this.txtF.Size = new System.Drawing.Size(99, 25);
            this.txtF.TabIndex = 18;
            this.txtF.Tag = "Фамилия";
            this.txtF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtF_KeyPress);
            // 
            // btnSpec
            // 
            this.btnSpec.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSpec.Location = new System.Drawing.Point(204, 12);
            this.btnSpec.Name = "btnSpec";
            this.btnSpec.Size = new System.Drawing.Size(138, 44);
            this.btnSpec.TabIndex = 17;
            this.btnSpec.Text = "Выбрать специальности";
            this.btnSpec.UseVisualStyleBackColor = true;
            this.btnSpec.Click += new System.EventHandler(this.btnSpec_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Отчество";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Имя";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Фамилия";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClose.Location = new System.Drawing.Point(254, 330);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(78, 29);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEdit.Location = new System.Drawing.Point(154, 330);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(82, 29);
            this.btnEdit.TabIndex = 12;
            this.btnEdit.Text = "Изменить";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // enroleeDataSet
            // 
            this.enroleeDataSet.DataSetName = "EnrolleesDataSet";
            this.enroleeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // enroleeAdapter
            // 
            this.enroleeAdapter.ClearBeforeFill = true;
            // 
            // enroleeSpecAdapter
            // 
            this.enroleeSpecAdapter.ClearBeforeFill = true;
            // 
            // enrExamAdapter
            // 
            this.enrExamAdapter.ClearBeforeFill = true;
            // 
            // examAdapter
            // 
            this.examAdapter.ClearBeforeFill = true;
            // 
            // specAdapter
            // 
            this.specAdapter.ClearBeforeFill = true;
            // 
            // frmEdit
            // 
            this.AcceptButton = this.btnEdit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 366);
            this.Controls.Add(this.lstExam);
            this.Controls.Add(this.lstSpec);
            this.Controls.Add(this.btnExam);
            this.Controls.Add(this.txtO);
            this.Controls.Add(this.txtI);
            this.Controls.Add(this.txtF);
            this.Controls.Add(this.btnSpec);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmEdit";
            this.Text = "Изменить абитуриента";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmEdit_FormClosed);
            this.Load += new System.EventHandler(this.frmEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.enroleeDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstExam;
        private System.Windows.Forms.ListBox lstSpec;
        private System.Windows.Forms.Button btnExam;
        private System.Windows.Forms.TextBox txtO;
        private System.Windows.Forms.TextBox txtI;
        private System.Windows.Forms.TextBox txtF;
        private System.Windows.Forms.Button btnSpec;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnEdit;
        private EnrolleesDataSet enroleeDataSet;
        private EnrolleesDataSetTableAdapters.EnroleeTableAdapter enroleeAdapter;
        private EnrolleesDataSetTableAdapters.EnroleeSpecialityTableAdapter enroleeSpecAdapter;
        private EnrolleesDataSetTableAdapters.EnrolleeExamsTableAdapter enrExamAdapter;
        private EnrolleesDataSetTableAdapters.ExamsTableAdapter examAdapter;
        private EnrolleesDataSetTableAdapters.SpecialitiesTableAdapter specAdapter;
    }
}