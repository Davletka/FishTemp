namespace FishTemp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.Run = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.FishName = new System.Windows.Forms.ComboBox();
            this.Temperature = new System.Windows.Forms.TextBox();
            this.DataTime = new System.Windows.Forms.TextBox();
            this.TimeMin = new System.Windows.Forms.TextBox();
            this.MinTemp = new System.Windows.Forms.TextBox();
            this.TimeMax = new System.Windows.Forms.TextBox();
            this.MaxTemp = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Table = new System.Windows.Forms.DataGridView();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Norm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ErrorNorm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.Run);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnOpen);
            this.panel1.Controls.Add(this.FishName);
            this.panel1.Controls.Add(this.Temperature);
            this.panel1.Controls.Add(this.DataTime);
            this.panel1.Controls.Add(this.TimeMin);
            this.panel1.Controls.Add(this.MinTemp);
            this.panel1.Controls.Add(this.TimeMax);
            this.panel1.Controls.Add(this.MaxTemp);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(425, 450);
            this.panel1.TabIndex = 1;
            // 
            // Run
            // 
            this.Run.Location = new System.Drawing.Point(159, 326);
            this.Run.Name = "Run";
            this.Run.Size = new System.Drawing.Size(75, 23);
            this.Run.TabIndex = 11;
            this.Run.Text = "Результат";
            this.Run.UseVisualStyleBackColor = true;
            this.Run.Click += new System.EventHandler(this.Run_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(327, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(211, 12);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 9;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // FishName
            // 
            this.FishName.FormattingEnabled = true;
            this.FishName.Items.AddRange(new object[] {
            "Семга",
            "Минтай"});
            this.FishName.Location = new System.Drawing.Point(12, 38);
            this.FishName.Name = "FishName";
            this.FishName.Size = new System.Drawing.Size(147, 23);
            this.FishName.TabIndex = 8;
            this.FishName.TextChanged += new System.EventHandler(this.FishName_TextChanged);
            // 
            // Temperature
            // 
            this.Temperature.Location = new System.Drawing.Point(12, 276);
            this.Temperature.Name = "Temperature";
            this.Temperature.PlaceholderText = "Температура";
            this.Temperature.Size = new System.Drawing.Size(378, 23);
            this.Temperature.TabIndex = 6;
            // 
            // DataTime
            // 
            this.DataTime.Location = new System.Drawing.Point(12, 185);
            this.DataTime.Name = "DataTime";
            this.DataTime.PlaceholderText = "Дата";
            this.DataTime.Size = new System.Drawing.Size(147, 23);
            this.DataTime.TabIndex = 5;
            // 
            // TimeMin
            // 
            this.TimeMin.Location = new System.Drawing.Point(211, 121);
            this.TimeMin.Name = "TimeMin";
            this.TimeMin.PlaceholderText = "Допустимое время";
            this.TimeMin.Size = new System.Drawing.Size(126, 23);
            this.TimeMin.TabIndex = 4;
            // 
            // MinTemp
            // 
            this.MinTemp.Location = new System.Drawing.Point(12, 121);
            this.MinTemp.Name = "MinTemp";
            this.MinTemp.PlaceholderText = "Мин температура";
            this.MinTemp.Size = new System.Drawing.Size(147, 23);
            this.MinTemp.TabIndex = 3;
            // 
            // TimeMax
            // 
            this.TimeMax.Location = new System.Drawing.Point(211, 76);
            this.TimeMax.Name = "TimeMax";
            this.TimeMax.PlaceholderText = "Допустимое время";
            this.TimeMax.Size = new System.Drawing.Size(126, 23);
            this.TimeMax.TabIndex = 2;
            // 
            // MaxTemp
            // 
            this.MaxTemp.Location = new System.Drawing.Point(12, 76);
            this.MaxTemp.Name = "MaxTemp";
            this.MaxTemp.PlaceholderText = "Макс температура";
            this.MaxTemp.Size = new System.Drawing.Size(147, 23);
            this.MaxTemp.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.Controls.Add(this.Table);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(425, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(470, 450);
            this.panel2.TabIndex = 2;
            // 
            // Table
            // 
            this.Table.AllowUserToAddRows = false;
            this.Table.AllowUserToDeleteRows = false;
            this.Table.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.time,
            this.Fact,
            this.Norm,
            this.ErrorNorm});
            this.Table.Location = new System.Drawing.Point(15, 12);
            this.Table.Name = "Table";
            this.Table.ReadOnly = true;
            this.Table.Size = new System.Drawing.Size(443, 323);
            this.Table.TabIndex = 1;
            this.Table.Text = "dataGridView1";
            // 
            // time
            // 
            this.time.Frozen = true;
            this.time.HeaderText = "Время";
            this.time.Name = "time";
            this.time.ReadOnly = true;
            // 
            // Fact
            // 
            this.Fact.Frozen = true;
            this.Fact.HeaderText = "Факт";
            this.Fact.Name = "Fact";
            this.Fact.ReadOnly = true;
            // 
            // Norm
            // 
            this.Norm.Frozen = true;
            this.Norm.HeaderText = "Норма";
            this.Norm.Name = "Norm";
            this.Norm.ReadOnly = true;
            // 
            // ErrorNorm
            // 
            this.ErrorNorm.Frozen = true;
            this.ErrorNorm.HeaderText = "Отклонение от нормы";
            this.ErrorNorm.Name = "ErrorNorm";
            this.ErrorNorm.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TimeMax;
        private System.Windows.Forms.TextBox MaxTemp;
        private System.Windows.Forms.TextBox me;
        private System.Windows.Forms.TextBox Temperature;
        private System.Windows.Forms.TextBox DataTime;
        private System.Windows.Forms.TextBox TimeMin;
        private System.Windows.Forms.TextBox MinTemp;
        private System.Windows.Forms.ComboBox FishName;
        private System.Windows.Forms.Button Run;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.DataGridView Table;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fact;
        private System.Windows.Forms.DataGridViewTextBoxColumn Norm;
        private System.Windows.Forms.DataGridViewTextBoxColumn ErrorNorm;
    }
}

