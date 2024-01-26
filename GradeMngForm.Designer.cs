namespace highellyManage
{
    partial class GradeMngForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1D, 5D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(2D, 3D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(3D, 4D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(4D, 1D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint5 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(5D, 1D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint6 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(6D, 2D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint7 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(7D, 4D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint8 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(8D, 4D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint9 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(9D, 2D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint10 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(10D, 5D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint11 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(11D, 3D);
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint12 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1D, 1D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint13 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(2D, 4D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint14 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(3D, 5D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint15 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(4D, 6D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint16 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(5D, 6D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint17 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(6D, 4D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint18 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(7D, 4D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint19 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(8D, 3D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint20 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(9D, 2D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint21 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(10D, 1D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint22 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(11D, 5D);
            this.txtTestNum = new System.Windows.Forms.TextBox();
            this.btnExcel = new System.Windows.Forms.Button();
            this.chartGrade = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtStuNM = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.listboxStu = new System.Windows.Forms.ListBox();
            this.btnApplyGragh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            this.txtTotalInput = new System.Windows.Forms.TextBox();
            this.btnOneInput = new System.Windows.Forms.Button();
            this.btnInit = new System.Windows.Forms.Button();
            this.btnChartInit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartGrade)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTestNum
            // 
            this.txtTestNum.Location = new System.Drawing.Point(418, 29);
            this.txtTestNum.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtTestNum.Name = "txtTestNum";
            this.txtTestNum.Size = new System.Drawing.Size(33, 21);
            this.txtTestNum.TabIndex = 1;
            this.txtTestNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.isDigit_keypress);
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(831, 682);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(124, 27);
            this.btnExcel.TabIndex = 4;
            this.btnExcel.Text = "엑셀로 내보내기";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // chartGrade
            // 
            chartArea1.Name = "ChartArea1";
            this.chartGrade.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartGrade.Legends.Add(legend1);
            this.chartGrade.Location = new System.Drawing.Point(45, 342);
            this.chartGrade.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.chartGrade.Name = "chartGrade";
            this.chartGrade.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            series1.Legend = "Legend1";
            series1.Name = "듣기";
            dataPoint1.AxisLabel = "";
            dataPoint1.MarkerSize = 2;
            dataPoint2.AxisLabel = "";
            dataPoint2.MarkerSize = 2;
            dataPoint3.AxisLabel = "";
            dataPoint3.MarkerSize = 2;
            dataPoint4.AxisLabel = "";
            dataPoint4.MarkerSize = 2;
            dataPoint5.AxisLabel = "";
            dataPoint5.MarkerSize = 2;
            dataPoint6.AxisLabel = "";
            dataPoint6.MarkerSize = 2;
            dataPoint7.AxisLabel = "";
            dataPoint7.MarkerSize = 2;
            dataPoint8.AxisLabel = "";
            dataPoint8.MarkerSize = 2;
            dataPoint9.AxisLabel = "";
            dataPoint9.MarkerSize = 2;
            dataPoint10.AxisLabel = "";
            dataPoint10.MarkerSize = 2;
            dataPoint11.AxisLabel = "";
            dataPoint11.MarkerSize = 2;
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.Points.Add(dataPoint4);
            series1.Points.Add(dataPoint5);
            series1.Points.Add(dataPoint6);
            series1.Points.Add(dataPoint7);
            series1.Points.Add(dataPoint8);
            series1.Points.Add(dataPoint9);
            series1.Points.Add(dataPoint10);
            series1.Points.Add(dataPoint11);
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "단어";
            series2.Points.Add(dataPoint12);
            series2.Points.Add(dataPoint13);
            series2.Points.Add(dataPoint14);
            series2.Points.Add(dataPoint15);
            series2.Points.Add(dataPoint16);
            series2.Points.Add(dataPoint17);
            series2.Points.Add(dataPoint18);
            series2.Points.Add(dataPoint19);
            series2.Points.Add(dataPoint20);
            series2.Points.Add(dataPoint21);
            series2.Points.Add(dataPoint22);
            this.chartGrade.Series.Add(series1);
            this.chartGrade.Series.Add(series2);
            this.chartGrade.Size = new System.Drawing.Size(910, 308);
            this.chartGrade.TabIndex = 5;
            this.chartGrade.Text = " ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(476, 728);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 14);
            this.label12.TabIndex = 28;
            this.label12.Text = "학생 목록";
            this.label12.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(316, 783);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 14);
            this.label13.TabIndex = 30;
            this.label13.Text = "학생명";
            this.label13.Visible = false;
            // 
            // txtStuNM
            // 
            this.txtStuNM.Location = new System.Drawing.Point(307, 809);
            this.txtStuNM.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtStuNM.Name = "txtStuNM";
            this.txtStuNM.Size = new System.Drawing.Size(75, 21);
            this.txtStuNM.TabIndex = 29;
            this.txtStuNM.Visible = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(307, 849);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(57, 23);
            this.btnAdd.TabIndex = 31;
            this.btnAdd.Text = "추가";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Visible = false;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(370, 849);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(63, 23);
            this.btnDel.TabIndex = 32;
            this.btnDel.Text = "삭제";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Visible = false;
            // 
            // listboxStu
            // 
            this.listboxStu.FormattingEnabled = true;
            this.listboxStu.ItemHeight = 14;
            this.listboxStu.Location = new System.Drawing.Point(449, 745);
            this.listboxStu.Name = "listboxStu";
            this.listboxStu.Size = new System.Drawing.Size(125, 144);
            this.listboxStu.TabIndex = 33;
            this.listboxStu.Visible = false;
            // 
            // btnApplyGragh
            // 
            this.btnApplyGragh.Location = new System.Drawing.Point(195, 160);
            this.btnApplyGragh.Name = "btnApplyGragh";
            this.btnApplyGragh.Size = new System.Drawing.Size(116, 30);
            this.btnApplyGragh.TabIndex = 34;
            this.btnApplyGragh.Text = "그래프에 성적 적용";
            this.btnApplyGragh.UseVisualStyleBackColor = true;
            this.btnApplyGragh.Click += new System.EventHandler(this.btnApplyGragh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(334, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 14);
            this.label1.TabIndex = 35;
            this.label1.Text = "시험횟수 설정";
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(462, 29);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(57, 23);
            this.btnApply.TabIndex = 36;
            this.btnApply.Text = "적용";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // txtTotalInput
            // 
            this.txtTotalInput.Location = new System.Drawing.Point(545, 29);
            this.txtTotalInput.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtTotalInput.Name = "txtTotalInput";
            this.txtTotalInput.Size = new System.Drawing.Size(228, 21);
            this.txtTotalInput.TabIndex = 37;
            this.txtTotalInput.Visible = false;
            this.txtTotalInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.isDigit_keypress);
            // 
            // btnOneInput
            // 
            this.btnOneInput.Location = new System.Drawing.Point(788, 28);
            this.btnOneInput.Name = "btnOneInput";
            this.btnOneInput.Size = new System.Drawing.Size(85, 23);
            this.btnOneInput.TabIndex = 38;
            this.btnOneInput.Text = "한번에 입력";
            this.btnOneInput.UseVisualStyleBackColor = true;
            this.btnOneInput.Visible = false;
            this.btnOneInput.Click += new System.EventHandler(this.btnOneInput_Click);
            // 
            // btnInit
            // 
            this.btnInit.Location = new System.Drawing.Point(545, 682);
            this.btnInit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnInit.Name = "btnInit";
            this.btnInit.Size = new System.Drawing.Size(124, 27);
            this.btnInit.TabIndex = 39;
            this.btnInit.Text = "초기화";
            this.btnInit.UseVisualStyleBackColor = true;
            this.btnInit.Click += new System.EventHandler(this.btnInit_Click);
            // 
            // btnChartInit
            // 
            this.btnChartInit.Location = new System.Drawing.Point(687, 682);
            this.btnChartInit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnChartInit.Name = "btnChartInit";
            this.btnChartInit.Size = new System.Drawing.Size(124, 27);
            this.btnChartInit.TabIndex = 40;
            this.btnChartInit.Text = "그래프 초기화";
            this.btnChartInit.UseVisualStyleBackColor = true;
            this.btnChartInit.Click += new System.EventHandler(this.btnChartInit_Click);
            // 
            // GradeMngForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 745);
            this.Controls.Add(this.btnChartInit);
            this.Controls.Add(this.btnInit);
            this.Controls.Add(this.btnOneInput);
            this.Controls.Add(this.txtTotalInput);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnApplyGragh);
            this.Controls.Add(this.listboxStu);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtStuNM);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.chartGrade);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.txtTestNum);
            this.Font = new System.Drawing.Font("이사만루체 Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "GradeMngForm";
            this.Padding = new System.Windows.Forms.Padding(20, 70, 20, 24);
            this.Text = "학생성적그래프입력";
            ((System.ComponentModel.ISupportInitialize)(this.chartGrade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTestNum;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGrade;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtStuNM;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.ListBox listboxStu;
        private System.Windows.Forms.Button btnApplyGragh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.TextBox txtTotalInput;
        private System.Windows.Forms.Button btnOneInput;
        private System.Windows.Forms.Button btnInit;
        private System.Windows.Forms.Button btnChartInit;
    }
}