namespace RoverCoffeManage2
{
    partial class UserControl3
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.chartMonth = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cbYearOfMonth = new System.Windows.Forms.ComboBox();
            this.dgvMonth = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnMonthBillSearch = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cbMonth = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonth)).BeginInit();
            this.SuspendLayout();
            // 
            // chartMonth
            // 
            chartArea1.Name = "ChartArea1";
            this.chartMonth.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartMonth.Legends.Add(legend1);
            this.chartMonth.Location = new System.Drawing.Point(432, 122);
            this.chartMonth.Name = "chartMonth";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Đồng";
            this.chartMonth.Series.Add(series1);
            this.chartMonth.Size = new System.Drawing.Size(921, 386);
            this.chartMonth.TabIndex = 9;
            this.chartMonth.Text = "chart1";
            // 
            // cbYearOfMonth
            // 
            this.cbYearOfMonth.FormattingEnabled = true;
            this.cbYearOfMonth.Items.AddRange(new object[] {
            "2017",
            "2018"});
            this.cbYearOfMonth.Location = new System.Drawing.Point(154, 81);
            this.cbYearOfMonth.Name = "cbYearOfMonth";
            this.cbYearOfMonth.Size = new System.Drawing.Size(121, 21);
            this.cbYearOfMonth.TabIndex = 8;
            // 
            // dgvMonth
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvMonth.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMonth.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvMonth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMonth.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("UTM Penumbra", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaShell;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMonth.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMonth.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonth.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column4});
            this.dgvMonth.DoubleBuffered = true;
            this.dgvMonth.EnableHeadersVisualStyles = false;
            this.dgvMonth.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dgvMonth.HeaderForeColor = System.Drawing.Color.SeaShell;
            this.dgvMonth.Location = new System.Drawing.Point(18, 122);
            this.dgvMonth.Name = "dgvMonth";
            this.dgvMonth.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMonth.Size = new System.Drawing.Size(367, 386);
            this.dgvMonth.TabIndex = 7;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Ngày";
            this.Column3.Name = "Column3";
            this.Column3.Visible = false;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Thành tiền";
            this.Column4.Name = "Column4";
            this.Column4.Visible = false;
            // 
            // btnMonthBillSearch
            // 
            this.btnMonthBillSearch.Depth = 0;
            this.btnMonthBillSearch.Icon = null;
            this.btnMonthBillSearch.Location = new System.Drawing.Point(293, 81);
            this.btnMonthBillSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnMonthBillSearch.Name = "btnMonthBillSearch";
            this.btnMonthBillSearch.Primary = true;
            this.btnMonthBillSearch.Size = new System.Drawing.Size(75, 23);
            this.btnMonthBillSearch.TabIndex = 6;
            this.btnMonthBillSearch.Text = "Search";
            this.btnMonthBillSearch.UseVisualStyleBackColor = true;
            this.btnMonthBillSearch.Click += new System.EventHandler(this.btnMonthBillSearch_Click);
            // 
            // cbMonth
            // 
            this.cbMonth.FormattingEnabled = true;
            this.cbMonth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbMonth.Location = new System.Drawing.Point(18, 81);
            this.cbMonth.Name = "cbMonth";
            this.cbMonth.Size = new System.Drawing.Size(121, 21);
            this.cbMonth.TabIndex = 5;
            // 
            // UserControl3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chartMonth);
            this.Controls.Add(this.cbYearOfMonth);
            this.Controls.Add(this.dgvMonth);
            this.Controls.Add(this.btnMonthBillSearch);
            this.Controls.Add(this.cbMonth);
            this.Name = "UserControl3";
            this.Size = new System.Drawing.Size(1500, 1000);
            ((System.ComponentModel.ISupportInitialize)(this.chartMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartMonth;
        private System.Windows.Forms.ComboBox cbYearOfMonth;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private MaterialSkin.Controls.MaterialRaisedButton btnMonthBillSearch;
        private System.Windows.Forms.ComboBox cbMonth;
    }
}
