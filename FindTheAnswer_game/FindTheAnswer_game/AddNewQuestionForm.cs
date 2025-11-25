using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindTheAnswer_game
{
    public partial class AddNewQuestionForm : UserControl
    {

        string filePathQuestion = "C:\\Users\\inces\\source\\repos\\FindTheAnswer_game\\FindTheAnswer_game\\Question.txt";
        string filePathAnswer = "C:\\Users\\inces\\source\\repos\\FindTheAnswer_game\\FindTheAnswer_game\\Answer.txt";


        public AddNewQuestionForm()
        {
            InitializeComponent();
            LearnLastId();
        }

        private void label7_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtQuestionID.Text == "" || txtAnswerID.Text == "" ||
                rchtxtQuestion.Text == "" || rchtxtAnswer.Text == "")
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            else if (txtQuestionID.Text != txtAnswerID.Text)
            {
                MessageBox.Show("Question ID and Answer ID must be the same.");
                return;
            }
            File.AppendAllText(filePathQuestion, Environment.NewLine +
                txtQuestionID.Text + "|" + rchtxtQuestion.Text);
            File.AppendAllText(filePathAnswer, Environment.NewLine +
                txtAnswerID.Text + "|" + rchtxtAnswer.Text);

            MessageBox.Show("New question and answer saved successfully.");
            ClearAllTxtbox();
            LearnLastId();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAllTxtbox();
        }

        private void ClearAllTxtbox()
        {
            txtAnswerID.Clear();
            txtQuestionID.Clear();
            rchtxtAnswer.Clear();
            rchtxtQuestion.Clear();
        }

        private void LearnLastId()
        {
            var lastQuestionLine = File.ReadLines(filePathQuestion).Last();
            var lastAnswerLine = File.ReadLines(filePathAnswer).Last();

            var lastQuestionId = lastQuestionLine.Split('|')[0];
            var lastAnswerId = lastAnswerLine.Split('|')[0];

            int nextId = Math.Max(int.Parse(lastQuestionId), int.Parse(lastAnswerId)) + 1;

            txtQuestionID.Text = nextId.ToString();
            txtAnswerID.Text = nextId.ToString();
        }
    }
}
