namespace POE_Pricing
{
    partial class InvestForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            dataGridViewInvest = new DataGridView();
            panelInvestMain = new Panel();
            panelDataGrid = new Panel();
            panelSearch = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInvest).BeginInit();
            panelInvestMain.SuspendLayout();
            panelDataGrid.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewInvest
            // 
            dataGridViewInvest.AllowUserToAddRows = false;
            dataGridViewInvest.AllowUserToDeleteRows = false;
            dataGridViewInvest.AllowUserToOrderColumns = true;
            dataGridViewInvest.AllowUserToResizeRows = false;
            dataGridViewInvest.BackgroundColor = Color.Black;
            dataGridViewInvest.BorderStyle = BorderStyle.None;
            dataGridViewInvest.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewInvest.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Red;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.LightGray;
            dataGridViewCellStyle1.SelectionBackColor = Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = Color.LightGray;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewInvest.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewInvest.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Red;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.LightGray;
            dataGridViewCellStyle2.SelectionBackColor = Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = Color.LightGray;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewInvest.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewInvest.Dock = DockStyle.Fill;
            dataGridViewInvest.GridColor = Color.FromArgb(150, 0, 0);
            dataGridViewInvest.Location = new Point(5, 5);
            dataGridViewInvest.Margin = new Padding(20);
            dataGridViewInvest.Name = "dataGridViewInvest";
            dataGridViewInvest.ReadOnly = true;
            dataGridViewInvest.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Red;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.LightGray;
            dataGridViewCellStyle3.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle3.SelectionForeColor = Color.Transparent;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewInvest.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(150, 0, 0);
            dataGridViewCellStyle4.ForeColor = Color.LightGray;
            dataGridViewCellStyle4.SelectionBackColor = Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = Color.LightGray;
            dataGridViewInvest.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewInvest.RowTemplate.Height = 22;
            dataGridViewInvest.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewInvest.Size = new Size(1395, 767);
            dataGridViewInvest.TabIndex = 0;
            // 
            // panelInvestMain
            // 
            panelInvestMain.Controls.Add(panelDataGrid);
            panelInvestMain.Controls.Add(panelSearch);
            panelInvestMain.Dock = DockStyle.Fill;
            panelInvestMain.Location = new Point(0, 0);
            panelInvestMain.Name = "panelInvestMain";
            panelInvestMain.Size = new Size(1405, 877);
            panelInvestMain.TabIndex = 1;
            // 
            // panelDataGrid
            // 
            panelDataGrid.BackColor = Color.Black;
            panelDataGrid.Controls.Add(dataGridViewInvest);
            panelDataGrid.Dock = DockStyle.Fill;
            panelDataGrid.Location = new Point(0, 100);
            panelDataGrid.Name = "panelDataGrid";
            panelDataGrid.Padding = new Padding(5);
            panelDataGrid.Size = new Size(1405, 777);
            panelDataGrid.TabIndex = 2;
            // 
            // panelSearch
            // 
            panelSearch.Dock = DockStyle.Top;
            panelSearch.Location = new Point(0, 0);
            panelSearch.Name = "panelSearch";
            panelSearch.Size = new Size(1405, 100);
            panelSearch.TabIndex = 1;
            // 
            // InvestForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1405, 877);
            Controls.Add(panelInvestMain);
            FormBorderStyle = FormBorderStyle.None;
            Name = "InvestForm";
            Text = "HarvestMemoryForm";
            Load += InvestForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewInvest).EndInit();
            panelInvestMain.ResumeLayout(false);
            panelDataGrid.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewInvest;
        private Panel panelInvestMain;
        private Panel panelDataGrid;
        private Panel panelSearch;
    }
}