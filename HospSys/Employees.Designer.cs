namespace HospSys
{
    partial class Employees
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
            this.components = new System.ComponentModel.Container();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pBInsert = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pBDocNurse = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pBManagers = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pBSalary = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewTotalMonthlySalary = new System.Windows.Forms.DataGridView();
            this.d24819387DataSet = new HospSys.d24819387DataSet();
            this.totalmonthlysalaryforstaffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.total_monthly_salary_for_staffTableAdapter = new HospSys.d24819387DataSetTableAdapters.total_monthly_salary_for_staffTableAdapter();
            this.clinicNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthlySalaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBInsert)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBDocNurse)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBManagers)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBSalary)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTotalMonthlySalary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d24819387DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalmonthlysalaryforstaffBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(286, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(714, 80);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(210, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(232, 55);
            this.label6.TabIndex = 2;
            this.label6.Text = "Employees";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::HospSys.Properties.Resources.FontAwesome_f060_0__2561;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(630, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 74);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 660);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.pBInsert);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 482);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(286, 134);
            this.panel4.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Insert data";
            // 
            // pBInsert
            // 
            this.pBInsert.BackgroundImage = global::HospSys.Properties.Resources.octicons_f096_2__256;
            this.pBInsert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pBInsert.Location = new System.Drawing.Point(75, 6);
            this.pBInsert.Name = "pBInsert";
            this.pBInsert.Size = new System.Drawing.Size(127, 106);
            this.pBInsert.TabIndex = 3;
            this.pBInsert.TabStop = false;
            this.pBInsert.MouseLeave += new System.EventHandler(this.pBInsert_MouseLeave_1);
            this.pBInsert.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pBInsert_MouseMove_1);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label3);
            this.panel7.Controls.Add(this.pBDocNurse);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 348);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(286, 134);
            this.panel7.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Doctors and nurses ";
            // 
            // pBDocNurse
            // 
            this.pBDocNurse.BackgroundImage = global::HospSys.Properties.Resources.FontAwesome_f0f0_0__256;
            this.pBDocNurse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pBDocNurse.Location = new System.Drawing.Point(75, 6);
            this.pBDocNurse.Name = "pBDocNurse";
            this.pBDocNurse.Size = new System.Drawing.Size(127, 106);
            this.pBDocNurse.TabIndex = 3;
            this.pBDocNurse.TabStop = false;
            this.pBDocNurse.MouseLeave += new System.EventHandler(this.pBDocNurse_MouseLeave);
            this.pBDocNurse.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pBDocNurse_MouseMove);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.pBManagers);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 214);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(286, 134);
            this.panel6.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Managers";
            // 
            // pBManagers
            // 
            this.pBManagers.BackgroundImage = global::HospSys.Properties.Resources.icomoon_e657_1__256;
            this.pBManagers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pBManagers.Location = new System.Drawing.Point(75, 6);
            this.pBManagers.Name = "pBManagers";
            this.pBManagers.Size = new System.Drawing.Size(127, 107);
            this.pBManagers.TabIndex = 4;
            this.pBManagers.TabStop = false;
            this.pBManagers.MouseLeave += new System.EventHandler(this.pBManagers_MouseLeave);
            this.pBManagers.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pBManagers_MouseMove);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.pBSalary);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 80);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(286, 134);
            this.panel5.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(120, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Salaries";
            // 
            // pBSalary
            // 
            this.pBSalary.BackgroundImage = global::HospSys.Properties.Resources.FontAwesome_f0d6_3__256;
            this.pBSalary.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pBSalary.Location = new System.Drawing.Point(75, 6);
            this.pBSalary.Name = "pBSalary";
            this.pBSalary.Size = new System.Drawing.Size(127, 107);
            this.pBSalary.TabIndex = 5;
            this.pBSalary.TabStop = false;
            this.pBSalary.MouseLeave += new System.EventHandler(this.pBSalary_MouseLeave);
            this.pBSalary.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pBSalary_MouseMove);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(146)))), ((int)(((byte)(49)))));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(286, 80);
            this.panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(37, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Health Care";
            // 
            // dataGridViewTotalMonthlySalary
            // 
            this.dataGridViewTotalMonthlySalary.AllowUserToAddRows = false;
            this.dataGridViewTotalMonthlySalary.AllowUserToDeleteRows = false;
            this.dataGridViewTotalMonthlySalary.AllowUserToOrderColumns = true;
            this.dataGridViewTotalMonthlySalary.AutoGenerateColumns = false;
            this.dataGridViewTotalMonthlySalary.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewTotalMonthlySalary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewTotalMonthlySalary.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewTotalMonthlySalary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTotalMonthlySalary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clinicNumberDataGridViewTextBoxColumn,
            this.staffNameDataGridViewTextBoxColumn,
            this.positionDataGridViewTextBoxColumn,
            this.monthlySalaryDataGridViewTextBoxColumn});
            this.dataGridViewTotalMonthlySalary.DataSource = this.totalmonthlysalaryforstaffBindingSource;
            this.dataGridViewTotalMonthlySalary.Location = new System.Drawing.Point(354, 130);
            this.dataGridViewTotalMonthlySalary.Name = "dataGridViewTotalMonthlySalary";
            this.dataGridViewTotalMonthlySalary.ReadOnly = true;
            this.dataGridViewTotalMonthlySalary.Size = new System.Drawing.Size(578, 480);
            this.dataGridViewTotalMonthlySalary.TabIndex = 4;
            this.dataGridViewTotalMonthlySalary.Visible = false;
            // 
            // d24819387DataSet
            // 
            this.d24819387DataSet.DataSetName = "d24819387DataSet";
            this.d24819387DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // totalmonthlysalaryforstaffBindingSource
            // 
            this.totalmonthlysalaryforstaffBindingSource.DataMember = "total_monthly_salary_for_staff";
            this.totalmonthlysalaryforstaffBindingSource.DataSource = this.d24819387DataSet;
            // 
            // total_monthly_salary_for_staffTableAdapter
            // 
            this.total_monthly_salary_for_staffTableAdapter.ClearBeforeFill = true;
            // 
            // clinicNumberDataGridViewTextBoxColumn
            // 
            this.clinicNumberDataGridViewTextBoxColumn.DataPropertyName = "Clinic Number";
            this.clinicNumberDataGridViewTextBoxColumn.HeaderText = "Clinic Number";
            this.clinicNumberDataGridViewTextBoxColumn.Name = "clinicNumberDataGridViewTextBoxColumn";
            this.clinicNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // staffNameDataGridViewTextBoxColumn
            // 
            this.staffNameDataGridViewTextBoxColumn.DataPropertyName = "Staff Name";
            this.staffNameDataGridViewTextBoxColumn.HeaderText = "Staff Name";
            this.staffNameDataGridViewTextBoxColumn.Name = "staffNameDataGridViewTextBoxColumn";
            this.staffNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "Position";
            this.positionDataGridViewTextBoxColumn.HeaderText = "Position";
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            this.positionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // monthlySalaryDataGridViewTextBoxColumn
            // 
            this.monthlySalaryDataGridViewTextBoxColumn.DataPropertyName = "Monthly Salary";
            this.monthlySalaryDataGridViewTextBoxColumn.HeaderText = "Monthly Salary";
            this.monthlySalaryDataGridViewTextBoxColumn.Name = "monthlySalaryDataGridViewTextBoxColumn";
            this.monthlySalaryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 660);
            this.Controls.Add(this.dataGridViewTotalMonthlySalary);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Employees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employees";
            this.Load += new System.EventHandler(this.Employees_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBInsert)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBDocNurse)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBManagers)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBSalary)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTotalMonthlySalary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d24819387DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalmonthlysalaryforstaffBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pBSalary;
        private System.Windows.Forms.PictureBox pBManagers;
        private System.Windows.Forms.PictureBox pBDocNurse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pBInsert;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewTotalMonthlySalary;
        private d24819387DataSet d24819387DataSet;
        private System.Windows.Forms.BindingSource totalmonthlysalaryforstaffBindingSource;
        private d24819387DataSetTableAdapters.total_monthly_salary_for_staffTableAdapter total_monthly_salary_for_staffTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clinicNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monthlySalaryDataGridViewTextBoxColumn;
    }
}