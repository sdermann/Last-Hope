namespace LastHope.DealingWithTables
{
    partial class EditPsycho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditPsycho));
            System.Windows.Forms.Label iD_ПсихологаLabel;
            System.Windows.Forms.Label прізвищеLabel;
            System.Windows.Forms.Label ім_яLabel;
            System.Windows.Forms.Label по_батьковіLabel;
            System.Windows.Forms.Label дата_народженняLabel;
            System.Windows.Forms.Label статьLabel;
            System.Windows.Forms.Label телефонLabel;
            System.Windows.Forms.Label поштаLabel;
            System.Windows.Forms.Label роки_кваліфікаціїLabel;
            System.Windows.Forms.Label лікарська_ступіньLabel;
            this.mydbDataSet = new LastHope.mydbDataSet();
            this.психологиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.психологиTableAdapter = new LastHope.mydbDataSetTableAdapters.психологиTableAdapter();
            this.tableAdapterManager = new LastHope.mydbDataSetTableAdapters.TableAdapterManager();
            this.психологиBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.психологиBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iD_ПсихологаTextBox = new System.Windows.Forms.TextBox();
            this.прізвищеTextBox = new System.Windows.Forms.TextBox();
            this.ім_яTextBox = new System.Windows.Forms.TextBox();
            this.по_батьковіTextBox = new System.Windows.Forms.TextBox();
            this.дата_народженняDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.статьTextBox = new System.Windows.Forms.TextBox();
            this.телефонTextBox = new System.Windows.Forms.TextBox();
            this.поштаTextBox = new System.Windows.Forms.TextBox();
            this.роки_кваліфікаціїTextBox = new System.Windows.Forms.TextBox();
            this.лікарська_ступіньTextBox = new System.Windows.Forms.TextBox();
            this.сесіїBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сесіїTableAdapter = new LastHope.mydbDataSetTableAdapters.сесіїTableAdapter();
            this.сесіїDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            iD_ПсихологаLabel = new System.Windows.Forms.Label();
            прізвищеLabel = new System.Windows.Forms.Label();
            ім_яLabel = new System.Windows.Forms.Label();
            по_батьковіLabel = new System.Windows.Forms.Label();
            дата_народженняLabel = new System.Windows.Forms.Label();
            статьLabel = new System.Windows.Forms.Label();
            телефонLabel = new System.Windows.Forms.Label();
            поштаLabel = new System.Windows.Forms.Label();
            роки_кваліфікаціїLabel = new System.Windows.Forms.Label();
            лікарська_ступіньLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mydbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.психологиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.психологиBindingNavigator)).BeginInit();
            this.психологиBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.сесіїBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сесіїDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mydbDataSet
            // 
            this.mydbDataSet.DataSetName = "mydbDataSet";
            this.mydbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // психологиBindingSource
            // 
            this.психологиBindingSource.DataMember = "психологи";
            this.психологиBindingSource.DataSource = this.mydbDataSet;
            // 
            // психологиTableAdapter
            // 
            this.психологиTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = LastHope.mydbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.динаміки_лікуванняTableAdapter = null;
            this.tableAdapterManager.клієнтиTableAdapter = null;
            this.tableAdapterManager.поставлені_діагнозиTableAdapter = null;
            this.tableAdapterManager.психологиTableAdapter = this.психологиTableAdapter;
            this.tableAdapterManager.розклади_психологаTableAdapter = null;
            this.tableAdapterManager.сесіїTableAdapter = this.сесіїTableAdapter;
            this.tableAdapterManager.хворобиTableAdapter = null;
            // 
            // психологиBindingNavigator
            // 
            this.психологиBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.психологиBindingNavigator.BindingSource = this.психологиBindingSource;
            this.психологиBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.психологиBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.психологиBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.психологиBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.психологиBindingNavigatorSaveItem});
            this.психологиBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.психологиBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.психологиBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.психологиBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.психологиBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.психологиBindingNavigator.Name = "психологиBindingNavigator";
            this.психологиBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.психологиBindingNavigator.Size = new System.Drawing.Size(810, 27);
            this.психологиBindingNavigator.TabIndex = 0;
            this.психологиBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 20);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // психологиBindingNavigatorSaveItem
            // 
            this.психологиBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.психологиBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("психологиBindingNavigatorSaveItem.Image")));
            this.психологиBindingNavigatorSaveItem.Name = "психологиBindingNavigatorSaveItem";
            this.психологиBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.психологиBindingNavigatorSaveItem.Text = "Save Data";
            this.психологиBindingNavigatorSaveItem.Click += new System.EventHandler(this.психологиBindingNavigatorSaveItem_Click_1);
            // 
            // iD_ПсихологаLabel
            // 
            iD_ПсихологаLabel.AutoSize = true;
            iD_ПсихологаLabel.Location = new System.Drawing.Point(453, 114);
            iD_ПсихологаLabel.Name = "iD_ПсихологаLabel";
            iD_ПсихологаLabel.Size = new System.Drawing.Size(97, 17);
            iD_ПсихологаLabel.TabIndex = 1;
            iD_ПсихологаLabel.Text = "ID Психолога:";
            // 
            // iD_ПсихологаTextBox
            // 
            this.iD_ПсихологаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.психологиBindingSource, "ID_Психолога", true));
            this.iD_ПсихологаTextBox.Location = new System.Drawing.Point(590, 111);
            this.iD_ПсихологаTextBox.Name = "iD_ПсихологаTextBox";
            this.iD_ПсихологаTextBox.Size = new System.Drawing.Size(200, 22);
            this.iD_ПсихологаTextBox.TabIndex = 2;
            // 
            // прізвищеLabel
            // 
            прізвищеLabel.AutoSize = true;
            прізвищеLabel.Location = new System.Drawing.Point(453, 142);
            прізвищеLabel.Name = "прізвищеLabel";
            прізвищеLabel.Size = new System.Drawing.Size(74, 17);
            прізвищеLabel.TabIndex = 3;
            прізвищеLabel.Text = "Прізвище:";
            // 
            // прізвищеTextBox
            // 
            this.прізвищеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.психологиBindingSource, "Прізвище", true));
            this.прізвищеTextBox.Location = new System.Drawing.Point(590, 139);
            this.прізвищеTextBox.Name = "прізвищеTextBox";
            this.прізвищеTextBox.Size = new System.Drawing.Size(200, 22);
            this.прізвищеTextBox.TabIndex = 4;
            // 
            // ім_яLabel
            // 
            ім_яLabel.AutoSize = true;
            ім_яLabel.Location = new System.Drawing.Point(453, 170);
            ім_яLabel.Name = "ім_яLabel";
            ім_яLabel.Size = new System.Drawing.Size(36, 17);
            ім_яLabel.TabIndex = 5;
            ім_яLabel.Text = "Ім я:";
            // 
            // ім_яTextBox
            // 
            this.ім_яTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.психологиBindingSource, "Ім_я", true));
            this.ім_яTextBox.Location = new System.Drawing.Point(590, 167);
            this.ім_яTextBox.Name = "ім_яTextBox";
            this.ім_яTextBox.Size = new System.Drawing.Size(200, 22);
            this.ім_яTextBox.TabIndex = 6;
            // 
            // по_батьковіLabel
            // 
            по_батьковіLabel.AutoSize = true;
            по_батьковіLabel.Location = new System.Drawing.Point(453, 198);
            по_батьковіLabel.Name = "по_батьковіLabel";
            по_батьковіLabel.Size = new System.Drawing.Size(89, 17);
            по_батьковіLabel.TabIndex = 7;
            по_батьковіLabel.Text = "По батькові:";
            // 
            // по_батьковіTextBox
            // 
            this.по_батьковіTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.психологиBindingSource, "По_батькові", true));
            this.по_батьковіTextBox.Location = new System.Drawing.Point(590, 195);
            this.по_батьковіTextBox.Name = "по_батьковіTextBox";
            this.по_батьковіTextBox.Size = new System.Drawing.Size(200, 22);
            this.по_батьковіTextBox.TabIndex = 8;
            // 
            // дата_народженняLabel
            // 
            дата_народженняLabel.AutoSize = true;
            дата_народженняLabel.Location = new System.Drawing.Point(453, 227);
            дата_народженняLabel.Name = "дата_народженняLabel";
            дата_народженняLabel.Size = new System.Drawing.Size(131, 17);
            дата_народженняLabel.TabIndex = 9;
            дата_народженняLabel.Text = "Дата народження:";
            // 
            // дата_народженняDateTimePicker
            // 
            this.дата_народженняDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.психологиBindingSource, "Дата_народження", true));
            this.дата_народженняDateTimePicker.Location = new System.Drawing.Point(590, 223);
            this.дата_народженняDateTimePicker.Name = "дата_народженняDateTimePicker";
            this.дата_народженняDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.дата_народженняDateTimePicker.TabIndex = 10;
            // 
            // статьLabel
            // 
            статьLabel.AutoSize = true;
            статьLabel.Location = new System.Drawing.Point(453, 254);
            статьLabel.Name = "статьLabel";
            статьLabel.Size = new System.Drawing.Size(50, 17);
            статьLabel.TabIndex = 11;
            статьLabel.Text = "Стать:";
            // 
            // статьTextBox
            // 
            this.статьTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.психологиBindingSource, "Стать", true));
            this.статьTextBox.Location = new System.Drawing.Point(590, 251);
            this.статьTextBox.Name = "статьTextBox";
            this.статьTextBox.Size = new System.Drawing.Size(200, 22);
            this.статьTextBox.TabIndex = 12;
            // 
            // телефонLabel
            // 
            телефонLabel.AutoSize = true;
            телефонLabel.Location = new System.Drawing.Point(453, 282);
            телефонLabel.Name = "телефонLabel";
            телефонLabel.Size = new System.Drawing.Size(72, 17);
            телефонLabel.TabIndex = 13;
            телефонLabel.Text = "Телефон:";
            // 
            // телефонTextBox
            // 
            this.телефонTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.психологиBindingSource, "Телефон", true));
            this.телефонTextBox.Location = new System.Drawing.Point(590, 279);
            this.телефонTextBox.Name = "телефонTextBox";
            this.телефонTextBox.Size = new System.Drawing.Size(200, 22);
            this.телефонTextBox.TabIndex = 14;
            // 
            // поштаLabel
            // 
            поштаLabel.AutoSize = true;
            поштаLabel.Location = new System.Drawing.Point(453, 310);
            поштаLabel.Name = "поштаLabel";
            поштаLabel.Size = new System.Drawing.Size(56, 17);
            поштаLabel.TabIndex = 15;
            поштаLabel.Text = "Пошта:";
            // 
            // поштаTextBox
            // 
            this.поштаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.психологиBindingSource, "Пошта", true));
            this.поштаTextBox.Location = new System.Drawing.Point(590, 307);
            this.поштаTextBox.Name = "поштаTextBox";
            this.поштаTextBox.Size = new System.Drawing.Size(200, 22);
            this.поштаTextBox.TabIndex = 16;
            // 
            // роки_кваліфікаціїLabel
            // 
            роки_кваліфікаціїLabel.AutoSize = true;
            роки_кваліфікаціїLabel.Location = new System.Drawing.Point(453, 338);
            роки_кваліфікаціїLabel.Name = "роки_кваліфікаціїLabel";
            роки_кваліфікаціїLabel.Size = new System.Drawing.Size(124, 17);
            роки_кваліфікаціїLabel.TabIndex = 17;
            роки_кваліфікаціїLabel.Text = "Роки кваліфікації:";
            // 
            // роки_кваліфікаціїTextBox
            // 
            this.роки_кваліфікаціїTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.психологиBindingSource, "Роки_кваліфікації", true));
            this.роки_кваліфікаціїTextBox.Location = new System.Drawing.Point(590, 335);
            this.роки_кваліфікаціїTextBox.Name = "роки_кваліфікаціїTextBox";
            this.роки_кваліфікаціїTextBox.Size = new System.Drawing.Size(200, 22);
            this.роки_кваліфікаціїTextBox.TabIndex = 18;
            // 
            // лікарська_ступіньLabel
            // 
            лікарська_ступіньLabel.AutoSize = true;
            лікарська_ступіньLabel.Location = new System.Drawing.Point(453, 366);
            лікарська_ступіньLabel.Name = "лікарська_ступіньLabel";
            лікарська_ступіньLabel.Size = new System.Drawing.Size(128, 17);
            лікарська_ступіньLabel.TabIndex = 19;
            лікарська_ступіньLabel.Text = "Лікарська ступінь:";
            // 
            // лікарська_ступіньTextBox
            // 
            this.лікарська_ступіньTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.психологиBindingSource, "Лікарська_ступінь", true));
            this.лікарська_ступіньTextBox.Location = new System.Drawing.Point(590, 363);
            this.лікарська_ступіньTextBox.Name = "лікарська_ступіньTextBox";
            this.лікарська_ступіньTextBox.Size = new System.Drawing.Size(200, 22);
            this.лікарська_ступіньTextBox.TabIndex = 20;
            // 
            // сесіїBindingSource
            // 
            this.сесіїBindingSource.DataMember = "fk_Сесії_Психологи1";
            this.сесіїBindingSource.DataSource = this.психологиBindingSource;
            // 
            // сесіїTableAdapter
            // 
            this.сесіїTableAdapter.ClearBeforeFill = true;
            // 
            // сесіїDataGridView
            // 
            this.сесіїDataGridView.AutoGenerateColumns = false;
            this.сесіїDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.сесіїDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.сесіїDataGridView.DataSource = this.сесіїBindingSource;
            this.сесіїDataGridView.Location = new System.Drawing.Point(330, 383);
            this.сесіїDataGridView.Name = "сесіїDataGridView";
            this.сесіїDataGridView.RowHeadersWidth = 51;
            this.сесіїDataGridView.RowTemplate.Height = 24;
            this.сесіїDataGridView.Size = new System.Drawing.Size(300, 220);
            this.сесіїDataGridView.TabIndex = 21;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_Сесії";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id_Сесії";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ID_Психолога2";
            this.dataGridViewTextBoxColumn2.HeaderText = "ID_Психолога2";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ID_Клієнта2";
            this.dataGridViewTextBoxColumn3.HeaderText = "ID_Клієнта2";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Дата";
            this.dataGridViewTextBoxColumn4.HeaderText = "Дата";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Початок_сесії";
            this.dataGridViewTextBoxColumn5.HeaderText = "Початок_сесії";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Кінець_сесії";
            this.dataGridViewTextBoxColumn6.HeaderText = "Кінець_сесії";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Результат";
            this.dataGridViewTextBoxColumn7.HeaderText = "Результат";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // EditPsycho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 623);
            this.Controls.Add(this.сесіїDataGridView);
            this.Controls.Add(iD_ПсихологаLabel);
            this.Controls.Add(this.iD_ПсихологаTextBox);
            this.Controls.Add(прізвищеLabel);
            this.Controls.Add(this.прізвищеTextBox);
            this.Controls.Add(ім_яLabel);
            this.Controls.Add(this.ім_яTextBox);
            this.Controls.Add(по_батьковіLabel);
            this.Controls.Add(this.по_батьковіTextBox);
            this.Controls.Add(дата_народженняLabel);
            this.Controls.Add(this.дата_народженняDateTimePicker);
            this.Controls.Add(статьLabel);
            this.Controls.Add(this.статьTextBox);
            this.Controls.Add(телефонLabel);
            this.Controls.Add(this.телефонTextBox);
            this.Controls.Add(поштаLabel);
            this.Controls.Add(this.поштаTextBox);
            this.Controls.Add(роки_кваліфікаціїLabel);
            this.Controls.Add(this.роки_кваліфікаціїTextBox);
            this.Controls.Add(лікарська_ступіньLabel);
            this.Controls.Add(this.лікарська_ступіньTextBox);
            this.Controls.Add(this.психологиBindingNavigator);
            this.Name = "EditPsycho";
            this.Text = "EditPsycho";
            this.Load += new System.EventHandler(this.EditPsycho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mydbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.психологиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.психологиBindingNavigator)).EndInit();
            this.психологиBindingNavigator.ResumeLayout(false);
            this.психологиBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.сесіїBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сесіїDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private mydbDataSet mydbDataSet;
        private System.Windows.Forms.BindingSource психологиBindingSource;
        private mydbDataSetTableAdapters.психологиTableAdapter психологиTableAdapter;
        private mydbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator психологиBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton психологиBindingNavigatorSaveItem;
        private mydbDataSetTableAdapters.сесіїTableAdapter сесіїTableAdapter;
        private System.Windows.Forms.TextBox iD_ПсихологаTextBox;
        private System.Windows.Forms.TextBox прізвищеTextBox;
        private System.Windows.Forms.TextBox ім_яTextBox;
        private System.Windows.Forms.TextBox по_батьковіTextBox;
        private System.Windows.Forms.DateTimePicker дата_народженняDateTimePicker;
        private System.Windows.Forms.TextBox статьTextBox;
        private System.Windows.Forms.TextBox телефонTextBox;
        private System.Windows.Forms.TextBox поштаTextBox;
        private System.Windows.Forms.TextBox роки_кваліфікаціїTextBox;
        private System.Windows.Forms.TextBox лікарська_ступіньTextBox;
        private System.Windows.Forms.BindingSource сесіїBindingSource;
        private System.Windows.Forms.DataGridView сесіїDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}