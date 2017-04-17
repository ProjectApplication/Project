namespace RoverCoffeManage2
{
    partial class StatisticMonth
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.chartMonth = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cbYearOfMonth = new System.Windows.Forms.ComboBox();
            this.dgvMonth = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnMonthBillSearch = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cbMonth = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.lb_totalPriceMonth = new MaterialSkin.Controls.MaterialFlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.chartMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonth)).BeginInit();
            this.panel1.SuspendLayout();
            this.bunifuCards1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartMonth
            // 
            this.chartMonth.BorderlineColor = System.Drawing.Color.Black;
            this.chartMonth.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea2.Name = "ChartArea1";
            this.chartMonth.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartMonth.Legends.Add(legend2);
            this.chartMonth.Location = new System.Drawing.Point(367, 68);
            this.chartMonth.Name = "chartMonth";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Đồng";
            this.chartMonth.Series.Add(series2);
            this.chartMonth.Size = new System.Drawing.Size(412, 377);
            this.chartMonth.TabIndex = 9;
            this.chartMonth.Text = "chart1";
            // 
            // cbYearOfMonth
            // 
            this.cbYearOfMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbYearOfMonth.FormattingEnabled = true;
            this.cbYearOfMonth.Items.AddRange(new object[] {
            "2017",
            "2018"});
            this.cbYearOfMonth.Location = new System.Drawing.Point(109, 42);
            this.cbYearOfMonth.Name = "cbYearOfMonth";
            this.cbYearOfMonth.Size = new System.Drawing.Size(121, 21);
            this.cbYearOfMonth.TabIndex = 8;
            // 
            // dgvMonth
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvMonth.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMonth.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMonth.BackgroundColor = System.Drawing.Color.White;
            this.dgvMonth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMonth.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(75)))), ((int)(((byte)(134)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("UTM Penumbra", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.SeaShell;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMonth.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMonth.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonth.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column4});
            this.dgvMonth.DoubleBuffered = true;
            this.dgvMonth.EnableHeadersVisualStyles = false;
            this.dgvMonth.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(75)))), ((int)(((byte)(134)))));
            this.dgvMonth.HeaderForeColor = System.Drawing.Color.SeaShell;
            this.dgvMonth.Location = new System.Drawing.Point(-30, 73);
            this.dgvMonth.Name = "dgvMonth";
            this.dgvMonth.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMonth.Size = new System.Drawing.Size(354, 246);
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
            this.btnMonthBillSearch.Location = new System.Drawing.Point(3, 335);
            this.btnMonthBillSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnMonthBillSearch.Name = "btnMonthBillSearch";
            this.btnMonthBillSearch.Primary = true;
            this.btnMonthBillSearch.Size = new System.Drawing.Size(66, 36);
            this.btnMonthBillSearch.TabIndex = 6;
            this.btnMonthBillSearch.Text = "Search";
            this.btnMonthBillSearch.UseVisualStyleBackColor = true;
            this.btnMonthBillSearch.Click += new System.EventHandler(this.btnMonthBillSearch_Click);
            // 
            // cbMonth
            // 
            this.cbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.cbMonth.Location = new System.Drawing.Point(109, 11);
            this.cbMonth.Name = "cbMonth";
            this.cbMonth.Size = new System.Drawing.Size(121, 21);
            this.cbMonth.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1500, 44);
            this.panel1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(386, 3);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(335, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thống Kê Theo Tháng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Tomato;
            this.bunifuCards1.Controls.Add(this.lb_totalPriceMonth);
            this.bunifuCards1.Controls.Add(this.label2);
            this.bunifuCards1.Controls.Add(this.materialLabel2);
            this.bunifuCards1.Controls.Add(this.materialLabel1);
            this.bunifuCards1.Controls.Add(this.cbYearOfMonth);
            this.bunifuCards1.Controls.Add(this.btnMonthBillSearch);
            this.bunifuCards1.Controls.Add(this.dgvMonth);
            this.bunifuCards1.Controls.Add(this.cbMonth);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(13, 68);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(348, 377);
            this.bunifuCards1.TabIndex = 14;
            // 
            // lb_totalPriceMonth
            // 
            this.lb_totalPriceMonth.AutoSize = true;
            this.lb_totalPriceMonth.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.lb_totalPriceMonth.Depth = 0;
            this.lb_totalPriceMonth.Icon = null;
            this.lb_totalPriceMonth.Location = new System.Drawing.Point(230, 341);
            this.lb_totalPriceMonth.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.lb_totalPriceMonth.MouseState = MaterialSkin.MouseState.HOVER;
            this.lb_totalPriceMonth.Name = "lb_totalPriceMonth";
            this.lb_totalPriceMonth.Primary = false;
            this.lb_totalPriceMonth.Size = new System.Drawing.Size(29, 36);
            this.lb_totalPriceMonth.TabIndex = 13;
            this.lb_totalPriceMonth.Text = "0";
            this.lb_totalPriceMonth.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tổng Doanh Thu :";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(10, 41);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(85, 19);
            this.materialLabel2.TabIndex = 11;
            this.materialLabel2.Text = "Chọn năm :";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(10, 11);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(93, 19);
            this.materialLabel1.TabIndex = 10;
            this.materialLabel1.Text = "Chọn tháng :";
            // 
            // StatisticMonth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuCards1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chartMonth);
            this.Name = "StatisticMonth";
            this.Size = new System.Drawing.Size(1500, 1000);
            ((System.ComponentModel.ISupportInitialize)(this.chartMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonth)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialFlatButton lb_totalPriceMonth;
    }
}
