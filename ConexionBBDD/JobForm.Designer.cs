namespace ConexionBBDD
{
    partial class JobForm
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
            this.lblNewJob = new System.Windows.Forms.Label();
            this.lblJob_id = new System.Windows.Forms.Label();
            this.txtjob_id = new System.Windows.Forms.TextBox();
            this.txtjob_title = new System.Windows.Forms.TextBox();
            this.lblJobTitle = new System.Windows.Forms.Label();
            this.txtmin_salary = new System.Windows.Forms.TextBox();
            this.lblMinSal = new System.Windows.Forms.Label();
            this.txtmax_salary = new System.Windows.Forms.TextBox();
            this.lblMaxSal = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNewJob
            // 
            this.lblNewJob.AutoSize = true;
            this.lblNewJob.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewJob.Location = new System.Drawing.Point(151, 9);
            this.lblNewJob.Name = "lblNewJob";
            this.lblNewJob.Size = new System.Drawing.Size(103, 31);
            this.lblNewJob.TabIndex = 0;
            this.lblNewJob.Text = "New Job";
            // 
            // lblJob_id
            // 
            this.lblJob_id.AutoSize = true;
            this.lblJob_id.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJob_id.Location = new System.Drawing.Point(67, 87);
            this.lblJob_id.Name = "lblJob_id";
            this.lblJob_id.Size = new System.Drawing.Size(22, 20);
            this.lblJob_id.TabIndex = 1;
            this.lblJob_id.Text = "Id";
            // 
            // txtjob_id
            // 
            this.txtjob_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtjob_id.Font = new System.Drawing.Font("Segoe UI Variable Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtjob_id.Location = new System.Drawing.Point(95, 87);
            this.txtjob_id.Name = "txtjob_id";
            this.txtjob_id.Size = new System.Drawing.Size(50, 20);
            this.txtjob_id.TabIndex = 2;
            // 
            // txtjob_title
            // 
            this.txtjob_title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtjob_title.Font = new System.Drawing.Font("Segoe UI Variable Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtjob_title.Location = new System.Drawing.Point(211, 87);
            this.txtjob_title.Name = "txtjob_title";
            this.txtjob_title.Size = new System.Drawing.Size(187, 20);
            this.txtjob_title.TabIndex = 4;
            // 
            // lblJobTitle
            // 
            this.lblJobTitle.AutoSize = true;
            this.lblJobTitle.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobTitle.Location = new System.Drawing.Point(162, 87);
            this.lblJobTitle.Name = "lblJobTitle";
            this.lblJobTitle.Size = new System.Drawing.Size(43, 20);
            this.lblJobTitle.TabIndex = 3;
            this.lblJobTitle.Text = "Title ";
            // 
            // txtmin_salary
            // 
            this.txtmin_salary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtmin_salary.Font = new System.Drawing.Font("Segoe UI Variable Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmin_salary.Location = new System.Drawing.Point(157, 123);
            this.txtmin_salary.Name = "txtmin_salary";
            this.txtmin_salary.Size = new System.Drawing.Size(88, 20);
            this.txtmin_salary.TabIndex = 6;
            // 
            // lblMinSal
            // 
            this.lblMinSal.AutoSize = true;
            this.lblMinSal.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinSal.Location = new System.Drawing.Point(68, 123);
            this.lblMinSal.Name = "lblMinSal";
            this.lblMinSal.Size = new System.Drawing.Size(83, 20);
            this.lblMinSal.TabIndex = 5;
            this.lblMinSal.Text = "Min Salary";
            // 
            // txtmax_salary
            // 
            this.txtmax_salary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtmax_salary.Font = new System.Drawing.Font("Segoe UI Variable Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmax_salary.Location = new System.Drawing.Point(157, 161);
            this.txtmax_salary.Name = "txtmax_salary";
            this.txtmax_salary.Size = new System.Drawing.Size(88, 20);
            this.txtmax_salary.TabIndex = 8;
            // 
            // lblMaxSal
            // 
            this.lblMaxSal.AutoSize = true;
            this.lblMaxSal.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxSal.Location = new System.Drawing.Point(68, 161);
            this.lblMaxSal.Name = "lblMaxSal";
            this.lblMaxSal.Size = new System.Drawing.Size(85, 20);
            this.lblMaxSal.TabIndex = 7;
            this.lblMaxSal.Text = "Max Salary";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(139, 230);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(136, 39);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Save";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // JobForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(430, 353);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtmax_salary);
            this.Controls.Add(this.lblMaxSal);
            this.Controls.Add(this.txtmin_salary);
            this.Controls.Add(this.lblMinSal);
            this.Controls.Add(this.txtjob_title);
            this.Controls.Add(this.lblJobTitle);
            this.Controls.Add(this.txtjob_id);
            this.Controls.Add(this.lblJob_id);
            this.Controls.Add(this.lblNewJob);
            this.Name = "JobForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Job";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNewJob;
        private System.Windows.Forms.Label lblJob_id;
        private System.Windows.Forms.TextBox txtjob_id;
        private System.Windows.Forms.TextBox txtjob_title;
        private System.Windows.Forms.Label lblJobTitle;
        private System.Windows.Forms.TextBox txtmin_salary;
        private System.Windows.Forms.Label lblMinSal;
        private System.Windows.Forms.TextBox txtmax_salary;
        private System.Windows.Forms.Label lblMaxSal;
        private System.Windows.Forms.Button btnGuardar;
    }
}