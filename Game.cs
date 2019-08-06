#region Using

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using StudyApp.Data;

#endregion

namespace StudyApp
{
    public partial class Game : Form
    {
        private List<StudyItem> _items;
        private Random _rand = new Random();
        private int _curItem = 0;
        private int total;
        private int wrong;

        public Game(string group)
        {
            InitializeComponent();

            StudyItem[] itemsHold = StudyItem.LoadAll();
            _items = !string.IsNullOrEmpty(group) ? itemsHold.Where(x => x.Group == group.ToLower()).ToList() : itemsHold.ToList();

            // randomize
            _items = _items.OrderBy(x => _rand.Next()).ToList();

            if (_items.Count == 0)
            {
                MessageBox.Show("No items in this group!");
                Close();
                return;
            }

            total = _items.Count;

            // get answers.
            foreach (StudyItem item in _items)
            {
                string[] answers = new string[4];
                int rightAnswer = _rand.Next(0, 4);
                answers[rightAnswer] = item.Answer;

                for (int j = 0; j < answers.Length; j++)
                {
                    // Check if unfilled answer.
                    if (answers[j] != null) continue;

                    int retryCount = 0;

                    while (retryCount < 10)
                    {
                        int otherItem = _rand.Next(0, _items.Count);
                        string selectedAnswer = _items[otherItem].Answer;
                        if (!answers.Contains(selectedAnswer))
                        {
                            answers[j] = _items[otherItem].Answer;
                            break;
                        }

                        retryCount++;
                    }
                }

                item.Answers = answers;
            }

            DisplayItem(_items[_curItem]);
        }

        public void DisplayItem(StudyItem it)
        {
            questionText.Text = it.Question;
            pic.Image = it.Image == null ? null : Image.FromFile(it.Image);
            answer1.Text = it.Answers[0];
            answer2.Text = it.Answers[1];
            answer3.Text = it.Answers[2];
            answer4.Text = it.Answers[3];

            pic.Focus();
        }

        private void Game_Load(object sender, EventArgs e)
        {
        }

        private void Prev_Click(object sender, EventArgs e)
        {
            _curItem--;
            if (_curItem < 0) _curItem = _items.Count - 1;
            DisplayItem(_items[_curItem]);
        }

        private void Next_Click(object sender, EventArgs e)
        {
            _curItem++;
            if (_curItem > _items.Count - 1) _curItem = 0;
            DisplayItem(_items[_curItem]);
        }

        private void Answer2_Click(object sender, EventArgs e)
        {
            SelectAnswer(1);
        }

        private void Answer4_Click(object sender, EventArgs e)
        {
            SelectAnswer(3);
        }

        private void Answer3_Click(object sender, EventArgs e)
        {
            SelectAnswer(2);
        }

        private void Answer1_Click(object sender, EventArgs e)
        {
            SelectAnswer(0);
        }

        private void SelectAnswer(int index)
        {
            StudyItem currentItem = _items[_curItem];
            if (currentItem.Answers[index] == currentItem.Answer)
            {
                MessageBox.Show($"Correct!\n{currentItem.AnswerExplanation}");
            }
            else
            {
                MessageBox.Show($"Wrong!\n{currentItem.AnswerExplanation}");
                wrong++;
            }

            _items.Remove(currentItem);

            if (_items.Count == 0)
            {
                MessageBox.Show($"Done! Wrong: {wrong}/{total}.");
                Close();
                return;
            }

            Next_Click(null, EventArgs.Empty);
        }
    }
}