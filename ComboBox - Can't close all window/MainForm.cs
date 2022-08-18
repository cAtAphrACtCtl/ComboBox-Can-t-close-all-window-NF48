using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox___Can_t_close_all_window
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		int i = 0;
		private void button1_Click(object sender, EventArgs e)
		{
			var newForm = new ChildForm();
			newForm.Show(this);
			newForm.Text = $"{i++} Form";
		}
	}
}
