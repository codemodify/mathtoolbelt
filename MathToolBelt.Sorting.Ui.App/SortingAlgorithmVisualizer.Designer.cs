namespace MathToolBelt.Sorting.Ui.App
{
    partial class SortingAlgorithmVisualizer
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.HowItWorksTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.LabelBigO = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelCompares = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LabelSwaps = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LabelCopies = new System.Windows.Forms.Label();
            this.LabelTotalOperations = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.BarChart = new MathToolBelt.Sorting.Ui.App.ZedGraph.ZedGraphControl();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.Speed = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LabelN = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.Pause = new System.Windows.Forms.Button();
            this.Step = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Speed)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 161F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 221F));
            this.tableLayoutPanel1.Controls.Add(this.HowItWorksTextBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.BarChart, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(733, 505);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // HowItWorksTextBox
            // 
            this.HowItWorksTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HowItWorksTextBox.Location = new System.Drawing.Point(3, 3);
            this.HowItWorksTextBox.Multiline = true;
            this.HowItWorksTextBox.Name = "HowItWorksTextBox";
            this.HowItWorksTextBox.ReadOnly = true;
            this.HowItWorksTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.HowItWorksTextBox.Size = new System.Drawing.Size(345, 94);
            this.HowItWorksTextBox.TabIndex = 2;
            this.HowItWorksTextBox.WordWrap = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.LabelBigO, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.LabelCompares, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.LabelSwaps, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.LabelCopies, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.LabelTotalOperations, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.label8, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label9, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.label10, 2, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(515, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(215, 94);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Enabled = false;
            this.label5.Location = new System.Drawing.Point(0, 77);
            this.label5.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = ": Big-O";
            // 
            // LabelBigO
            // 
            this.LabelBigO.AutoSize = true;
            this.LabelBigO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelBigO.Location = new System.Drawing.Point(65, 77);
            this.LabelBigO.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.LabelBigO.Name = "LabelBigO";
            this.LabelBigO.Size = new System.Drawing.Size(60, 17);
            this.LabelBigO.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(0, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(65, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = ": Compares";
            // 
            // LabelCompares
            // 
            this.LabelCompares.AutoSize = true;
            this.LabelCompares.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelCompares.Location = new System.Drawing.Point(65, 5);
            this.LabelCompares.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.LabelCompares.Name = "LabelCompares";
            this.LabelCompares.Size = new System.Drawing.Size(60, 19);
            this.LabelCompares.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(0, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(65, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = ": Swaps";
            // 
            // LabelSwaps
            // 
            this.LabelSwaps.AutoSize = true;
            this.LabelSwaps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelSwaps.Location = new System.Drawing.Point(65, 29);
            this.LabelSwaps.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.LabelSwaps.Name = "LabelSwaps";
            this.LabelSwaps.Size = new System.Drawing.Size(60, 19);
            this.LabelSwaps.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Enabled = false;
            this.label7.Location = new System.Drawing.Point(0, 53);
            this.label7.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(65, 19);
            this.label7.TabIndex = 9;
            this.label7.Text = ": Copies";
            // 
            // LabelCopies
            // 
            this.LabelCopies.AutoSize = true;
            this.LabelCopies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelCopies.Location = new System.Drawing.Point(65, 53);
            this.LabelCopies.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.LabelCopies.Name = "LabelCopies";
            this.LabelCopies.Size = new System.Drawing.Size(60, 19);
            this.LabelCopies.TabIndex = 10;
            // 
            // LabelTotalOperations
            // 
            this.LabelTotalOperations.AutoSize = true;
            this.LabelTotalOperations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelTotalOperations.Location = new System.Drawing.Point(151, 29);
            this.LabelTotalOperations.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.LabelTotalOperations.Name = "LabelTotalOperations";
            this.LabelTotalOperations.Size = new System.Drawing.Size(64, 19);
            this.LabelTotalOperations.TabIndex = 0;
            this.LabelTotalOperations.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Enabled = false;
            this.label8.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(125, 8);
            this.label8.Margin = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "\\";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Enabled = false;
            this.label9.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(130, 29);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 19);
            this.label9.TabIndex = 12;
            this.label9.Text = "|-";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Enabled = false;
            this.label10.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(125, 48);
            this.label10.Margin = new System.Windows.Forms.Padding(0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 24);
            this.label10.TabIndex = 13;
            this.label10.Text = "/";
            // 
            // BarChart
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.BarChart, 3);
            this.BarChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BarChart.IsEnableHPan = false;
            this.BarChart.IsEnableHZoom = false;
            this.BarChart.IsEnableVPan = false;
            this.BarChart.IsEnableVZoom = false;
            this.BarChart.IsEnableWheelZoom = false;
            this.BarChart.IsPrintFillPage = false;
            this.BarChart.IsPrintKeepAspectRatio = false;
            this.BarChart.IsPrintScaleAll = false;
            this.BarChart.IsShowContextMenu = false;
            this.BarChart.IsShowCopyMessage = false;
            this.BarChart.Location = new System.Drawing.Point(3, 103);
            this.BarChart.Name = "BarChart";
            this.BarChart.ScrollGrace = 0D;
            this.BarChart.ScrollMaxX = 0D;
            this.BarChart.ScrollMaxY = 0D;
            this.BarChart.ScrollMaxY2 = 0D;
            this.BarChart.ScrollMinX = 0D;
            this.BarChart.ScrollMinY = 0D;
            this.BarChart.ScrollMinY2 = 0D;
            this.BarChart.Size = new System.Drawing.Size(727, 399);
            this.BarChart.TabIndex = 6;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.Speed, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.LabelN, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 1, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(351, 0);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(161, 100);
            this.tableLayoutPanel4.TabIndex = 7;
            // 
            // Speed
            // 
            this.Speed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Speed.Location = new System.Drawing.Point(48, 3);
            this.Speed.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.Speed.Maximum = 1000;
            this.Speed.Minimum = 1;
            this.Speed.Name = "Speed";
            this.Speed.Size = new System.Drawing.Size(113, 27);
            this.Speed.TabIndex = 10;
            this.Speed.TickStyle = System.Windows.Forms.TickStyle.None;
            this.Speed.Value = 1;
            this.Speed.ValueChanged += new System.EventHandler(this.Speed_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(0, 5);
            this.label4.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(48, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = ": Delay";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(0, 35);
            this.label6.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(48, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = ": Debug";
            // 
            // LabelN
            // 
            this.LabelN.AutoSize = true;
            this.LabelN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelN.Location = new System.Drawing.Point(48, 65);
            this.LabelN.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.LabelN.Name = "LabelN";
            this.LabelN.Size = new System.Drawing.Size(113, 35);
            this.LabelN.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(0, 65);
            this.label3.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(48, 35);
            this.label3.TabIndex = 2;
            this.label3.Text = ": N";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 4;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel5.Controls.Add(this.Pause, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.Step, 2, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(48, 30);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(112, 28);
            this.tableLayoutPanel5.TabIndex = 13;
            // 
            // Pause
            // 
            this.Pause.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pause.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pause.Location = new System.Drawing.Point(30, 0);
            this.Pause.Margin = new System.Windows.Forms.Padding(0);
            this.Pause.Name = "Pause";
            this.Pause.Size = new System.Drawing.Size(36, 28);
            this.Pause.TabIndex = 1;
            this.Pause.Text = "||";
            this.Pause.UseVisualStyleBackColor = true;
            this.Pause.Click += new System.EventHandler(this.Pause_Click);
            // 
            // Step
            // 
            this.Step.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Step.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Step.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Step.Location = new System.Drawing.Point(66, 0);
            this.Step.Margin = new System.Windows.Forms.Padding(0);
            this.Step.Name = "Step";
            this.Step.Size = new System.Drawing.Size(36, 28);
            this.Step.TabIndex = 2;
            this.Step.Text = ">";
            this.Step.UseVisualStyleBackColor = true;
            this.Step.Click += new System.EventHandler(this.Step_Click);
            // 
            // SortingAlgorithmVisualizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SortingAlgorithmVisualizer";
            this.Size = new System.Drawing.Size(733, 505);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Speed)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox HowItWorksTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LabelN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LabelCompares;
        private System.Windows.Forms.Label LabelSwaps;
        private System.Windows.Forms.Label LabelBigO;
        private ZedGraph.ZedGraphControl BarChart;
        private System.Windows.Forms.Label LabelTotalOperations;
        private System.Windows.Forms.TrackBar Speed;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button Step;
        private System.Windows.Forms.Button Pause;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LabelCopies;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}
