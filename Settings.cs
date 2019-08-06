#region Using

using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using StudyApp.Data;

#endregion

namespace StudyApp
{
    public partial class Settings : Form
    {
        private StudyItem _item;

        public Settings()
        {
            InitializeComponent();
            NewItem();
            RefreshItems();
        }

        private void NewItem()
        {
            _item = new StudyItem();
            pic.Image = null;
            answerExplanation.Text = "";
            questionText.Text = "";
            answerText.Text = "";
            groupText.Text = "";

            add.Text = "Add";
        }

        private void RefreshItems()
        {
            itemList.Items.Clear();

            try
            {
                itemList.Items.AddRange(StudyItem.LoadAll());
            }
            catch (Exception)
            {
                MessageBox.Show("Excuse me, what?");
            }
        }

        private void ItemList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (itemList.SelectedIndex == -1) return;

            try
            {
                _item = ((StudyItem) itemList.Items[itemList.SelectedIndex]).Clone();
                pic.Image = _item.Image == null ? null : Image.FromFile(_item.Image);
                answerExplanation.Text = _item.AnswerExplanation;
                questionText.Text = _item.Question;
                answerText.Text = _item.Answer;
                groupText.Text = _item.Group;

                add.Text = "Save";
            }
            catch (Exception)
            {
                // ignored
            }
        }

        private void ImageSel_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = pictureSelect.ShowDialog();

                string fileName = Path.Combine(StudyItem.PictureDirectory, Guid.NewGuid().ToString());

                if (dialogResult != DialogResult.OK && dialogResult != DialogResult.Yes) return;
                File.Copy(pictureSelect.FileName, fileName);

                _item.Image = fileName;
                pic.Image = Image.FromFile(fileName);
            }
            catch (Exception)
            {
                // ignored
            }
        }

        private void QuestionTextChanged(object sender, EventArgs e)
        {
            _item.Question = questionText.Text;
        }

        private void AnswerExplanation_TextChanged(object sender, EventArgs e)
        {
            _item.AnswerExplanation = answerExplanation.Text;
        }

        private void AnswerText_TextChanged(object sender, EventArgs e)
        {
            _item.Answer = answerText.Text;
        }

        private void GroupText_TextChanged(object sender, EventArgs e)
        {
            _item.Group = groupText.Text.ToLower();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            string fileName = _item.FileName ?? Path.Combine(StudyItem.ItemsDirectory, Guid.NewGuid().ToString());

            FileStream stream = File.Open(fileName, FileMode.OpenOrCreate);
            StudyItem.ItemSerializer.Serialize(stream, _item);
            stream.Flush();
            stream.Close();
            RefreshItems();
        }

        private void NewItem_Click(object sender, EventArgs e)
        {
            NewItem();
        }

    }
}