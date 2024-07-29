using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG455LAB_4
{
	public partial class OutputForm : Form
	{
		int yPoint = 20;
		public User _user;
		public List<Questionnaire> _questionnaires;
		public OutputForm(User user, List<Questionnaire> questionnaires)
		{
			InitializeComponent();
			_user = user;
			_questionnaires = questionnaires;
		}

		private void OutputForm_Load(object sender, EventArgs e)
		{
			lblStudentName.Text = _user.Username;
			lblSudentId.Text = _user.StudentId;
			lblAttemptScore.Text = _questionnaires.Where(x => x.SelectedAnswer != "").Count().ToString();

			lblFirstSelectedAnswer.Visible = false;
			lblFirstCorrectAnswer.Visible=false;
			lblSecondSelectedAnswer.Visible=false;
			lblSecondCorrectAnswer.Visible=false;
			lblThirdSelectedAnswer.Visible=false;
			lblThirdCorrectAnswer.Visible=false;
			lblFourthSelectedAnswer.Visible=false;
			lblFourthCorrectAnswer.Visible=false;
			lblFifthSelectedAnswer.Visible = false;
			lblFifthCorrectAnswer.Visible = false;
			label4.Visible = false;
			label5.Visible = false;
			label6.Visible = false;
			label11.Visible = false;
			label10.Visible = false;
			label8.Visible = false;
			label14.Visible = false;
			label13.Visible = false;
			label9.Visible = false;
			label17.Visible = false;
			label16.Visible = false;
			label12.Visible = false;
			label20.Visible = false;
			label19.Visible = false;
			label15.Visible = false;
			var incorrectAnswers = _questionnaires.Where(q => q.SelectedAnswer != q.CorrectAnswer || q.SelectedAnswer == "");
			foreach (var item in incorrectAnswers)
			{
				if (item.QuestionNumber == "Question #1")
				{
					label4.Visible=true;
					label5.Visible = true;
					label6.Visible = true;
					lblFirstSelectedAnswer.Visible = true;
					lblFirstCorrectAnswer.Visible = true;
					lblFirstSelectedAnswer.Text = item.OptionAndAnswer.FirstOrDefault(x => x.Key == item.SelectedAnswer).Value;
					lblFirstCorrectAnswer.Text = item.OptionAndAnswer.FirstOrDefault(x => x.Key == item.CorrectAnswer).Value;
				}
				else if (item.QuestionNumber == "Question #2")
				{
					label11.Visible = true;
					label10.Visible = true;
					label8.Visible = true;
					lblSecondSelectedAnswer.Visible = true;
					lblSecondCorrectAnswer.Visible = true;
					lblSecondSelectedAnswer.Text = item.OptionAndAnswer.FirstOrDefault(x => x.Key == item.SelectedAnswer).Value;
					lblSecondCorrectAnswer.Text = item.OptionAndAnswer.FirstOrDefault(x => x.Key == item.CorrectAnswer).Value;
				}
				else if (item.QuestionNumber == "Question #3")
				{
					label14.Visible = true;
					label13.Visible = true;
					label9.Visible = true;
					lblThirdSelectedAnswer.Visible = true;
					lblThirdCorrectAnswer.Visible = true;
					lblThirdSelectedAnswer.Text = item.OptionAndAnswer.FirstOrDefault(x => x.Key == item.SelectedAnswer).Value;
					lblThirdCorrectAnswer.Text = item.OptionAndAnswer.FirstOrDefault(x => x.Key == item.CorrectAnswer).Value;
				}
				else if (item.QuestionNumber == "Question #4")
				{
					label17.Visible = true;
					label16.Visible = true;
					label12.Visible = true;
					lblFourthSelectedAnswer.Visible = true;
					lblFourthCorrectAnswer.Visible = true;
					lblFourthSelectedAnswer.Text = item.OptionAndAnswer.FirstOrDefault(x => x.Key == item.SelectedAnswer).Value;
					lblFourthCorrectAnswer.Text = item.OptionAndAnswer.FirstOrDefault(x => x.Key == item.CorrectAnswer).Value;
				}
				else if (item.QuestionNumber == "Question #5")
				{
					label20.Visible = true;
					label19.Visible = true;
					label15.Visible = true;
					lblFifthSelectedAnswer.Visible = true;
					lblFifthCorrectAnswer.Visible = true;
					lblFifthSelectedAnswer.Text = item.OptionAndAnswer.FirstOrDefault(x => x.Key == item.SelectedAnswer).Value;
					lblFifthCorrectAnswer.Text = item.OptionAndAnswer.FirstOrDefault(x => x.Key == item.CorrectAnswer).Value;
				}
				else { // }
				}
			}

		}

		private void button1_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}
	}
}
