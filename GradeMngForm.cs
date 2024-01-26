using MetroFramework.Forms;
using OfficeOpenXml;
using OfficeOpenXml.Drawing.Chart;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace highellyManage
{
    public partial class GradeMngForm : MetroForm
    {

        string filePath = @"C:\highEllyResult\" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + "_Excel_Data.xlsx";
        string dirPath = @"C:\highEllyResult";

        string OneInputType = "";

        public GradeMngForm()
        {
            InitializeComponent();

            InitializeChart();
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;


        }
        public string GetMacAddress()
        {
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (nic.NetworkInterfaceType == NetworkInterfaceType.Ethernet &&
                    nic.OperationalStatus == OperationalStatus.Up)
                {
                    return nic.GetPhysicalAddress().ToString();
                }
            }
            return null;
        }
        public string GenerateLicenseKey(string identifier)
        {
            // 예: 식별자의 해시를 라이선스 키로 사용
            using (var sha = new System.Security.Cryptography.SHA256Managed())
            {
                byte[] textData = System.Text.Encoding.UTF8.GetBytes(identifier);
                byte[] hash = sha.ComputeHash(textData);
                return BitConverter.ToString(hash).Replace("-", String.Empty);
            }
        }

        public bool VerifyLicense(string userLicenseKey)
        {
            string deviceIdentifier = GetMacAddress();
            string validLicenseKey = GenerateLicenseKey(deviceIdentifier);

            return userLicenseKey.Equals(validLicenseKey, StringComparison.OrdinalIgnoreCase);
        }


        private void InitializeChart()
        {
            chartGrade.Series.Clear();
            chartGrade.ChartAreas.Add(new ChartArea());

            // Add two series for Listening and word
            Series seriesListening = new Series("Listening")
            {
                ChartType = SeriesChartType.Line,
                Color = Color.Blue // Listening in blue
            };
            Series seriesSpeaking = new Series("word")
            {
                ChartType = SeriesChartType.Line,
                Color = Color.Red // word in red
            };

            chartGrade.Series.Add(seriesListening);
            chartGrade.Series.Add(seriesSpeaking);

            // Set up the X-axis
            chartGrade.ChartAreas[0].AxisX.Interval = 1;
            chartGrade.ChartAreas[0].AxisX.Title = "회차";

            // Set up the Y-axis
            chartGrade.ChartAreas[0].AxisY.Title = "점수";

            // Add points to the series
            chartGrade.Series["Listening"].Points.AddXY(1, 1);
            chartGrade.Series["Listening"].Points.AddXY(2, 2);
            chartGrade.Series["word"].Points.AddXY(1, 2);
            chartGrade.Series["word"].Points.AddXY(2, 4);

        }



        private void btnExcel_Click(object sender, EventArgs e)
        {

            using (ExcelPackage package = new ExcelPackage())
            {


                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Chart");
                var chart = worksheet.Drawings.AddChart("chart", eChartType.Line);

                // Set chart properties and data
                chart.Title.Text = "Listening and word";
                chart.SetPosition(0, 0, 3, 0); // Set the position of the chart
                chart.SetSize(800, 400); // Set the size of the chart

                int NumCnt = 0;
                // 회차 갯수 구하기
                for (int i = 0; this.Controls.ContainsKey($"dynamicTextBox{i + 1}"); i++)
                {
                    NumCnt++;
                }
                //NumCnt /= 2;

                //chart.Series.Add(ExcelRange.GetAddress(1, 2, 3, 2), ExcelRange.GetAddress(1, 1, 3, 1));
                //Y값, X값의 좌표들
                //chart.Series.Add(ExcelRange.GetAddress(1, 2, NumCnt, 2), ExcelRange.GetAddress(1, 1, NumCnt, 1));
                //chart.Series.Add(ExcelRange.GetAddress(NumCnt + 1, 2, NumCnt * 2, 2), ExcelRange.GetAddress(NumCnt + 1, 1, NumCnt*2, 1));


                // Example data for the series
                List<int> seriesAData = new List<int>();
                List<int> seriesBData = new List<int>();

                for (int i = 0; i < NumCnt / 2; i++)
                {
                    worksheet.Cells[$"A{i + 1}"].Value = $"{i + 1}회차";
                    //worksheet.Cells[$"B{i + 1}"].Value = this.Controls[$"dynamicTextBox{i + 1}"].Text;
                    //worksheet.Cells[$"B{i + 1}"].Value = chartGrade.Series["Listening"].Points[i].YValues[0];
                    seriesAData.Add((int)chartGrade.Series["Listening"].Points[i].YValues[0]);
                    seriesBData.Add((int)chartGrade.Series["word"].Points[i].YValues[0]);
                }
                for (int i = 0; i < seriesAData.Count; i++)
                {
                    worksheet.Cells[$"B{i + 1}"].Value = seriesAData[i];
                    worksheet.Cells[$"C{i + 1}"].Value = seriesBData[i];
                    //worksheet.Cells[i + 1, 2].Value = seriesAData[i]; // Series A data in column 1
                    //worksheet.Cells[i + 1, 3].Value = seriesBData[i]; // Series B data in column 2
                }


                var seriesA = chart.Series.Add(worksheet.Cells[1, 2, seriesAData.Count, 2], worksheet.Cells[1, 1, seriesAData.Count, 1]);
                seriesA.Header = "Listening";
                var seriesB = chart.Series.Add(worksheet.Cells[1, 3, seriesBData.Count, 3], worksheet.Cells[1, 1, seriesAData.Count, 1]);
                seriesB.Header = "word";

                //MessageBox.Show(worksheet.Cells.Rows.ToString());

                // Data for the chart
                //worksheet.Cells["A1"].Value = "Category1";
                //worksheet.Cells["A2"].Value = "Category2";
                //worksheet.Cells["A3"].Value = "Category3";
                //worksheet.Cells["B1"].Value = 10;
                //worksheet.Cells["B2"].Value = 20;
                //worksheet.Cells["B3"].Value = 30;

                // Save to file
                FileInfo fileInfo = new FileInfo(filePath);
                DirectoryInfo dir = new DirectoryInfo(dirPath);

                if (!dir.Exists)
                {
                    dir.Create();
                }

                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                }

                package.SaveAs(fileInfo);

                MessageBox.Show("저장 성공\n경로:" + filePath);
            }


        }

        private void isDigit_keypress(object sender, KeyPressEventArgs e)
        {
            //숫자만 입력되도록 필터링             
            if (!(char.IsDigit(e.KeyChar)) && !(e.KeyChar == '\b'))    //숫자와 백스페이스를 제외한 나머지를 바로 처리             
            {
                e.Handled = true;
            }

            if (e.KeyChar == '\r')
            {
                if ((sender as TextBox).Name == "txtTestNum")
                {
                    btnApply_Click(sender, e);
                    txtTotalInput.Focus();
                    txtTotalInput.SelectAll();
                }

                if ((sender as TextBox).Name == "txtTotalInput")
                {

                   
                    btnOneInput_Click(sender, e);
                    btnApplyGragh.Focus();



                }
            }
        }


        //성적 횟수 적용 텍스트 박스 생성
        private void btnApply_Click(object sender, EventArgs e)
        {
            if (txtTestNum.Text.Length == 0)
            {
                MessageBox.Show("횟수를 입력하세요");
                txtTestNum.Focus();
                return;
            }
            else
            {
                if (DialogResult.No == MessageBox.Show("현재 그래프 정보가 손실될 수 있습니다 \n그래도 진행하시겠습니까?", "", MessageBoxButtons.YesNo))
                {
                    return;
                }

                txtTotalInput.Visible = true;
                txtTotalInput.MaxLength = int.Parse(txtTestNum.Text);
                btnOneInput.Visible = true;

            }

            int numberOfTests = int.Parse(txtTestNum.Text); // Assuming numericUpDownTests is your NumericUpDown control

            // Clear existing text boxes
            for (int i = 0; this.Controls.ContainsKey($"dynamicTextBox{i + 1}"); i++)
            {
                this.Controls.RemoveByKey($"dynamicTextBox{i + 1}");
                this.Controls.RemoveByKey($"dynamiclabel{i + 1}");
            }

            // Create new text boxes
            int textBoxSpacing = 25;
            int tempSpacing = 100;
            for (int i = 0; i < numberOfTests * 2; i++)
            {
                Label label = new Label();
                label.Name = $"dynamiclabel{i + 1}";


                TextBox textBox = new TextBox();

                if (i < 10)
                {
                    label.Size = new Size(90, 20); // Adj
                    if (i % 2 == 0)
                    {
                        label.Text = $"Listening {i / 2 + 1}회";
                    }
                    else
                    {
                        label.Text = $"word {i / 2 + 1}회";
                    }

                    label.Location = new Point(label1.Location.X, label1.Location.Y + ((i + 1) * textBoxSpacing)); // Adjust location as needed
                    textBox.Location = new Point(label1.Location.X + tempSpacing, label1.Location.Y + ((i + 1) * textBoxSpacing)); // Adjust location as needed
                }
                else
                {
                    label.Size = new Size(40, 20); // Adj
                    if (i % 2 == 0)
                    {
                        label.Text = $" {i / 2 + 1}회";
                    }
                    else
                    {
                        label.Text = $" {i / 2 + 1}회";
                    }

                    label.Location = new Point(label1.Location.X + ((i / 10) * 100) + 70, label1.Location.Y + ((i - (10 * (i / 10)) + 1) * textBoxSpacing)); // Adjust location as needed
                    textBox.Location = new Point(txtTestNum.Location.X + ((i / 10) * 100) + 40, label1.Location.Y + ((i - (10 * (i / 10)) + 1) * textBoxSpacing)); // Adjust location as needed
                }

                textBox.Name = $"dynamicTextBox{i + 1}";
                textBox.Size = new Size(50, 20); // Adjust size as needed
                textBox.TextAlign = HorizontalAlignment.Right;

                this.Controls.Add(label);
                this.Controls.Add(textBox);
            }


            // Clear existing points
            chartGrade.Series["Listening"].Points.Clear();
            chartGrade.Series["word"].Points.Clear();

        }


        //그래프에 값 적용
        private void btnApplyGragh_Click(object sender, EventArgs e)
        {

            // Add new points from textboxes
            for (int i = 0; i < int.Parse(txtTestNum.Text); i++)
            {
                int listeningScore = 0, speakingScore = 0;
                // Assuming textBoxes are named textBox1, textBox2, etc.
                if (int.TryParse(this.Controls[$"dynamicTextBox{i * 2 + 1}"].Text, out listeningScore) &&
                    int.TryParse(this.Controls[$"dynamicTextBox{i * 2 + 2}"].Text, out speakingScore))
                {
                    // Add points to the series
                    chartGrade.Series["Listening"].Points.AddXY(i + 1, listeningScore);
                    chartGrade.Series["word"].Points.AddXY(i + 1, speakingScore);
                }
                else
                {
                    MessageBox.Show($"케이스 중 {i + 1}번째가 잘못된 입력되었습니다. 숫자 값을 입력하세요.");
                    return;
                }
            }

            btnExcel.Focus();

        }

        private void btnOneInput_Click(object sender, EventArgs e)
        {
            int i = 0;


            MultipleChoiceForm multipleChoiceForm = new MultipleChoiceForm();
            multipleChoiceForm.initYN = "Y";
            multipleChoiceForm.ShowDialog();
            OneInputType = "";


            if (multipleChoiceForm.DialogResult == DialogResult.OK)
            {
                OneInputType = multipleChoiceForm.SelectedOptions[0];
            }


            if (OneInputType == "Listening")
            {
                i = 0;
            }
            else
            {
                i = 1;
            }

            foreach (var item in txtTotalInput.Text)
            {

                this.Controls[$"dynamicTextBox{i + 1}"].Text = item.ToString();
                i += 2;
            }

            //btnExcel.Focus();

        }

        private void btnInit_Click(object sender, EventArgs e)
        {
            txtTestNum.Clear();
            InitializeChart();
            txtTotalInput.Clear();

            // Clear existing text boxes
            for (int i = 0; this.Controls.ContainsKey($"dynamicTextBox{i + 1}"); i++)
            {
                this.Controls.RemoveByKey($"dynamicTextBox{i + 1}");
                this.Controls.RemoveByKey($"dynamiclabel{i + 1}");
            }

            txtTestNum.Focus();

        }

        private void btnChartInit_Click(object sender, EventArgs e)
        {
            InitializeChart();
        }
    }
}
