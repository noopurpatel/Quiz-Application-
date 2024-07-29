using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG455LAB_4
{
	public class Questionnaire
	{
        public string QuestionNumber { get; set; }
		public string Question { get; set; }
		public Dictionary<string, string> OptionAndAnswer { get; set; }
		public string CorrectAnswer { get; set; }
		public string SelectedAnswer { get; set; } = "";
	}
}
