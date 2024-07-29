using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG455LAB_4
{
	public partial class UserDetailForm : Form
	{
		List<Questionnaire> Questionnaires = new List<Questionnaire>();
		string correctPassword = "prg455";
		int counter = 0;
		int maxAttempt = 3;
		User user = new User();
		public UserDetailForm()
		{
			InitializeComponent();
			LoadQuestionnaires();
		}

		private void btnContinue_Click(object sender, EventArgs e)
		{
			if(txtBoxName.Text is null || txtBoxName.Text.Length == 0 )
			{
				MessageBox.Show("Please enter your name");
			}
			if (txtBoxStudentId.Text is null || txtBoxStudentId.Text.Length == 0)
			{
				MessageBox.Show("Please enter your student id");
			}
			if (txtBoxPassword.Text is null || txtBoxPassword.Text.Length == 0)
			{
				MessageBox.Show("Please enter your password");
			}

			user.Username = txtBoxName.Text;
			user.StudentId = txtBoxStudentId.Text;

			if(txtBoxPassword.Text == correctPassword)
			{
				this.Hide();
				QuestionnaireForm questionnaireForm = new QuestionnaireForm(user, Questionnaires);
				questionnaireForm.Closed += (s, args) => this.Close();
				questionnaireForm.Show();
			}
			else
			{
				counter++; 
				if(counter < maxAttempt)
				{
					MessageBox.Show($"Wrong password, {maxAttempt - counter} remained.");
				}
				else
				{
					MessageBox.Show($"Application will terminate");
					Environment.Exit(0);
				}

			}
		}

		private void LoadQuestionnaires()
		{
			Questionnaires.Clear();
			Questionnaires.Add(new Questionnaire
			{
				QuestionNumber = "Question #1",
				Question = "Which of the following converts a type to a 32-bit integer in C#?",
				OptionAndAnswer = new Dictionary<string, string>
				{
					{"A", "(A) ToDecimal" },
					{"B", "(B) ToDouble" },
					{"C", "(C) ToInt16" },
					{"D", "(D) ToInt32" }
			},
				CorrectAnswer = "D"
			});

			Questionnaires.Add(new Questionnaire
			{
				QuestionNumber = "Question #2",
				Question = "Which of the following method copies the actual values of an argument into the formal parameter of the function?",
				OptionAndAnswer = new Dictionary<string, string>
				{
					{"A", "(A) Value Paramters" },
					{"B", "(B) Reference Paramaters" },
					{"C", "(C) Output parameters" }
			},
				CorrectAnswer = "B"
			});

			Questionnaires.Add(new Questionnaire
			{
				QuestionNumber = "Question #3",
				Question = "Which of the following declares a jagged array in C#?",
				OptionAndAnswer = new Dictionary<string, string>
				{
					{"A", "(A) double[][] arr" },
					{"B", "(B) double[,] arr" },
					{"C", "(C) double arr[][]" }
			},
				CorrectAnswer = "A"
			});

			Questionnaires.Add(new Questionnaire
			{
				QuestionNumber = "Question #4",
				Question = "Which of the following is not allow in C# as access modifier?",
				OptionAndAnswer = new Dictionary<string, string>
				{
					{"A", "(A) public" },
					{"B", "(B) friend" },
					{"C", "(C) internal" },
					{"D", "(D) protected" }
			},
				CorrectAnswer = "B"
			});

			Questionnaires.Add(new Questionnaire
			{
				QuestionNumber = "Question #5",
				Question = "Which is the String method used to compare tow strings with each other?",
				OptionAndAnswer = new Dictionary<string, string>
				{
					{"A", "(A) Comapre" },
					{"B", "(B) Compare To" },
					{"C", "(C) Copy" },
					{"D", "(D) ConCat" }
			},
				CorrectAnswer = "A"
			});
		}
	}
}
