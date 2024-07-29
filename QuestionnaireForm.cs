using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using Microsoft.VisualBasic.ApplicationServices;

namespace PRG455LAB_4
{
	public partial class QuestionnaireForm : Form
	{
		int questionIndex = 0;
		int maxCount = 10;
		public List<Questionnaire> _questionnaires;
		public User _user;
		public Questionnaire _currentQuestionarire = new Questionnaire();
		System.Timers.Timer myTimer = new System.Timers.Timer(1000);
		int percentageToAdd = 0;
		public QuestionnaireForm(User user, List<Questionnaire> questionnaires)
		{
			InitializeComponent();
			_questionnaires = questionnaires;
			_user = user;
			percentageToAdd = 100 / _questionnaires.Count;
		}

		private void QuestionnaireForm_Load(object sender, EventArgs e)
		{
			_currentQuestionarire = _questionnaires.ElementAt(questionIndex);
			lblQustionNumber.Text = _currentQuestionarire.QuestionNumber;
			groupBoxQuestion.Text = _currentQuestionarire.Question;
			radioButton1.Text = _currentQuestionarire.OptionAndAnswer.ElementAt(0).Value;
			radioButton2.Text = _currentQuestionarire.OptionAndAnswer.ElementAt(1).Value;
			radioButton3.Text = _currentQuestionarire.OptionAndAnswer.ElementAt(2).Value;
			if(_currentQuestionarire.OptionAndAnswer.Count>3)
				{
				radioButton4.Text = _currentQuestionarire.OptionAndAnswer.ElementAt(3).Value;
			}

			myTimer.Elapsed += Tick;
			myTimer.Enabled = true;
		}

		private void Tick(Object source, ElapsedEventArgs e)
		{
			maxCount -= 1;
			if (maxCount >= 0)
			{
				lblSecondLeft.Invoke(t => t.Text = maxCount.ToString() + " seconds");
			}
			else
			{
				groupBoxQuestion.Invoke(g => g.Enabled = false);
			}

		}

		private void btnSubmit_Click(object sender, EventArgs e)
		{
			_currentQuestionarire.SelectedAnswer = GetCheckedAnswer();
			btnSubmit.Enabled = false;
		}

		private void btnNext_Click(object sender, EventArgs e)
		{
			questionIndex++;
			if (questionIndex < _questionnaires.Count)
			{
				btnSubmit.Enabled = true;
				DialogResult result = DialogResult.None;
				if (String.IsNullOrEmpty(_currentQuestionarire.SelectedAnswer))
				{
					result = MessageBox.Show("You haven't submitted your answer, move on to the next question?", "Confirm", MessageBoxButtons.YesNo);
				}
				if (result == DialogResult.No)
					return;

				groupBoxQuestion.Invoke(g => g.Enabled = true);
				maxCount = 10;
				System.Timers.Timer newTimer = new System.Timers.Timer(1000);
				newTimer.Elapsed -= Tick;
				newTimer.Enabled = false;
				newTimer.Enabled = true;

				progressBar1.Value += percentageToAdd;

				_currentQuestionarire = _questionnaires.ElementAt(questionIndex);
				lblQustionNumber.Text = _currentQuestionarire.QuestionNumber;
				groupBoxQuestion.Text = _currentQuestionarire.Question;
				radioButton1.Text = _currentQuestionarire.OptionAndAnswer.ElementAt(0).Value;
				radioButton2.Text = _currentQuestionarire.OptionAndAnswer.ElementAt(1).Value;
				radioButton3.Text = _currentQuestionarire.OptionAndAnswer.ElementAt(2).Value;
				radioButton4.Visible= false;
				if (_currentQuestionarire.OptionAndAnswer.Count > 3)
				{
					radioButton4.Visible = true;
					radioButton4.Text = _currentQuestionarire.OptionAndAnswer.ElementAt(3).Value;
				}

				newTimer.Elapsed += Tick;
				newTimer.Enabled = true;
			}
			else if (questionIndex == _questionnaires.Count)
			{
				this.Hide();
				OutputForm outputForm = new OutputForm(_user, _questionnaires);
				outputForm.Closed += (s, args) => this.Close();
				outputForm.Show();
			}
		}

		private string GetCheckedAnswer()
		{
			if (radioButton1.Checked == true)
				return "A";
			else if (radioButton2.Checked == true)
				return "B";
			else if (radioButton3.Checked == true)
				return "C";
			else if (radioButton4.Checked == true)
				return "D";
			else
			{
				//
			}
			return "";
		}
	}
	public static class Extensions
	{
		public static void Invoke<TControlType>(this TControlType control, Action<TControlType> del)
			where TControlType : Control
		{
			if (control.InvokeRequired)
				control.Invoke(new Action(() => del(control)));
			else
				del(control);
		}
	}
}
