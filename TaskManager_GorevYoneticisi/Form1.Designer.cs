namespace Task_Manager__Görev_Yöneticisi_
{
	partial class Form1
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
			this.listView1 = new System.Windows.Forms.ListView();
			this.btnTaskEnd = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.lblTotal = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SuspendLayout();
			// 
			// listView1
			// 
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
			this.listView1.GridLines = true;
			this.listView1.HideSelection = false;
			this.listView1.Location = new System.Drawing.Point(33, 21);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(331, 382);
			this.listView1.TabIndex = 0;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
			// 
			// btnTaskEnd
			// 
			this.btnTaskEnd.BackColor = System.Drawing.Color.Red;
			this.btnTaskEnd.Location = new System.Drawing.Point(245, 410);
			this.btnTaskEnd.Name = "btnTaskEnd";
			this.btnTaskEnd.Size = new System.Drawing.Size(121, 47);
			this.btnTaskEnd.TabIndex = 5;
			this.btnTaskEnd.Text = "Görevi Sonlandır";
			this.btnTaskEnd.UseVisualStyleBackColor = false;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(33, 410);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(170, 17);
			this.label5.TabIndex = 6;
			this.label5.Text = "Çalışan Uygulama Sayısı :";
			// 
			// lblTotal
			// 
			this.lblTotal.AutoSize = true;
			this.lblTotal.Location = new System.Drawing.Point(209, 410);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(30, 17);
			this.lblTotal.TabIndex = 7;
			this.lblTotal.Text = "null";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Lime;
			this.button1.Location = new System.Drawing.Point(67, 429);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(136, 27);
			this.button1.TabIndex = 8;
			this.button1.Text = "Yenile";
			this.button1.UseVisualStyleBackColor = false;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Programın Adı";
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "PID";
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "CPU";
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Çalışma";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(396, 468);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.lblTotal);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.btnTaskEnd);
			this.Controls.Add(this.listView1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.Button btnTaskEnd;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lblTotal;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
	}
}

