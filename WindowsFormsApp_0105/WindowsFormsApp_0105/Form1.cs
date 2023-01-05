using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_0105
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'm11105508DataSet.List_info' 資料表。您可以視需要進行移動或移除。
            this.list_infoTableAdapter.Fill(this.m11105508DataSet.List_info);
            // TODO: 這行程式碼會將資料載入 'm11105508Computer_infoSet.Computer_info' 資料表。您可以視需要進行移動或移除。
            this.computer_infoTableAdapter.Fill(this.m11105508Computer_infoSet.Computer_info);
            // TODO: 這行程式碼會將資料載入 'm11105508Computer_infoSet.Computer_info' 資料表。您可以視需要進行移動或移除。
            this.computer_infoTableAdapter.Fill(this.m11105508Computer_infoSet.Computer_info);
            // TODO: 這行程式碼會將資料載入 'm11105508SiteSet.Site_info' 資料表。您可以視需要進行移動或移除。
            this.site_infoTableAdapter.Fill(this.m11105508SiteSet.Site_info);
            // TODO: 這行程式碼會將資料載入 'm11105508PerformanceSet.Performance' 資料表。您可以視需要進行移動或移除。
            this.performanceTableAdapter.Fill(this.m11105508PerformanceSet.Performance);

        }

        private void search_keyword_ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.site_infoTableAdapter.Search_keyword_(this.m11105508SiteSet.Site_info, keywordToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void search_keyword_ToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.site_infoTableAdapter.Search_keyword_(this.m11105508SiteSet.Site_info, keywordToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.site_infoTableAdapter.Fill(this.m11105508SiteSet.Site_info);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void search_keyword_ToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.computer_infoTableAdapter.Search_keyword_(this.m11105508Computer_infoSet.Computer_info, listToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void search_keyword_ToolStripButton1_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.computer_infoTableAdapter.Search_keyword_(this.m11105508Computer_infoSet.Computer_info, listToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.computer_infoTableAdapter.Fill(this.m11105508Computer_infoSet.Computer_info);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void search_keyword_ToolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                this.list_infoTableAdapter.Search_keyword_(this.m11105508DataSet.List_info, ((double)(System.Convert.ChangeType(listToolStripTextBox.Text, typeof(double)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void search_keyword_ToolStripButton2_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.list_infoTableAdapter.Search_keyword_(this.m11105508DataSet.List_info, ((double)(System.Convert.ChangeType(listToolStripTextBox.Text, typeof(double)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void desc_listToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.computer_info1TableAdapter.desc_list(this.m11105508Computer_infoSet.Computer_info1, ((double)(System.Convert.ChangeType(listToolStripTextBox.Text, typeof(double)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void desc_listToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.computer_info1TableAdapter.desc_list(this.m11105508Computer_infoSet.Computer_info1, ((double)(System.Convert.ChangeType(listToolStripTextBox.Text, typeof(double)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
