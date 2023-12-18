using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Form1 : Form
    {
        private string currentWord = "";
        private List<char> shuffledWord = new List<char>();
        private Random random = new Random();
        private int score = 0;

        public Form1()
        {
            score = 0;
            InitializeComponent();
            InitializeGame();
            DisplayScore();
        }
        static int GenerateRandomNumber(int minValue, int maxValue)
        {
            Random random = new Random();
            return random.Next(minValue, maxValue + 1);
        }
        private void InitializeGame()
        {
            int number = GenerateRandomNumber(3, 12);
            WebClient client = new WebClient();
            string downloadedString = client.DownloadString($"https://random-word-api.herokuapp.com/word?length={number}"); ;

            currentWord = downloadedString.Substring(2, downloadedString.Length - 4);

            shuffledWord = currentWord.ToList();
            shuffledWord = shuffledWord.OrderBy(c => random.Next()).ToList();

            DisplayShuffledWord();
        }

        private void DisplayShuffledWord()
        {
            lblShuffledWord.Text = string.Join(" ", shuffledWord);
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string enteredWord = txtEnteredWord.Text.ToLower();

            if (enteredWord == currentWord)
            {
                score += 10;
                MessageBox.Show("Correct! You solved the word.", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                InitializeGame();
                txtEnteredWord.Clear();
            }
            else
            {
                score = Math.Max(0, score - 1);
                MessageBox.Show("Incorrect. Try again.", "Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            DisplayScore();
        }
        private void btnShuffle_Click(object sender, EventArgs e)
        {
            shuffledWord = shuffledWord.OrderBy(c => random.Next()).ToList();

            DisplayShuffledWord();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            InitializeGame();
        }

        private void DisplayScore()
        {
            label1.Text = $"Score: {score}";
        }
    }
}