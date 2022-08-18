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
	public partial class ChildForm : Form
	{
		public ChildForm()
		{
			InitializeComponent();
		}

		string[] comboBoxSource = { "C", "C#", "C++", "Swift", "Objective-C", "Java", "JavaScript" };
	}
}
