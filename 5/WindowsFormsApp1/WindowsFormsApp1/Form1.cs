using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private string[] questions = { "2+2=", "2+3=", "1,5+6,5=" };
        private int[] correctAnswers = { 2, 0, 1 };
        private int currentQuestionIndex = 0;
        private int correctCount = 0;


        public Form1()
        {
            InitializeComponent();
            DisplayQuestion();
        }

        private void DisplayQuestion()
        {

            if (currentQuestionIndex < questions.Length)
            {
                labelQuestion.Text = questions[currentQuestionIndex];
                radioButton1.Text = "5";
                radioButton2.Text = "7";
                radioButton3.Text = "4";
            }
            else
            {
                
                MessageBox.Show($"Вiрних вiдповiдей: {correctCount}/{questions.Length}. " +
                    $"Ключ до тесту: {string.Join(", ", correctAnswers)}");
                this.Close();
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked && correctAnswers[currentQuestionIndex] == 0 ||
                radioButton2.Checked && correctAnswers[currentQuestionIndex] == 1 ||
                radioButton3.Checked && correctAnswers[currentQuestionIndex] == 2)
            {
                correctCount++;
            }


            currentQuestionIndex++;
            DisplayQuestion();


            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
        }
    }
}
