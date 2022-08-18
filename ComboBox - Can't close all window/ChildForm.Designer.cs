namespace ComboBox___Can_t_close_all_window
{
	partial class ChildForm
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
			this.comboBox = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// comboBox
			// 
			this.comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.comboBox.FormattingEnabled = true;
			this.comboBox.Location = new System.Drawing.Point(233, 247);
			this.comboBox.Name = "comboBox";
			this.comboBox.Size = new System.Drawing.Size(226, 32);
			this.comboBox.TabIndex = 0;
			this.comboBox.DataSource = comboBoxSource;
			// 
			// ChildForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.comboBox);
			this.Name = "ChildForm";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ComboBox comboBox;
	}
}