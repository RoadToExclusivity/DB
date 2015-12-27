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
            this.абитуриентыToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.специальностиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.показатьСписокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.показатьСпециальностиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.сформироватьСписокПоступившихToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnu
            // 
            this.mnu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.абитуриентыToolStripMenuItem1,
            this.специальностиToolStripMenuItem});
            this.mnu.Location = new System.Drawing.Point(0, 0);
            this.mnu.Name = "mnu";
            this.mnu.Size = new System.Drawing.Size(244, 24);
            this.mnu.TabIndex = 0;
            this.mnu.Text = "menuStrip1";
            // 
            // абитуриентыToolStripMenuItem1
            // 
            this.абитуриентыToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem1,
            this.изменитьToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.toolStripSeparator1,
            this.показатьСписокToolStripMenuItem});
            this.абитуриентыToolStripMenuItem1.Name = "абитуриентыToolStripMenuItem1";
            this.абитуриентыToolStripMenuItem1.Size = new System.Drawing.Size(93, 20);
            this.абитуриентыToolStripMenuItem1.Text = "Абитуриенты";
            // 
            // специальностиToolStripMenuItem
            // 
            this.специальностиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.показатьСпециальностиToolStripMenuItem,
            this.toolStripSeparator2,
            this.сформироватьСписокПоступившихToolStripMenuItem});
            this.специальностиToolStripMenuItem.Name = "специальностиToolStripMenuItem";
            this.специальностиToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.специальностиToolStripMenuItem.Text = "Специальности";
            // 
            // добавитьToolStripMenuItem1
            // 
            this.добавитьToolStripMenuItem1.Name = "добавитьToolStripMenuItem1";
            this.добавитьToolStripMenuItem1.Size = new System.Drawing.Size(166, 22);
            this.добавитьToolStripMenuItem1.Text = "Добавить";
            this.добавитьToolStripMenuItem1.Click += new System.EventHandler(this.добавитьToolStripMenuItem1_Click);
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.изменитьToolStripMenuItem.Text = "Изменить";
            this.изменитьToolStripMenuItem.Click += new System.EventHandler(this.изменитьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(163, 6);
            // 
            // показатьСписокToolStripMenuItem
            // 
            this.показатьСписокToolStripMenuItem.Name = "показатьСписокToolStripMenuItem";
            this.показатьСписокToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.показатьСписокToolStripMenuItem.Text = "Показать список";
            this.показатьСписокToolStripMenuItem.Click += new System.EventHandler(this.показатьСписокToolStripMenuItem_Click);
            // 
            // показатьСпециальностиToolStripMenuItem
            // 
            this.показатьСпециальностиToolStripMenuItem.Name = "показатьСпециальностиToolStripMenuItem";
            this.показатьСпециальностиToolStripMenuItem.Size = new System.Drawing.Size(277, 22);
            this.показатьСпециальностиToolStripMenuItem.Text = "Показать специальности";
            this.показатьСпециальностиToolStripMenuItem.Click += new System.EventHandler(this.показатьСпециальностиToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(274, 6);
            // 
            // сформироватьСписокПоступившихToolStripMenuItem
            // 
            this.сформироватьСписокПоступившихToolStripMenuItem.Name = "сформироватьСписокПоступившихToolStripMenuItem";
            this.сформироватьСписокПоступившихToolStripMenuItem.Size = new System.Drawing.Size(277, 22);
            this.сформироватьСписокПоступившихToolStripMenuItem.Text = "Сформировать список поступивших";
            this.сформироватьСписокПоступившихToolStripMenuItem.Click += new System.EventHandler(this.сформироватьСписокПоступившихToolStripMenuItem_Click);
            // 
            // frmEnrolees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 25);
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
        private System.Windows.Forms.ToolStripMenuItem абитуриентыToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem показатьСписокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem специальностиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem показатьСпециальностиToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem сформироватьСписокПоступившихToolStripMenuItem;

    }
}

