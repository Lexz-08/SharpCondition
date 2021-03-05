using SharpCondition;
using System;
using System.Windows.Forms;

namespace TestApp
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void firstValue_TextChanged(object sender, EventArgs e)
		{
			Condition.If(firstValue.Text == secondValue.Text, true,
				new Condition.MethodToInvokeArgs(ResultMessage));
		}
		private void secondValue_TextChanged(object sender, EventArgs e)
		{
			Condition.If(secondValue.Text == firstValue.Text, true,
				new Condition.MethodToInvokeArgs(ResultMessage));
		}

		private void ResultMessage(object n)
		{
			MessageBox.Show("This text and that text both are now equal!", "YAY EQUALITY!",
				MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}
