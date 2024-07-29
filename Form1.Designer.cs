namespace PRG455LAB_4
{
	partial class Form1
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
			label1 = new Label();
			groupBox1 = new GroupBox();
			label8 = new Label();
			label7 = new Label();
			label6 = new Label();
			label5 = new Label();
			label4 = new Label();
			label3 = new Label();
			label2 = new Label();
			btnCancel = new Button();
			btnBegin = new Button();
			groupBox1.SuspendLayout();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
			label1.Location = new Point(76, 59);
			label1.Name = "label1";
			label1.Size = new Size(225, 30);
			label1.TabIndex = 0;
			label1.Text = "Begin: C# Skills-Quiz";
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(label8);
			groupBox1.Controls.Add(label7);
			groupBox1.Controls.Add(label6);
			groupBox1.Controls.Add(label5);
			groupBox1.Controls.Add(label4);
			groupBox1.Controls.Add(label3);
			groupBox1.Controls.Add(label2);
			groupBox1.Font = new Font("Segoe UI", 12F);
			groupBox1.Location = new Point(76, 105);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(674, 280);
			groupBox1.TabIndex = 1;
			groupBox1.TabStop = false;
			groupBox1.Text = "Instructuions";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(31, 215);
			label8.Name = "label8";
			label8.Size = new Size(376, 21);
			label8.TabIndex = 6;
			label8.Text = "Click begin to start: C# Skills-Quiz, click Cancel to exit";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(248, 147);
			label7.Name = "label7";
			label7.Size = new Size(142, 21);
			label7.TabIndex = 5;
			label7.Text = "Password required.";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(31, 147);
			label6.Name = "label6";
			label6.Size = new Size(79, 21);
			label6.TabIndex = 4;
			label6.Text = "Password:";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(248, 95);
			label5.Name = "label5";
			label5.Size = new Size(237, 21);
			label5.TabIndex = 3;
			label5.Text = "This test allow multiple attempts.";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(29, 95);
			label4.Name = "label4";
			label4.Size = new Size(141, 21);
			label4.TabIndex = 2;
			label4.Text = "Multiple Attempts: ";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(248, 48);
			label3.Name = "label3";
			label3.Size = new Size(316, 21);
			label3.TabIndex = 1;
			label3.Text = "This test cannot be saved and resumed later.";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(27, 48);
			label2.Name = "label2";
			label2.Size = new Size(140, 21);
			label2.TabIndex = 0;
			label2.Text = "Force Completion: ";
			// 
			// btnCancel
			// 
			btnCancel.Location = new Point(579, 415);
			btnCancel.Name = "btnCancel";
			btnCancel.Size = new Size(75, 23);
			btnCancel.TabIndex = 2;
			btnCancel.Text = "Cancel";
			btnCancel.UseVisualStyleBackColor = true;
			btnCancel.Click += btnCancel_Click;
			// 
			// btnBegin
			// 
			btnBegin.Location = new Point(675, 415);
			btnBegin.Name = "btnBegin";
			btnBegin.Size = new Size(75, 23);
			btnBegin.TabIndex = 3;
			btnBegin.Text = "Begin";
			btnBegin.UseVisualStyleBackColor = true;
			btnBegin.Click += btnBegin_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(btnBegin);
			Controls.Add(btnCancel);
			Controls.Add(groupBox1);
			Controls.Add(label1);
			Name = "Form1";
			Text = "Quiz Application";
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private GroupBox groupBox1;
		private Label label6;
		private Label label5;
		private Label label4;
		private Label label3;
		private Label label2;
		private Label label8;
		private Label label7;
		private Button btnCancel;
		private Button btnBegin;
	}
}
