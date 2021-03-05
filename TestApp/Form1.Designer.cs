
namespace TestApp
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
			this.firstValue = new System.Windows.Forms.TextBox();
			this.secondValue = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// firstValue
			// 
			this.firstValue.Location = new System.Drawing.Point(12, 12);
			this.firstValue.Name = "firstValue";
			this.firstValue.Size = new System.Drawing.Size(515, 25);
			this.firstValue.TabIndex = 0;
			this.firstValue.TextChanged += new System.EventHandler(this.firstValue_TextChanged);
			// 
			// secondValue
			// 
			this.secondValue.Location = new System.Drawing.Point(12, 43);
			this.secondValue.Name = "secondValue";
			this.secondValue.Size = new System.Drawing.Size(515, 25);
			this.secondValue.TabIndex = 1;
			this.secondValue.TextChanged += new System.EventHandler(this.secondValue_TextChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(539, 80);
			this.Controls.Add(this.secondValue);
			this.Controls.Add(this.firstValue);
			this.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "TestApp";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox firstValue;
		private System.Windows.Forms.TextBox secondValue;
	}
}

