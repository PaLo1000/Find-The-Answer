using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindTheAnswer_game
{
    public partial class Form1 : Form
    {

        List<Question> questions;
        List<Answer> answer;
        Question currentQ;
        Random random = new Random();

        string filePathQuestion = "C:\\Users\\inces\\source\\repos\\FindTheAnswer_game\\FindTheAnswer_game\\Question.txt";
        string filePathAnswer = "C:\\Users\\inces\\source\\repos\\FindTheAnswer_game\\FindTheAnswer_game\\Answer.txt";

        int currentId;

        bool isCorrect;

        public Form1()
        {
            InitializeComponent();
            addNewQuestionForm1.Visible = false;

            QuestionAndAnswer();

            LoadNewQuestion();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string userAnswer = txtAnswer.Text.Trim().ToLower();

            string correctAnswer = answer
                .First(a => a.Id == currentQ.Id)?.Text.Trim().ToLower();

            if (userAnswer == correctAnswer)
            {
                lblGreen.BackColor = Color.Green;
                isCorrect = true;

            }
            else
            {
                lblRed.BackColor = Color.Red;
                isCorrect = false;

            }

            ScoreAndHeart();

            Task.Delay(1000).ContinueWith(_ =>
            {
                this.Invoke(new Action(() =>
                {
                    lblGreen.BackColor = this.BackColor;
                    lblRed.BackColor = this.BackColor;
                }));
            });

            LoadNewQuestion();


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addNewQuestionForm1.Visible = true;
        }


        private void label7_Click(object sender, EventArgs e)
        {
            addNewQuestionForm1.Visible = false;
        }

        private void QuestionAndAnswer()
        {
            questions = File.ReadAllLines(filePathQuestion)
                .Select(line => line.Split('|')).Select(parts => new Question
                {
                    Id = int.Parse(parts[0]),
                    Text = parts[1]
                })
                .ToList();

            answer = File.ReadAllLines(filePathAnswer)
                .Select(line => line.Split('|')).Select(parts => new Answer
                {
                    Id = int.Parse(parts[0]),
                    Text = parts[1]
                })
                .ToList();

        }


        private void LoadNewQuestion()
        {
            currentQ = questions[random.Next(questions.Count)];
            rchtxtQuestiontbl.Text = currentQ.Text;
            txtAnswer.Clear();
        }

        private void ScoreAndHeart()
        {

            if (isCorrect)
            {
                int score = int.Parse(lblScore.Text);
                score += 100;
                lblScore.Text = score.ToString();
            }
            else
            {
                string hearts = lblHeart.Text;
                if (hearts.Length > 0)
                {
                    hearts = hearts.Substring(0, hearts.Length - 1);
                    lblHeart.Text = hearts;
                }
                if (hearts.Length == 0)
                {
                    MessageBox.Show("Game Over! Your score: " + lblScore.Text);
                    Application.Restart();
                }
            }

        }

    }
}
