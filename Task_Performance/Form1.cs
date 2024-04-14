using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_Performance
{
    public partial class Form1 : Form
    {
        private string[] wordsToGuess = { "hello", "world", "programming", "computer", "game" }; 
        private string wordToGuess; 
        private StringBuilder hiddenWord; 
        private int attemptsLeft = 3; 

        public Form1()
        {
            InitializeComponent();
            StartNewGame();
        }
        private void StartNewGame()
        {
            
            wordToGuess = wordsToGuess[new Random().Next(0, wordsToGuess.Length)];
            hiddenWord = new StringBuilder(HideWord(wordToGuess));
            lblWordToGuess.Text = "Word to Guess: " + hiddenWord;
            attemptsLeft = 3; 
            lblAttemptsLeft.Text = "Attempts left: " + attemptsLeft;
            lstWrongGuesses.Items.Clear();
        }

        private void btnCheck_Click_1(object sender, EventArgs e)
        {
            string guessedWord = txtGuess.Text.ToLower();

            if (guessedWord == wordToGuess)
            {
                lblResult.Text = "Correct!";
                MessageBox.Show("Congratulations! You guessed the word.");
                StartNewGame(); 
            }
            else
            {
                attemptsLeft--;
                lblAttemptsLeft.Text = "Attempts left: " + attemptsLeft;
                if (attemptsLeft == 0)
                {
                    lblResult.Text = "Out of attempts. The word was: " + wordToGuess;
                    MessageBox.Show("Out of attempts. The word was: " + wordToGuess);
                    StartNewGame(); 
                }
                else
                {
                    lstWrongGuesses.Items.Add(guessedWord);
                    lblResult.Text = "Try Again!";
                }
            }

            txtGuess.Clear(); 
        }
        private string HideWord(string word)
        {
            StringBuilder hidden = new StringBuilder();
            foreach (char c in word)
            {
                hidden.Append('*');
            }
            return hidden.ToString();
        }
    }

    }

    

