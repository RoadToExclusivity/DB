namespace CURS
{
    partial class frmEnrolees
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.mnu = new System.Windows.Forms.MenuStrip();
            this.абитуриентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.посмотретьСпискиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.показатьПоСпециальностямToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сформироватьСпискиПоступившихToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnu
            // 
            this.mnu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.абитуриентыToolStripMenuItem,
            this.показатьПоСпециальностямToolStripMenuItem,
            this.сформироватьСпискиПоступившихToolStripMenuItem});
            this.mnu.Location = new System.Drawing.Point(0, 0);
            this.mnu.Name = "mnu";
            this.mnu.Size = new System.Drawing.Size(506, 24);
            this.mnu.TabIndex = 0;
            this.mnu.Text = "menuStrip1";
            // 
            // абитуриентыToolStripMenuItem
            // 
            this.абитуриентыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.посмотретьСпискиToolStripMenuItem});
            this.абитуриентыToolStripMenuItem.Name = "абитуриентыToolStripMenuItem";
            this.абитуриентыToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.абитуриентыToolStripMenuItem.Text = "Абитуриенты";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // посмотретьСпискиToolStripMenuItem
            // 
            this.посмотретьСпискиToolStripMenuItem.Name = "посмотретьСпискиToolStripMenuItem";
            this.посмотретьСпискиToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.посмотретьСпискиToolStripMenuItem.Text = "Посмотреть списки";
            this.посмотретьСпискиToolStripMenuItem.Click += new System.EventHandler(this.посмотретьСпискиToolStripMenuItem_Click);
            // 
            // показатьПоСпециальностямToolStripMenuItem
            // 
            this.показатьПоСпециальностямToolStripMenuItem.Name = "показатьПоСпециальностямToolStripMenuItem";
            this.показатьПоСпециальностямToolStripMenuItem.Size = new System.Drawing.Size(181, 20);
            this.показатьПоСпециальностямToolStripMenuItem.Text = "Показать по специальностям";
            this.показатьПоСпециальностямToolStripMenuItem.Click += new System.EventHandler(this.показатьПоСпециальностямToolStripMenuItem_Click);
            // 
            // сформироватьСпискиПоступившихToolStripMenuItem
            // 
            this.сформироватьСпискиПоступившихToolStripMenuItem.Name = "сформироватьСпискиПоступившихToolStripMenuItem";
            this.сформироватьСпискиПоступившихToolStripMenuItem.Size = new System.Drawing.Size(222, 20);
            this.сформироватьСпискиПоступившихToolStripMenuItem.Text = "Сформировать списки поступивших";
            this.сформироватьСпискиПоступившихToolStripMenuItem.Click += new System.EventHandler(this.сформироватьСпискиПоступившихToolStripMenuItem_Click);
            // 
            // frmEnrolees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 25);
            this.Controls.Add(this.mnu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mnu;
            this.MaximizeBox = false;
            this.Name = "frmEnrolees";
            this.Text = "Абитуриенты";
            this.mnu.ResumeLayout(false);
            this.mnu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnu;
        private System.Windows.Forms.ToolStripMenuItem абитуриентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem посмотретьСпискиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem показатьПоСпециальностямToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сформироватьСпискиПоступившихToolStripMenuItem;

    }
}

