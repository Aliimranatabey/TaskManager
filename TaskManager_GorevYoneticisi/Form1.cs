using System;

using System.Collections.Generic;

using System.ComponentModel;

using System.Data;

using System.Drawing;

using System.Linq;

using System.Text;

using System.Windows.Forms;

using System.Diagnostics;

namespace Task_Manager__Görev_Yöneticisi_

{

	public partial class Form1 : Form

	{

		public Form1()

		{

			InitializeComponent();

		}

		private void listView1_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)

		{

			e.Cancel = true;

			e.NewWidth = listView1.Columns[e.ColumnIndex].Width;

		}

		private void ProgramlariListele()

		{

			listView1.Items.Clear();

			//Environment.MachineName PC Name

			int i = 0;

			foreach (Process p in Process.GetProcesses("."))

			{

				listView1.Items.Add(p.ProcessName);

				listView1.Items[i].SubItems.Add(p.Id.ToString());

				listView1.Items[i].SubItems.Add(Convert.ToInt32(Math.Round(Convert.ToDecimal(p.PrivateMemorySize64 / 1024))) + "KB");

				listView1.Items[i].SubItems.Add(p.Responding.ToString());

				i++;//www.gorselprogramlama.com

			}

			lblTotal.Text = listView1.Items.Count.ToString();

		}

		private void ProgramKapat(int pid)

		{

			Process.GetProcessById(pid).Kill();

		}

		private void Form1_Load(object sender, EventArgs e)

		{
			

			ProgramlariListele();

		}

		private void btnTaskEnd_Click(object sender, EventArgs e)//www.gorselprogramlama.com

		{

			try

			{

				ProgramKapat(Convert.ToInt32(listView1.SelectedItems[0].SubItems[1].Text));

			}

			catch

			{

			}

			ProgramlariListele();

		}

		private void button1_Click(object sender, EventArgs e)

		{

			ProgramlariListele();//www.gorselprogramlama.com

		}
	
	

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void listView1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
