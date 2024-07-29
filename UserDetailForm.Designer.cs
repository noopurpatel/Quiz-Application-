namespace PRG455LAB_4
{
	partial class UserDetailForm
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
			label1 = new Label();
			groupBox1 = new GroupBox();
			label2 = new Label();
			txtBoxName = new TextBox();
			label3 = new Label();
			txtBoxStudentId = new TextBox();
			label4 = new Label();
			txtBoxPassword = new TextBox();
			btnContinue = new Button();
			groupBox1.SuspendLayout();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
			label1.Location = new Point(267, 84);
			label1.Name = "label1";
			label1.Size = new Size(225, 30);
			label1.TabIndex = 0;
			label1.Text = "Begin: C# Skills-Quiz";
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(txtBoxPassword);
			groupBox1.Controls.Add(label4);
			groupBox1.Controls.Add(txtBoxStudentId);
			groupBox1.Controls.Add(label3);
			groupBox1.Controls.Add(txtBoxName);
			groupBox1.Controls.Add(label2);
			groupBox1.Font = new Font("Segoe UI", 12F);
			groupBox1.Location = new Point(183, 142);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(452, 209);
			groupBox1.TabIndex = 1;
			groupBox1.TabStop = false;
			groupBox1.Text = "Please enter the following informations";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(41, 48);
			label2.Name = "label2";
			label2.Size = new Size(55, 21);
			label2.TabIndex = 0;
			label2.Text = "Name:";
			// 
			// txtBoxName
			// 
			txtBoxName.Location = new Point(143, 45);
			txtBoxName.Name = "txtBoxName";
			txtBoxName.Size = new Size(242, 29);
			txtBoxName.TabIndex = 1;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(41, 94);
			label3.Name = "label3";
			label3.Size = new Size(83, 21);
			label3.TabIndex = 2;
			label3.Text = "Student Id:";
			// 
			// txtBoxStudentId
			// 
			txtBoxStudentId.Location = new Point(143, 94);
			txtBoxStudentId.Name = "txtBoxStudentId";
			txtBoxStudentId.Size = new Size(242, 29);
			txtBoxStudentId.TabIndex = 3;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(41, 145);
			label4.Name = "label4";
			label4.Size = new Size(79, 21);
			label4.TabIndex = 4;
			label4.Text = "Password:";
			// 
			// txtBoxPassword
			// 
			txtBoxPassword.Location = new Point(143, 145);
			txtBoxPassword.Name = "txtBoxPassword";
			txtBoxPassword.Size = new Size(242, 29);
			txtBoxPassword.TabIndex = 5;
			// 
			// btnContinue
			// 
			btnContinue.Location = new Point(550, 385);
			btnContinue.Name = "btnContinue";
			btnContinue.Size = new Size(75, 23);
			btnContinue.TabIndex = 2;
			btnContinue.Text = "Continue";
			btnContinue.UseVisualStyleBackColor = true;
			btnContinue.Click += btnContinue_Click;
			// 
			// UserDetailForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(btnContinue);
			Controls.Add(groupBox1);
			Controls.Add(label1);
			Name = "UserDetailForm";
			Text = "UserDetailForm";
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private GroupBox groupBox1;
		private Label label3;
		private TextBox txtBoxName;
		private Label label2;
		private TextBox txtBoxPassword;
		private Label label4;
		private TextBox txtBoxStudentId;
		private Button btnContinue;
	}
}