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
            this.btnAdd = new System.Windows.Forms.Button();
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
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.Location = new System.Drawing.Point(154, 330);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(82, 29);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // frmEdit
            // 
            this.AcceptButton = this.btnAdd;
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
            this.Controls.Add(this.btnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmEdit";
            this.Text = "Изменить абитуриента";
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
        private System.Windows.Forms.Button btnAdd;
    }
}