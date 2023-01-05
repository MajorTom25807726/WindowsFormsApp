namespace WindowsFormsApp_0105
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rmaxTFlopsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rpeakTFlopsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.segmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.systemIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.performanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.m11105508PerformanceSet = new WindowsFormsApp_0105.M11105508PerformanceSet();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.site_infoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.site_infoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.m11105508SiteSet = new WindowsFormsApp_0105.M11105508SiteSet();
            this.performanceTableAdapter = new WindowsFormsApp_0105.M11105508PerformanceSetTableAdapters.PerformanceTableAdapter();
            this.performanceTableAdapter1 = new WindowsFormsApp_0105.M11105508PerformanceSetTableAdapters.PerformanceTableAdapter();
            this.site_infoTableAdapter = new WindowsFormsApp_0105.M11105508SiteSetTableAdapters.Site_infoTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp_0105.M11105508SiteSetTableAdapters.TableAdapterManager();
            this.search_keyword_ToolStrip = new System.Windows.Forms.ToolStrip();
            this.keywordToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.keywordToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.search_keyword_ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m11105508PerformanceSet)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.site_infoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.site_infoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m11105508SiteSet)).BeginInit();
            this.search_keyword_ToolStrip.SuspendLayout();
            this.fillToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(803, 452);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(795, 426);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Rmax_avg";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rmaxTFlopsDataGridViewTextBoxColumn,
            this.rpeakTFlopsDataGridViewTextBoxColumn,
            this.segmentDataGridViewTextBoxColumn,
            this.systemIDDataGridViewTextBoxColumn,
            this.listDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.performanceBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(7, 7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(788, 423);
            this.dataGridView1.TabIndex = 0;
            // 
            // rmaxTFlopsDataGridViewTextBoxColumn
            // 
            this.rmaxTFlopsDataGridViewTextBoxColumn.DataPropertyName = "Rmax (TFlop/s)";
            this.rmaxTFlopsDataGridViewTextBoxColumn.HeaderText = "Rmax (TFlop/s)";
            this.rmaxTFlopsDataGridViewTextBoxColumn.Name = "rmaxTFlopsDataGridViewTextBoxColumn";
            // 
            // rpeakTFlopsDataGridViewTextBoxColumn
            // 
            this.rpeakTFlopsDataGridViewTextBoxColumn.DataPropertyName = "Rpeak (TFlop/s)";
            this.rpeakTFlopsDataGridViewTextBoxColumn.HeaderText = "Rpeak (TFlop/s)";
            this.rpeakTFlopsDataGridViewTextBoxColumn.Name = "rpeakTFlopsDataGridViewTextBoxColumn";
            // 
            // segmentDataGridViewTextBoxColumn
            // 
            this.segmentDataGridViewTextBoxColumn.DataPropertyName = "Segment";
            this.segmentDataGridViewTextBoxColumn.HeaderText = "Segment";
            this.segmentDataGridViewTextBoxColumn.Name = "segmentDataGridViewTextBoxColumn";
            // 
            // systemIDDataGridViewTextBoxColumn
            // 
            this.systemIDDataGridViewTextBoxColumn.DataPropertyName = "SystemID";
            this.systemIDDataGridViewTextBoxColumn.HeaderText = "SystemID";
            this.systemIDDataGridViewTextBoxColumn.Name = "systemIDDataGridViewTextBoxColumn";
            // 
            // listDataGridViewTextBoxColumn
            // 
            this.listDataGridViewTextBoxColumn.DataPropertyName = "List";
            this.listDataGridViewTextBoxColumn.HeaderText = "List";
            this.listDataGridViewTextBoxColumn.Name = "listDataGridViewTextBoxColumn";
            // 
            // performanceBindingSource
            // 
            this.performanceBindingSource.DataMember = "Performance";
            this.performanceBindingSource.DataSource = this.m11105508PerformanceSet;
            // 
            // m11105508PerformanceSet
            // 
            this.m11105508PerformanceSet.DataSetName = "M11105508PerformanceSet";
            this.m11105508PerformanceSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.fillToolStrip);
            this.tabPage2.Controls.Add(this.search_keyword_ToolStrip);
            this.tabPage2.Controls.Add(this.site_infoDataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(795, 426);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Country_site";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // site_infoDataGridView
            // 
            this.site_infoDataGridView.AutoGenerateColumns = false;
            this.site_infoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.site_infoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.site_infoDataGridView.DataSource = this.site_infoBindingSource;
            this.site_infoDataGridView.Location = new System.Drawing.Point(0, 124);
            this.site_infoDataGridView.Name = "site_infoDataGridView";
            this.site_infoDataGridView.RowTemplate.Height = 24;
            this.site_infoDataGridView.Size = new System.Drawing.Size(795, 302);
            this.site_infoDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "SiteID";
            this.dataGridViewTextBoxColumn1.HeaderText = "SiteID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Site";
            this.dataGridViewTextBoxColumn2.HeaderText = "Site";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Country";
            this.dataGridViewTextBoxColumn3.HeaderText = "Country";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Region";
            this.dataGridViewTextBoxColumn4.HeaderText = "Region";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Continent";
            this.dataGridViewTextBoxColumn5.HeaderText = "Continent";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // site_infoBindingSource
            // 
            this.site_infoBindingSource.DataMember = "Site_info";
            this.site_infoBindingSource.DataSource = this.m11105508SiteSet;
            // 
            // m11105508SiteSet
            // 
            this.m11105508SiteSet.DataSetName = "M11105508SiteSet";
            this.m11105508SiteSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // performanceTableAdapter
            // 
            this.performanceTableAdapter.ClearBeforeFill = true;
            // 
            // performanceTableAdapter1
            // 
            this.performanceTableAdapter1.ClearBeforeFill = true;
            // 
            // site_infoTableAdapter
            // 
            this.site_infoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Site_infoTableAdapter = this.site_infoTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp_0105.M11105508SiteSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // search_keyword_ToolStrip
            // 
            this.search_keyword_ToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.search_keyword_ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.keywordToolStripLabel,
            this.keywordToolStripTextBox,
            this.search_keyword_ToolStripButton});
            this.search_keyword_ToolStrip.Location = new System.Drawing.Point(3, 3);
            this.search_keyword_ToolStrip.Name = "search_keyword_ToolStrip";
            this.search_keyword_ToolStrip.Size = new System.Drawing.Size(255, 25);
            this.search_keyword_ToolStrip.TabIndex = 1;
            this.search_keyword_ToolStrip.Text = "search_keyword_ToolStrip";
            // 
            // keywordToolStripLabel
            // 
            this.keywordToolStripLabel.Name = "keywordToolStripLabel";
            this.keywordToolStripLabel.Size = new System.Drawing.Size(92, 22);
            this.keywordToolStripLabel.Text = "Country Name:";
            // 
            // keywordToolStripTextBox
            // 
            this.keywordToolStripTextBox.Name = "keywordToolStripTextBox";
            this.keywordToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // search_keyword_ToolStripButton
            // 
            this.search_keyword_ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.search_keyword_ToolStripButton.Name = "search_keyword_ToolStripButton";
            this.search_keyword_ToolStripButton.Size = new System.Drawing.Size(49, 22);
            this.search_keyword_ToolStripButton.Text = "Search";
            this.search_keyword_ToolStripButton.Click += new System.EventHandler(this.search_keyword_ToolStripButton_Click_1);
            // 
            // fillToolStrip
            // 
            this.fillToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillToolStripButton});
            this.fillToolStrip.Location = new System.Drawing.Point(258, 3);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(54, 25);
            this.fillToolStrip.TabIndex = 1;
            this.fillToolStrip.Text = "fillToolStrip";
            // 
            // fillToolStripButton
            // 
            this.fillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton.Name = "fillToolStripButton";
            this.fillToolStripButton.Size = new System.Drawing.Size(42, 22);
            this.fillToolStripButton.Text = "Reset";
            this.fillToolStripButton.Click += new System.EventHandler(this.fillToolStripButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 454);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m11105508PerformanceSet)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.site_infoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.site_infoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m11105508SiteSet)).EndInit();
            this.search_keyword_ToolStrip.ResumeLayout(false);
            this.search_keyword_ToolStrip.PerformLayout();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private M11105508PerformanceSet m11105508PerformanceSet;
        private System.Windows.Forms.BindingSource performanceBindingSource;
        private M11105508PerformanceSetTableAdapters.PerformanceTableAdapter performanceTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rmaxTFlopsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rpeakTFlopsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn segmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn systemIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn listDataGridViewTextBoxColumn;
        private M11105508PerformanceSetTableAdapters.PerformanceTableAdapter performanceTableAdapter1;
        private M11105508SiteSet m11105508SiteSet;
        private System.Windows.Forms.BindingSource site_infoBindingSource;
        private M11105508SiteSetTableAdapters.Site_infoTableAdapter site_infoTableAdapter;
        private M11105508SiteSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView site_infoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.ToolStrip search_keyword_ToolStrip;
        private System.Windows.Forms.ToolStripLabel keywordToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox keywordToolStripTextBox;
        private System.Windows.Forms.ToolStripButton search_keyword_ToolStripButton;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
    }
}

