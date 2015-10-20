namespace Lab2
{
    partial class frm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm));
            this.grid = new System.Windows.Forms.DataGridView();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.doctorsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nav = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mnu = new System.Windows.Forms.MenuStrip();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.врачиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.больныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.посещенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.показатьДанныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поВрачамToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поПацентамToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lab1DataSet = new Lab2.Lab1DataSet();
            this.tableAdapterManager = new Lab2.Lab1DataSetTableAdapters.TableAdapterManager();
            this.doctorsTableAdapter = new Lab2.Lab1DataSetTableAdapters.DoctorsTableAdapter();
            this.patientsTableAdapter = new Lab2.Lab1DataSetTableAdapters.PatientsTableAdapter();
            this.receptionTableAdapter = new Lab2.Lab1DataSetTableAdapters.ReceptionTableAdapter();
            this.receptionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nav)).BeginInit();
            this.nav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.mnu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lab1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receptionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(64, 44);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(300, 220);
            this.grid.TabIndex = 1;
            this.grid.SelectionChanged += new System.EventHandler(this.grid_SelectionChanged);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // doctorsBindingNavigatorSaveItem
            // 
            this.doctorsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.doctorsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("doctorsBindingNavigatorSaveItem.Image")));
            this.doctorsBindingNavigatorSaveItem.Name = "doctorsBindingNavigatorSaveItem";
            this.doctorsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.doctorsBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.doctorsBindingNavigatorSaveItem.Click += new System.EventHandler(this.doctorsBindingNavigatorSaveItem_Click);
            // 
            // nav
            // 
            this.nav.AddNewItem = this.bindingNavigatorAddNewItem;
            this.nav.BindingSource = this.bindingSource;
            this.nav.CountItem = this.bindingNavigatorCountItem;
            this.nav.DeleteItem = this.bindingNavigatorDeleteItem;
            this.nav.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.nav.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.doctorsBindingNavigatorSaveItem});
            this.nav.Location = new System.Drawing.Point(0, 406);
            this.nav.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.nav.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.nav.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.nav.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.nav.Name = "nav";
            this.nav.PositionItem = this.bindingNavigatorPositionItem;
            this.nav.Size = new System.Drawing.Size(839, 25);
            this.nav.TabIndex = 0;
            this.nav.Text = "bindingNavigator1";
            // 
            // bindingSource
            // 
            this.bindingSource.AllowNew = true;
            // 
            // mnu
            // 
            this.mnu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.показатьДанныеToolStripMenuItem});
            this.mnu.Location = new System.Drawing.Point(0, 0);
            this.mnu.Name = "mnu";
            this.mnu.Size = new System.Drawing.Size(839, 24);
            this.mnu.TabIndex = 2;
            this.mnu.Text = "menuStrip1";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.врачиToolStripMenuItem,
            this.больныеToolStripMenuItem,
            this.посещенияToolStripMenuItem});
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.loadToolStripMenuItem.Text = "Изменить";
            // 
            // врачиToolStripMenuItem
            // 
            this.врачиToolStripMenuItem.Name = "врачиToolStripMenuItem";
            this.врачиToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.врачиToolStripMenuItem.Text = "Врачи";
            this.врачиToolStripMenuItem.Click += new System.EventHandler(this.врачиToolStripMenuItem_Click);
            // 
            // больныеToolStripMenuItem
            // 
            this.больныеToolStripMenuItem.Name = "больныеToolStripMenuItem";
            this.больныеToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.больныеToolStripMenuItem.Text = "Больные";
            this.больныеToolStripMenuItem.Click += new System.EventHandler(this.больныеToolStripMenuItem_Click);
            // 
            // посещенияToolStripMenuItem
            // 
            this.посещенияToolStripMenuItem.Name = "посещенияToolStripMenuItem";
            this.посещенияToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.посещенияToolStripMenuItem.Text = "Посещения";
            this.посещенияToolStripMenuItem.Click += new System.EventHandler(this.посещенияToolStripMenuItem_Click);
            // 
            // показатьДанныеToolStripMenuItem
            // 
            this.показатьДанныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поВрачамToolStripMenuItem,
            this.поПацентамToolStripMenuItem});
            this.показатьДанныеToolStripMenuItem.Name = "показатьДанныеToolStripMenuItem";
            this.показатьДанныеToolStripMenuItem.Size = new System.Drawing.Size(137, 20);
            this.показатьДанныеToolStripMenuItem.Text = "Просмотреть данные";
            // 
            // поВрачамToolStripMenuItem
            // 
            this.поВрачамToolStripMenuItem.Name = "поВрачамToolStripMenuItem";
            this.поВрачамToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.поВрачамToolStripMenuItem.Text = "По врачам";
            this.поВрачамToolStripMenuItem.Click += new System.EventHandler(this.поВрачамToolStripMenuItem_Click);
            // 
            // поПацентамToolStripMenuItem
            // 
            this.поПацентамToolStripMenuItem.Name = "поПацентамToolStripMenuItem";
            this.поПацентамToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.поПацентамToolStripMenuItem.Text = "По пацентам";
            // 
            // lab1DataSet
            // 
            this.lab1DataSet.DataSetName = "Lab1DataSet";
            this.lab1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.DoctorsTableAdapter = null;
            this.tableAdapterManager.PatientsTableAdapter = null;
            this.tableAdapterManager.ReceptionTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Lab2.Lab1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // doctorsTableAdapter
            // 
            this.doctorsTableAdapter.ClearBeforeFill = true;
            // 
            // patientsTableAdapter
            // 
            this.patientsTableAdapter.ClearBeforeFill = true;
            // 
            // receptionTableAdapter
            // 
            this.receptionTableAdapter.ClearBeforeFill = true;
            // 
            // receptionBindingSource
            // 
            this.receptionBindingSource.DataMember = "Reception";
            this.receptionBindingSource.DataSource = this.lab1DataSet;
            // 
            // frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 431);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.nav);
            this.Controls.Add(this.mnu);
            this.MainMenuStrip = this.mnu;
            this.Name = "frm";
            this.Text = "DataBase";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nav)).EndInit();
            this.nav.ResumeLayout(false);
            this.nav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.mnu.ResumeLayout(false);
            this.mnu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lab1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receptionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Lab1DataSet lab1DataSet;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.BindingSource bindingSource;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton doctorsBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingNavigator nav;
        private Lab1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Lab1DataSetTableAdapters.DoctorsTableAdapter doctorsTableAdapter;
        private Lab1DataSetTableAdapters.PatientsTableAdapter patientsTableAdapter;
        private Lab1DataSetTableAdapters.ReceptionTableAdapter receptionTableAdapter;
        private System.Windows.Forms.MenuStrip mnu;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem показатьДанныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поВрачамToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поПацентамToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem врачиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem больныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem посещенияToolStripMenuItem;
        private System.Windows.Forms.BindingSource receptionBindingSource;

    }
}

