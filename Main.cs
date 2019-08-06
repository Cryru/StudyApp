#region Using

using System;
using System.Windows.Forms;

#endregion

namespace StudyApp
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
        }

        private void SettingsButtonClick(object sender, EventArgs e)
        {
            var settingsWindow = new Settings();
            settingsWindow.Show();
        }

        private void Playbutton_Click(object sender, EventArgs e)
        {
            string groupName = ShowDialog("Select group, or leave empty for all.", "Group?");

            var g = new Game(groupName);
            if(!g.IsDisposed) g.Show();
        }

        public static string ShowDialog(string text, string caption)
        {
            var prompt = new Form
            {
                Width = 500,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };
            var textLabel = new Label {Left = 50, Top = 20, Width = 960, Text = text};
            var textBox = new TextBox {Left = 50, Top = 50, Width = 400};
            var confirmation = new Button {Text = "Ok", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK};
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }
    }
}