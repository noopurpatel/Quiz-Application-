namespace PRG455LAB_4
{
	partial class QuestionnaireForm
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
			lblQustionNumber = new Label();
			groupBoxQuestion = new GroupBox();
			radioButton4 = new RadioButton();
			radioButton3 = new RadioButton();
			radioButton2 = new RadioButton();
			radioButton1 = new RadioButton();
			label2 = new Label();
			lblSecondLeft = new Label();
			label3 = new Label();
			progressBar1 = new ProgressBar();
			btnSubmit = new Button();
			btnNext = new Button();
			groupBoxQuestion.SuspendLayout();
			SuspendLayout();
			// 
			// lblQustionNumber
			// 
			lblQustionNumber.AutoSize = true;
			lblQustionNumber.Font = new Font("Rockwell Condensed", 16F, FontStyle.Bold);
			lblQustionNumber.Location = new Point(141, 81);
			lblQustionNumber.Name = "lblQustionNumber";
			lblQustionNumber.Size = new Size(0, 26);
			lblQustionNumber.TabIndex = 0;
			// 
			// groupBoxQuestion
			// 
			groupBoxQuestion.Controls.Add(radioButton4);
			groupBoxQuestion.Controls.Add(radioButton3);
			groupBoxQuestion.Controls.Add(radioButton2);
			groupBoxQuestion.Controls.Add(radioButton1);
			groupBoxQuestion.Location = new Point(145, 137);
			groupBoxQuestion.Name = "groupBoxQuestion";
			groupBoxQuestion.Size = new Size(469, 205);
			groupBoxQuestion.TabIndex = 1;
			groupBoxQuestion.TabStop = false;
			// 
			// radioButton4
			// 
			radioButton4.AutoSize = true;
			radioButton4.Location = new Point(21, 136);
			radioButton4.Name = "radioButton4";
			radioButton4.Size = new Size(14, 13);
			radioButton4.TabIndex = 3;
			radioButton4.TabStop = true;
			radioButton4.UseVisualStyleBackColor = true;
			// 
			// radioButton3
			// 
			radioButton3.AutoSize = true;
			radioButton3.Location = new Point(22, 102);
			radioButton3.Name = "radioButton3";
			radioButton3.Size = new Size(14, 13);
			radioButton3.TabIndex = 2;
			radioButton3.TabStop = true;
			radioButton3.UseVisualStyleBackColor = true;
			// 
			// radioButton2
			// 
			radioButton2.AutoSize = true;
			radioButton2.Location = new Point(21, 72);
			radioButton2.Name = "radioButton2";
			radioButton2.Size = new Size(14, 13);
			radioButton2.TabIndex = 1;
			radioButton2.TabStop = true;
			radioButton2.UseVisualStyleBackColor = true;
			// 
			// radioButton1
			// 
			radioButton1.AutoSize = true;
			radioButton1.Location = new Point(22, 41);
			radioButton1.Name = "radioButton1";
			radioButton1.Size = new Size(14, 13);
			radioButton1.TabIndex = 0;
			radioButton1.TabStop = true;
			radioButton1.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(145, 383);
			label2.Name = "label2";
			label2.Size = new Size(78, 15);
			label2.TabIndex = 2;
			label2.Text = "Time Left => ";
			// 
			// lblSecondLeft
			// 
			lblSecondLeft.AutoSize = true;
			lblSecondLeft.Location = new Point(229, 383);
			lblSecondLeft.Name = "lblSecondLeft";
			lblSecondLeft.Size = new Size(0, 15);
			lblSecondLeft.TabIndex = 3;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(519, 359);
			label3.Name = "label3";
			label3.Size = new Size(79, 15);
			label3.TabIndex = 4;
			label3.Text = "% Completed";
			// 
			// progressBar1
			// 
			progressBar1.Location = new Point(519, 383);
			progressBar1.Name = "progressBar1";
			progressBar1.Size = new Size(100, 23);
			progressBar1.TabIndex = 5;
			// 
			// btnSubmit
			// 
			btnSubmit.Location = new Point(145, 451);
			btnSubmit.Name = "btnSubmit";
			btnSubmit.Size = new Size(75, 23);
			btnSubmit.TabIndex = 6;
			btnSubmit.Text = "Submit";
			btnSubmit.UseVisualStyleBackColor = true;
			btnSubmit.Click += btnSubmit_Click;
			// 
			// btnNext
			// 
			btnNext.Location = new Point(539, 451);
			btnNext.Name = "btnNext";
			btnNext.Size = new Size(75, 23);
			btnNext.TabIndex = 7;
			btnNext.Text = "Next";
			btnNext.UseVisualStyleBackColor = true;
			btnNext.Click += btnNext_Click;
			// 
			// QuestionnaireForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 495);
			Controls.Add(btnNext);
			Controls.Add(btnSubmit);
			Controls.Add(progressBar1);
			Controls.Add(label3);
			Controls.Add(lblSecondLeft);
			Controls.Add(label2);
			Controls.Add(groupBoxQuestion);
			Controls.Add(lblQustionNumber);
			Name = "QuestionnaireForm";
			Text = "QuestionnaireForm";
			Load += QuestionnaireForm_Load;
			groupBoxQuestion.ResumeLayout(false);
			groupBoxQuestion.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lblQustionNumber;
		private GroupBox groupBoxQuestion;
		private RadioButton radioButton4;
		private RadioButton radioButton3;
		private RadioButton radioButton2;
		private RadioButton radioButton1;
		private Label label2;
		private Label lblSecondLeft;
		private Label label3;
		private ProgressBar progressBar1;
		private Button btnSubmit;
		private Button btnNext;
	}
}