
namespace CQRS_Sample
{
	partial class ManageStudent
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.gbThongTin = new System.Windows.Forms.GroupBox();
			this.dtNgaySinh = new System.Windows.Forms.DateTimePicker();
			this.btAdd = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.tbName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lbMSSV = new System.Windows.Forms.Label();
			this.tbMSSV = new System.Windows.Forms.TextBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btFind = new System.Windows.Forms.Button();
			this.tbMS = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.gbThongTin.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// gbThongTin
			// 
			this.gbThongTin.Controls.Add(this.dtNgaySinh);
			this.gbThongTin.Controls.Add(this.btAdd);
			this.gbThongTin.Controls.Add(this.label2);
			this.gbThongTin.Controls.Add(this.tbName);
			this.gbThongTin.Controls.Add(this.label1);
			this.gbThongTin.Controls.Add(this.lbMSSV);
			this.gbThongTin.Controls.Add(this.tbMSSV);
			this.gbThongTin.Font = new System.Drawing.Font("Segoe UI", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.gbThongTin.Location = new System.Drawing.Point(22, 12);
			this.gbThongTin.Name = "gbThongTin";
			this.gbThongTin.Size = new System.Drawing.Size(568, 161);
			this.gbThongTin.TabIndex = 1;
			this.gbThongTin.TabStop = false;
			this.gbThongTin.Text = "Thông tin sinh viên";
			// 
			// dtNgaySinh
			// 
			this.dtNgaySinh.Location = new System.Drawing.Point(116, 69);
			this.dtNgaySinh.Name = "dtNgaySinh";
			this.dtNgaySinh.Size = new System.Drawing.Size(200, 29);
			this.dtNgaySinh.TabIndex = 6;
			// 
			// btAdd
			// 
			this.btAdd.Location = new System.Drawing.Point(247, 121);
			this.btAdd.Name = "btAdd";
			this.btAdd.Size = new System.Drawing.Size(96, 34);
			this.btAdd.TabIndex = 5;
			this.btAdd.Text = "Add";
			this.btAdd.UseVisualStyleBackColor = true;
			this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(316, 31);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(63, 23);
			this.label2.TabIndex = 4;
			this.label2.Text = "Họ Tên";
			// 
			// tbName
			// 
			this.tbName.Location = new System.Drawing.Point(393, 25);
			this.tbName.Name = "tbName";
			this.tbName.Size = new System.Drawing.Size(170, 29);
			this.tbName.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(22, 75);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(88, 23);
			this.label1.TabIndex = 4;
			this.label1.Text = "Ngày Sinh";
			// 
			// lbMSSV
			// 
			this.lbMSSV.AutoSize = true;
			this.lbMSSV.Location = new System.Drawing.Point(56, 34);
			this.lbMSSV.Name = "lbMSSV";
			this.lbMSSV.Size = new System.Drawing.Size(54, 23);
			this.lbMSSV.TabIndex = 2;
			this.lbMSSV.Text = "MSSV";
			// 
			// tbMSSV
			// 
			this.tbMSSV.Location = new System.Drawing.Point(116, 28);
			this.tbMSSV.Name = "tbMSSV";
			this.tbMSSV.Size = new System.Drawing.Size(170, 29);
			this.tbMSSV.TabIndex = 1;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView1.Location = new System.Drawing.Point(22, 221);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.RowTemplate.Height = 25;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.ShowEditingIcon = false;
			this.dataGridView1.Size = new System.Drawing.Size(568, 191);
			this.dataGridView1.TabIndex = 2;
			// 
			// btFind
			// 
			this.btFind.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btFind.Location = new System.Drawing.Point(529, 181);
			this.btFind.Name = "btFind";
			this.btFind.Size = new System.Drawing.Size(61, 34);
			this.btFind.TabIndex = 6;
			this.btFind.Text = "Find";
			this.btFind.UseVisualStyleBackColor = true;
			this.btFind.Click += new System.EventHandler(this.btFind_Click);
			// 
			// tbMS
			// 
			this.tbMS.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.tbMS.Location = new System.Drawing.Point(388, 182);
			this.tbMS.Name = "tbMS";
			this.tbMS.Size = new System.Drawing.Size(135, 32);
			this.tbMS.TabIndex = 7;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label3.Location = new System.Drawing.Point(239, 190);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(143, 25);
			this.label3.TabIndex = 8;
			this.label3.Text = "Find with MSSV";
			// 
			// ManageStudent
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(619, 432);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.tbMS);
			this.Controls.Add(this.btFind);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.gbThongTin);
			this.Name = "ManageStudent";
			this.Text = "Manage Student";
			this.gbThongTin.ResumeLayout(false);
			this.gbThongTin.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox gbThongTin;
		private System.Windows.Forms.Button btAdd;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lbMSSV;
		private System.Windows.Forms.TextBox tbMSSV;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btFind;
		private System.Windows.Forms.TextBox tbMS;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DateTimePicker dtNgaySinh;
		private System.Windows.Forms.TextBox t;
	}
}

