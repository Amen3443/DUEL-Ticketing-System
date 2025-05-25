namespace DUEL_Ticketing_System
{
    partial class AddShows
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddShows));
            System.Windows.Forms.Label idLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.AddShowTitle = new System.Windows.Forms.TextBox();
            this.SaveShowbutton = new System.Windows.Forms.Button();
            this.PlayradioButton = new System.Windows.Forms.RadioButton();
            this.ConcertradioButton = new System.Windows.Forms.RadioButton();
            this.Closebutton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.showTableAdapter = new DUEL_Ticketing_System.DUEL_DataBaseDataSet1TableAdapters.ShowTableAdapter();
            this.tableAdapterManager = new DUEL_Ticketing_System.DUEL_DataBaseDataSet1TableAdapters.TableAdapterManager();
            this.dUEL_DataBaseDataSet1 = new DUEL_Ticketing_System.DUEL_DataBaseDataSet1();
            this.showBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.showBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.showBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.showDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTextBox = new System.Windows.Forms.TextBox();
            idLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dUEL_DataBaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showBindingNavigator)).BeginInit();
            this.showBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // AddShowTitle
            // 
            this.AddShowTitle.Location = new System.Drawing.Point(136, 78);
            this.AddShowTitle.Name = "AddShowTitle";
            this.AddShowTitle.Size = new System.Drawing.Size(301, 20);
            this.AddShowTitle.TabIndex = 1;
            // 
            // SaveShowbutton
            // 
            this.SaveShowbutton.Location = new System.Drawing.Point(105, 155);
            this.SaveShowbutton.Name = "SaveShowbutton";
            this.SaveShowbutton.Size = new System.Drawing.Size(122, 23);
            this.SaveShowbutton.TabIndex = 2;
            this.SaveShowbutton.Text = "Save Show";
            this.SaveShowbutton.UseVisualStyleBackColor = true;
            this.SaveShowbutton.Click += new System.EventHandler(this.SaveShowbutton_Click);
            // 
            // PlayradioButton
            // 
            this.PlayradioButton.AutoSize = true;
            this.PlayradioButton.Location = new System.Drawing.Point(18, 45);
            this.PlayradioButton.Name = "PlayradioButton";
            this.PlayradioButton.Size = new System.Drawing.Size(45, 17);
            this.PlayradioButton.TabIndex = 3;
            this.PlayradioButton.TabStop = true;
            this.PlayradioButton.Text = "Play";
            this.PlayradioButton.UseVisualStyleBackColor = true;
            // 
            // ConcertradioButton
            // 
            this.ConcertradioButton.AutoSize = true;
            this.ConcertradioButton.Location = new System.Drawing.Point(132, 45);
            this.ConcertradioButton.Name = "ConcertradioButton";
            this.ConcertradioButton.Size = new System.Drawing.Size(62, 17);
            this.ConcertradioButton.TabIndex = 4;
            this.ConcertradioButton.TabStop = true;
            this.ConcertradioButton.Text = "Concert";
            this.ConcertradioButton.UseVisualStyleBackColor = true;
            // 
            // Closebutton
            // 
            this.Closebutton.Location = new System.Drawing.Point(267, 155);
            this.Closebutton.Name = "Closebutton";
            this.Closebutton.Size = new System.Drawing.Size(110, 23);
            this.Closebutton.TabIndex = 5;
            this.Closebutton.Text = "Close";
            this.Closebutton.UseVisualStyleBackColor = true;
            this.Closebutton.Click += new System.EventHandler(this.Closebutton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ConcertradioButton);
            this.groupBox1.Controls.Add(this.PlayradioButton);
            this.groupBox1.Location = new System.Drawing.Point(467, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // showTableAdapter
            // 
            this.showTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PatronTableAdapter = null;
            this.tableAdapterManager.ShowTableAdapter = this.showTableAdapter;
            this.tableAdapterManager.UpdateOrder = DUEL_Ticketing_System.DUEL_DataBaseDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dUEL_DataBaseDataSet1
            // 
            this.dUEL_DataBaseDataSet1.DataSetName = "DUEL_DataBaseDataSet1";
            this.dUEL_DataBaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // showBindingSource
            // 
            this.showBindingSource.DataMember = "Show";
            this.showBindingSource.DataSource = this.dUEL_DataBaseDataSet1;
            // 
            // showBindingNavigator
            // 
            this.showBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.showBindingNavigator.BindingSource = this.showBindingSource;
            this.showBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.showBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.showBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.showBindingNavigatorSaveItem});
            this.showBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.showBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.showBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.showBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.showBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.showBindingNavigator.Name = "showBindingNavigator";
            this.showBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.showBindingNavigator.Size = new System.Drawing.Size(853, 25);
            this.showBindingNavigator.TabIndex = 7;
            this.showBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
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
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
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
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // showBindingNavigatorSaveItem
            // 
            this.showBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.showBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("showBindingNavigatorSaveItem.Image")));
            this.showBindingNavigatorSaveItem.Name = "showBindingNavigatorSaveItem";
            this.showBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.showBindingNavigatorSaveItem.Text = "Save Data";
            this.showBindingNavigatorSaveItem.Click += new System.EventHandler(this.showBindingNavigatorSaveItem_Click);
            // 
            // showDataGridView
            // 
            this.showDataGridView.AutoGenerateColumns = false;
            this.showDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.showDataGridView.DataSource = this.showBindingSource;
            this.showDataGridView.Location = new System.Drawing.Point(31, 209);
            this.showDataGridView.Name = "showDataGridView";
            this.showDataGridView.Size = new System.Drawing.Size(584, 286);
            this.showDataGridView.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ShowTitle";
            this.dataGridViewTextBoxColumn2.HeaderText = "ShowTitle";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ShowType";
            this.dataGridViewTextBoxColumn3.HeaderText = "ShowType";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ShowDateTime";
            this.dataGridViewTextBoxColumn4.HeaderText = "ShowDateTime";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(51, 125);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 7;
            idLabel.Text = "Id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.showBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(76, 122);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 8;
            // 
            // AddShows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 598);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.showDataGridView);
            this.Controls.Add(this.showBindingNavigator);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Closebutton);
            this.Controls.Add(this.SaveShowbutton);
            this.Controls.Add(this.AddShowTitle);
            this.Controls.Add(this.label1);
            this.Name = "AddShows";
            this.Text = "AddShows";
            this.Load += new System.EventHandler(this.AddShows_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dUEL_DataBaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showBindingNavigator)).EndInit();
            this.showBindingNavigator.ResumeLayout(false);
            this.showBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AddShowTitle;
        private System.Windows.Forms.Button SaveShowbutton;
        private System.Windows.Forms.RadioButton PlayradioButton;
        private System.Windows.Forms.RadioButton ConcertradioButton;
        private System.Windows.Forms.Button Closebutton;
        private System.Windows.Forms.GroupBox groupBox1;
        private DUEL_DataBaseDataSet1TableAdapters.ShowTableAdapter showTableAdapter;
        private DUEL_DataBaseDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private DUEL_DataBaseDataSet1 dUEL_DataBaseDataSet1;
        private System.Windows.Forms.BindingSource showBindingSource;
        private System.Windows.Forms.BindingNavigator showBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton showBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView showDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox idTextBox;
    }
}