namespace MathToolBelt.Sorting.Ui.App
{
    partial class Main
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GenerateButton = new System.Windows.Forms.Button();
            this.AmountTextBox = new System.Windows.Forms.TextBox();
            this.AlgosComboBox = new System.Windows.Forms.ComboBox();
            this.NewTabButton = new System.Windows.Forms.Button();
            this.AlgoVisTabControl = new System.Windows.Forms.TabControl();
            this.PlaySoundCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SortButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GenerateButton
            // 
            this.GenerateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GenerateButton.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerateButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GenerateButton.Location = new System.Drawing.Point(137, 17);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(96, 23);
            this.GenerateButton.TabIndex = 1;
            this.GenerateButton.Text = "Generate";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // AmountTextBox
            // 
            this.AmountTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AmountTextBox.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountTextBox.Location = new System.Drawing.Point(6, 17);
            this.AmountTextBox.Name = "AmountTextBox";
            this.AmountTextBox.Size = new System.Drawing.Size(125, 23);
            this.AmountTextBox.TabIndex = 2;
            this.AmountTextBox.Text = "100";
            // 
            // AlgosComboBox
            // 
            this.AlgosComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AlgosComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AlgosComboBox.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlgosComboBox.FormattingEnabled = true;
            this.AlgosComboBox.Location = new System.Drawing.Point(6, 17);
            this.AlgosComboBox.Name = "AlgosComboBox";
            this.AlgosComboBox.Size = new System.Drawing.Size(179, 23);
            this.AlgosComboBox.TabIndex = 3;
            // 
            // NewTabButton
            // 
            this.NewTabButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NewTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewTabButton.Location = new System.Drawing.Point(778, 28);
            this.NewTabButton.Name = "NewTabButton";
            this.NewTabButton.Size = new System.Drawing.Size(42, 23);
            this.NewTabButton.TabIndex = 6;
            this.NewTabButton.Text = "+Tab";
            this.NewTabButton.UseVisualStyleBackColor = true;
            this.NewTabButton.Click += new System.EventHandler(this.NewTabButton_Click);
            // 
            // AlgoVisTabControl
            // 
            this.AlgoVisTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AlgoVisTabControl.Location = new System.Drawing.Point(12, 66);
            this.AlgoVisTabControl.Name = "AlgoVisTabControl";
            this.AlgoVisTabControl.SelectedIndex = 0;
            this.AlgoVisTabControl.Size = new System.Drawing.Size(808, 389);
            this.AlgoVisTabControl.TabIndex = 7;
            // 
            // PlaySoundCheckBox
            // 
            this.PlaySoundCheckBox.AutoSize = true;
            this.PlaySoundCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlaySoundCheckBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PlaySoundCheckBox.Location = new System.Drawing.Point(191, 19);
            this.PlaySoundCheckBox.Name = "PlaySoundCheckBox";
            this.PlaySoundCheckBox.Size = new System.Drawing.Size(80, 21);
            this.PlaySoundCheckBox.TabIndex = 8;
            this.PlaySoundCheckBox.Text = "Hear It";
            this.PlaySoundCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AmountTextBox);
            this.groupBox1.Controls.Add(this.GenerateButton);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 48);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Amount";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SortButton);
            this.groupBox2.Controls.Add(this.AlgosComboBox);
            this.groupBox2.Controls.Add(this.PlaySoundCheckBox);
            this.groupBox2.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Location = new System.Drawing.Point(259, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(353, 48);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sorting";
            // 
            // SortButton
            // 
            this.SortButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SortButton.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SortButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SortButton.Location = new System.Drawing.Point(277, 16);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(68, 23);
            this.SortButton.TabIndex = 11;
            this.SortButton.Text = "Sort";
            this.SortButton.UseVisualStyleBackColor = true;
            this.SortButton.Click += new System.EventHandler(this.SortButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 467);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.AlgoVisTabControl);
            this.Controls.Add(this.NewTabButton);
            this.Name = "Main";
            this.Text = "Algos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.TextBox AmountTextBox;
        private System.Windows.Forms.ComboBox AlgosComboBox;
        private System.Windows.Forms.Button NewTabButton;
        private System.Windows.Forms.TabControl AlgoVisTabControl;
        private System.Windows.Forms.CheckBox PlaySoundCheckBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button SortButton;
    }
}

