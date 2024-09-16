using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quizify
{
    public partial class Form1 : Form
    {
        private List<QuizQuestion> quizQuestions;
        private int currentQuestionIndex;
        private int score;


        public Form1()
        {
            InitializeComponent();
            InitializeQuiz();
        }

        private void InitializeQuiz()
        {
            // Create the list of quiz questions with multiple-choice options
            quizQuestions = new List<QuizQuestion>
            {
                new QuizQuestion("What is the capital of France?", new List<string> { "London", "Paris", "Berlin", "Madrid" }, 1),
                new QuizQuestion("Which planet is known as the Red Planet?", new List<string> { "Venus", "Mars", "Jupiter", "Saturn" }, 1),
                new QuizQuestion("Who painted the Mona Lisa?", new List<string> { "Leonardo da Vinci", "Vincent van Gogh", "Pablo Picasso", "Michelangelo" }, 0),

                new QuizQuestion("What is the capital of France?", new List<string> { "London", "Paris", "Berlin", "Madrid" }, 1),
                new QuizQuestion("Which planet is known as the Red Planet?", new List<string> { "Venus", "Mars", "Jupiter", "Saturn" }, 1),
                new QuizQuestion("Who painted the Mona Lisa?", new List<string> { "Leonardo da Vinci", "Vincent van Gogh", "Pablo Picasso", "Michelangelo" }, 0),

                new QuizQuestion("What is the capital of France?", new List<string> { "London", "Paris", "Berlin", "Madrid" }, 1),
                new QuizQuestion("Which planet is known as the Red Planet?", new List<string> { "Venus", "Mars", "Jupiter", "Saturn" }, 1),
                new QuizQuestion("Who painted the Mona Lisa?", new List<string> { "Leonardo da Vinci", "Vincent van Gogh", "Pablo Picasso", "Michelangelo" }, 0),

                new QuizQuestion("What is the capital of France?", new List<string> { "London", "Paris", "Berlin", "Madrid" }, 1),
                new QuizQuestion("Which planet is known as the Red Planet?", new List<string> { "Venus", "Mars", "Jupiter", "Saturn" }, 1),
                new QuizQuestion("Who painted the Mona Lisa?", new List<string> { "Leonardo da Vinci", "Vincent van Gogh", "Pablo Picasso", "Michelangelo" }, 0)
            };

            // Initialize variables
            currentQuestionIndex = 0;
            score = 0;

            // Display the first question
            DisplayQuestion();
        }

        private void DisplayQuestion()
        {
            if (currentQuestionIndex < quizQuestions.Count)
            {
                QuizQuestion currentQuestion = quizQuestions[currentQuestionIndex];

                // Update the question label and options
                questionLabel.Text = currentQuestion.QuestionText;
                choice_radioButton1.Text = currentQuestion.Options[0];
                choice_radioButton2.Text = currentQuestion.Options[1];
                choice_radioButton3.Text = currentQuestion.Options[2];
                choice_radioButton4.Text = currentQuestion.Options[3];

                // Clear selection from radio buttons
                choice_radioButton1.Checked = false;
                choice_radioButton2.Checked = false;
                choice_radioButton3.Checked = false;
                choice_radioButton4.Checked = false;

                // Enable the Next button
                next_button1.Enabled = true;
            }
            else
            {
                // Quiz is finished
                MessageBox.Show($"Quiz finished! Your score is: {score}", "Quiz Finished", MessageBoxButtons.OK, MessageBoxIcon.Information);
                next_button1.Enabled = false;
            }

        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            // Check if the user has selected an option
            if (choice_radioButton1.Checked || choice_radioButton2.Checked || choice_radioButton3.Checked || choice_radioButton4.Checked)
            {
                // Get the selected option index
                int selectedOptionIndex = GetSelectedOptionIndex();

                // Check if the selected option is correct
                QuizQuestion currentQuestion = quizQuestions[currentQuestionIndex];
                if (selectedOptionIndex == currentQuestion.CorrectOptionIndex)
                {
                    score++;
                }

                // Move to the next question
                currentQuestionIndex++;

                // Display the next question
                DisplayQuestion();
            }
            else
            {
                MessageBox.Show("Please select an option before proceeding.", "Option Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        

             private int GetSelectedOptionIndex()
        {
            if (choice_radioButton1.Checked)
                return 0;
            else if (choice_radioButton2.Checked)
                return 1;
            else if (choice_radioButton3.Checked)
                return 2;
            else if (choice_radioButton4.Checked)
                return 3;
            else
                return -1;
        }
    }

    public class QuizQuestion
    {
        public string QuestionText { get; set; }
        public List<string> Options { get; set; }
        public int CorrectOptionIndex { get; set; }

        public QuizQuestion(string questionText, List<string> options, int correctOptionIndex)
        {
            QuestionText = questionText;
            Options = options;
            CorrectOptionIndex = correctOptionIndex;
        }
    }

}

