namespace RoverCoffeManage2
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.chartQuantityStatistics = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvQuantityStatistics = new System.Windows.Forms.DataGridView();
            this.btnQuantitySearch = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dtpQuantityEnd = new Bunifu.Framework.UI.BunifuDatepicker();
            this.dtpQuantityBegin = new Bunifu.Framework.UI.BunifuDatepicker();
            ((System.ComponentModel.ISupportInitialize)(this.chartQuantityStatistics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuantityStatistics)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Xóa Món";
            this.dataGridViewImageColumn1.Image = global::RoverCoffeManage2.Properties.Resources.del_21;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.Width = 70;
            // 
            // chartQuantityStatistics
            // 
            chartArea1.Name = "ChartArea1";
            this.chartQuantityStatistics.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartQuantityStatistics.Legends.Add(legend1);
            this.chartQuantityStatistics.Location = new System.Drawing.Point(533, 152);
            this.chartQuantityStatistics.Name = "chartQuantityStatistics";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Số lượng";
            this.chartQuantityStatistics.Series.Add(series1);
            this.chartQuantityStatistics.Size = new System.Drawing.Size(552, 476);
            this.chartQuantityStatistics.TabIndex = 9;
            this.chartQuantityStatistics.Text = "chart1";
            // 
            // dgvQuantityStatistics
            // 
            this.dgvQuantityStatistics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuantityStatistics.Location = new System.Drawing.Point(29, 152);
            this.dgvQuantityStatistics.Name = "dgvQuantityStatistics";
            this.dgvQuantityStatistics.Size = new System.Drawing.Size(397, 476);
            this.dgvQuantityStatistics.TabIndex = 8;
            // 
            // btnQuantitySearch
            // 
            this.btnQuantitySearch.Depth = 0;
            this.btnQuantitySearch.Icon = null;
            this.btnQuantitySearch.Location = new System.Drawing.Point(96, 106);
            this.btnQuantitySearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnQuantitySearch.Name = "btnQuantitySearch";
            this.btnQuantitySearch.Primary = true;
            this.btnQuantitySearch.Size = new System.Drawing.Size(209, 23);
            this.btnQuantitySearch.TabIndex = 7;
            this.btnQuantitySearch.Text = "Search";
            this.btnQuantitySearch.UseVisualStyleBackColor = true;
            this.btnQuantitySearch.Click += new System.EventHandler(this.btnQuantitySearch_Click);
            // 
            // dtpQuantityEnd
            // 
            this.dtpQuantityEnd.BackColor = System.Drawing.Color.SeaGreen;
            this.dtpQuantityEnd.BorderRadius = 0;
            this.dtpQuantityEnd.ForeColor = System.Drawing.Color.White;
            this.dtpQuantityEnd.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpQuantityEnd.FormatCustom = null;
            this.dtpQuantityEnd.Location = new System.Drawing.Point(65, 63);
            this.dtpQuantityEnd.Margin = new System.Windows.Forms.Padding(4);
            this.dtpQuantityEnd.Name = "dtpQuantityEnd";
            this.dtpQuantityEnd.Size = new System.Drawing.Size(303, 36);
            this.dtpQuantityEnd.TabIndex = 6;
            this.dtpQuantityEnd.Value = new System.DateTime(2017, 4, 2, 11, 46, 32, 256);
            // 
            // dtpQuantityBegin
            // 
            this.dtpQuantityBegin.BackColor = System.Drawing.Color.SeaGreen;
            this.dtpQuantityBegin.BorderRadius = 0;
            this.dtpQuantityBegin.ForeColor = System.Drawing.Color.White;
            this.dtpQuantityBegin.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpQuantityBegin.FormatCustom = null;
            this.dtpQuantityBegin.Location = new System.Drawing.Point(65, 19);
            this.dtpQuantityBegin.Margin = new System.Windows.Forms.Padding(4);
            this.dtpQuantityBegin.Name = "dtpQuantityBegin";
            this.dtpQuantityBegin.Size = new System.Drawing.Size(303, 36);
            this.dtpQuantityBegin.TabIndex = 5;
            this.dtpQuantityBegin.Value = new System.DateTime(2017, 4, 2, 11, 46, 26, 983);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chartQuantityStatistics);
            this.Controls.Add(this.dgvQuantityStatistics);
            this.Controls.Add(this.btnQuantitySearch);
            this.Controls.Add(this.dtpQuantityEnd);
            this.Controls.Add(this.dtpQuantityBegin);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(1500, 1000);
            ((System.ComponentModel.ISupportInitialize)(this.chartQuantityStatistics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuantityStatistics)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartQuantityStatistics;
        private System.Windows.Forms.DataGridView dgvQuantityStatistics;
        private MaterialSkin.Controls.MaterialRaisedButton btnQuantitySearch;
        private Bunifu.Framework.UI.BunifuDatepicker dtpQuantityEnd;
        private Bunifu.Framework.UI.BunifuDatepicker dtpQuantityBegin;
    }
}
