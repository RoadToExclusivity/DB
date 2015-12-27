namespace CURS
{
    partial class frmAdd
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSpec = new System.Windows.Forms.Button();
            this.txtF = new System.Windows.Forms.TextBox();
            this.txtI = new System.Windows.Forms.TextBox();
            this.txtO = new System.Windows.Forms.TextBox();
            this.btnExam = new System.Windows.Forms.Button();
            this.lstSpec = new System.Windows.Forms.ListBox();
            this.lstExam = new System.Windows.Forms.ListBox();
            this.enroleeDataSet = new CURS.EnrolleesDataSet();
            this.enroleeAdapter = new CURS.EnrolleesDataSetTableAdapters.EnroleeTableAdapter();
            this.enroleeExamAdapter = new CURS.EnrolleesDataSetTableAdapters.EnrolleeExamsTableAdapter();
            this.enroleeSpecAdapter = new CURS.EnrolleesDataSetTableAdapters.EnroleeSpecialityTableAdapter();
            this.specAdapter = new CURS.EnrolleesDataSetTableAdapters.SpecialitiesTableAdapter();
            this.examAdapter = new CURS.EnrolleesDataSetTableAdapters.ExamsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.enroleeDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.Location = new System.Drawing.Point(160, 338);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(83, 29);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClose.Location = new System.Drawing.Point(260, 338);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(79, 29);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Отчество";
            // 
            // btnSpec
            // 
            this.btnSpec.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSpec.Location = new System.Drawing.Point(210, 20);
            this.btnSpec.Name = "btnSpec";
            this.btnSpec.Size = new System.Drawing.Size(139, 44);
            this.btnSpec.TabIndex = 5;
            this.btnSpec.Text = "Выбрать специальности";
            this.btnSpec.UseVisualStyleBackColor = true;
            this.btnSpec.Click += new System.EventHandler(this.btnSpec_Click);
            // 
            // txtF
            // 
            this.txtF.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtF.Location = new System.Drawing.Point(81, 20);
            this.txtF.MaxLength = 50;
            this.txtF.Name = "txtF";
            this.txtF.Size = new System.Drawing.Size(100, 25);
            this.txtF.TabIndex = 6;
            this.txtF.Tag = "Фамилия";
            this.txtF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtF_KeyPress);
            // 
            // txtI
            // 
            this.txtI.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtI.Location = new System.Drawing.Point(81, 55);
            this.txtI.MaxLength = 50;
            this.txtI.Name = "txtI";
            this.txtI.Size = new System.Drawing.Size(100, 25);
            this.txtI.TabIndex = 7;
            this.txtI.Tag = "Имя";
            this.txtI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtI_KeyPress);
            // 
            // txtO
            // 
            this.txtO.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtO.Location = new System.Drawing.Point(81, 88);
            this.txtO.MaxLength = 50;
            this.txtO.Name = "txtO";
            this.txtO.Size = new System.Drawing.Size(100, 25);
            this.txtO.TabIndex = 8;
            this.txtO.Tag = "Отчество";
            this.txtO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtO_KeyPress);
            // 
            // btnExam
            // 
            this.btnExam.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExam.Location = new System.Drawing.Point(368, 20);
            this.btnExam.Name = "btnExam";
            this.btnExam.Size = new System.Drawing.Size(139, 44);
            this.btnExam.TabIndex = 9;
            this.btnExam.Text = "Выбрать экзамены";
            this.btnExam.UseVisualStyleBackColor = true;
            this.btnExam.Click += new System.EventHandler(this.btnExam_Click);
            // 
            // lstSpec
            // 
            this.lstSpec.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lstSpec.FormattingEnabled = true;
            this.lstSpec.ItemHeight = 17;
            this.lstSpec.Location = new System.Drawing.Point(210, 79);
            this.lstSpec.Name = "lstSpec";
            this.lstSpec.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstSpec.Size = new System.Drawing.Size(139, 225);
            this.lstSpec.TabIndex = 10;
            this.lstSpec.Tag = "специальности";
            // 
            // lstExam
            // 
            this.lstExam.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lstExam.FormattingEnabled = true;
            this.lstExam.ItemHeight = 17;
            this.lstExam.Location = new System.Drawing.Point(368, 79);
            this.lstExam.MultiColumn = true;
            this.lstExam.Name = "lstExam";
            this.lstExam.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstExam.Size = new System.Drawing.Size(139, 225);
            this.lstExam.TabIndex = 11;
            this.lstExam.Tag = "экзамены";
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
            // enroleeExamAdapter
            // 
            this.enroleeExamAdapter.ClearBeforeFill = true;
            // 
            // enroleeSpecAdapter
            // 
            this.enroleeSpecAdapter.ClearBeforeFill = true;
            // 
            // specAdapter
            // 
            this.specAdapter.ClearBeforeFill = true;
            // 
            // examAdapter
            // 
            this.examAdapter.ClearBeforeFill = true;
            // 
            // frmAdd
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 379);
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
            this.Controls.Add(this.btnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmAdd";
            this.Text = "Добавить абитуриента";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAdd_FormClosed);
            this.Load += new System.EventHandler(this.frmAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.enroleeDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSpec;
        private System.Windows.Forms.TextBox txtF;
        private System.Windows.Forms.TextBox txtI;
        private System.Windows.Forms.TextBox txtO;
        private System.Windows.Forms.Button btnExam;
        private System.Windows.Forms.ListBox lstSpec;
        private System.Windows.Forms.ListBox lstExam;
        private EnrolleesDataSet enroleeDataSet;
        private EnrolleesDataSetTableAdapters.EnroleeTableAdapter enroleeAdapter;
        private EnrolleesDataSetTableAdapters.EnrolleeExamsTableAdapter enroleeExamAdapter;
        private EnrolleesDataSetTableAdapters.EnroleeSpecialityTableAdapter enroleeSpecAdapter;
        private EnrolleesDataSetTableAdapters.SpecialitiesTableAdapter specAdapter;
        private EnrolleesDataSetTableAdapters.ExamsTableAdapter examAdapter;
    }
}