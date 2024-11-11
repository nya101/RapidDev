using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WinFormsAssignmentTwoApp2
{
    public partial class Form1 : Form
    {
        private TextBox dataInputTextBox;
        private Button generateButton;
        private Chart barChart;

        public Form1()
        {
            InitializeComponent(); // Call method from Form1.Designer.cs
            SetupForm();
        }

        private void SetupForm()

        {

            Panel textBoxPanel = new Panel
            {
                Location = new Point(100, 90),
                Size = new Size(325, 30),
                BackColor = Color.Green,
                BorderStyle = BorderStyle.FixedSingle
            };



            dataInputTextBox = new TextBox
            {
                Width = 300,
                Location = new Point(5, 3), // padding
                BorderStyle = BorderStyle.None,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                BackColor = Color.LightGray,
                PlaceholderText = "Enter comma-separated integer values"
            };


            ///user input
            textBoxPanel.Controls.Add(dataInputTextBox);
            this.Controls.Add(textBoxPanel);

            {
                
                generateButton = new Button { Text = "Generate Bar Chart", Location = new Point(450, 30) };
                barChart = new Chart { Dock = DockStyle.Bottom, Height = 400 };

                // Add controls to form
                this.Controls.Add(generateButton);
                this.Controls.Add(barChart);


                //  event handler for  generate button
                generateButton.Click += GenerateBarChart;
            }
        }

        private void GenerateBarChart(object sender, EventArgs e)
        {
            // Clear any existing series  data points in the chart
            barChart.Series.Clear();
            barChart.ChartAreas.Clear();

            // Read and parse user input for data
            int[] numbers;
            try
            {
                numbers = dataInputTextBox.Text.Split(',').Select(int.Parse).ToArray();
            }
            catch
            {
                MessageBox.Show(" enter a  list of integer values separated by commas.");
                return;
            }

            //  chart area and series
            ChartArea chartArea = new ChartArea("MainArea");
            barChart.ChartAreas.Add(chartArea);

            Series series = new Series
            {
                Name = "BarSeries",
                ChartType = SeriesChartType.Bar, // horizontal bars
                IsValueShownAsLabel = true // Show values on each bar
            };

            // Bar WIDTH for spacing
            series["PointWidth"] = "0.5";

            //  array of distinct colors
            Color[] colors = { Color.Red, Color.Orange, Color.Yellow, Color.Green, Color.Blue, Color.Purple, Color.Brown, Color.Black };

            //   add data points to series
            for (int i = 0; i < numbers.Length; i++)
            {
                DataPoint dataPoint = new DataPoint
                {
                    YValues = new double[] { numbers[i] },
                    AxisLabel = " Data  " + (i + 1),
                    Color = colors[i % colors.Length]
                };

                series.Points.Add(dataPoint);
            }

            // Add the series data points  to the chart
            barChart.Series.Add(series);

            //  chart axes - minimum value for negative and positive numbers 
            chartArea.AxisX.Minimum = Math.Min(0, numbers.Min());
            chartArea.AxisX.Title = "Value";
            chartArea.AxisY.Title = "Bars";
            chartArea.AxisY.Interval = 1;

            // apply new changes
            barChart.Invalidate();
        }
    }

}