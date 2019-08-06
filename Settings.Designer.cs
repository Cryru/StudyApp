namespace StudyApp
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.itemList = new System.Windows.Forms.ListBox();
            this.add = new System.Windows.Forms.Button();
            this.pic = new System.Windows.Forms.PictureBox();
            this.pictureSelect = new System.Windows.Forms.OpenFileDialog();
            this.questionText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.newItem = new System.Windows.Forms.Button();
            this.imageSel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.answerText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.answerExplanation = new System.Windows.Forms.TextBox();
            this.groupLbl = new System.Windows.Forms.Label();
            this.groupText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // itemList
            // 
            this.itemList.FormattingEnabled = true;
            this.itemList.Location = new System.Drawing.Point(12, 12);
            this.itemList.Name = "itemList";
            this.itemList.Size = new System.Drawing.Size(246, 576);
            this.itemList.TabIndex = 0;
            this.itemList.SelectedIndexChanged += new System.EventHandler(this.ItemList_SelectedIndexChanged);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(538, 631);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(152, 27);
            this.add.TabIndex = 4;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.Add_Click);
            // 
            // pic
            // 
            this.pic.BackColor = System.Drawing.Color.White;
            this.pic.Location = new System.Drawing.Point(283, 12);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(390, 255);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic.TabIndex = 2;
            this.pic.TabStop = false;
            // 
            // pictureSelect
            // 
            this.pictureSelect.FileName = "pic.png";
            // 
            // questionText
            // 
            this.questionText.Location = new System.Drawing.Point(319, 305);
            this.questionText.Multiline = true;
            this.questionText.Name = "questionText";
            this.questionText.Size = new System.Drawing.Size(371, 135);
            this.questionText.TabIndex = 1;
            this.questionText.TextChanged += new System.EventHandler(this.QuestionTextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(264, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Question";
            // 
            // newItem
            // 
            this.newItem.Location = new System.Drawing.Point(12, 591);
            this.newItem.Name = "newItem";
            this.newItem.Size = new System.Drawing.Size(75, 23);
            this.newItem.TabIndex = 5;
            this.newItem.Text = "New";
            this.newItem.UseVisualStyleBackColor = true;
            this.newItem.Click += new System.EventHandler(this.NewItem_Click);
            // 
            // imageSel
            // 
            this.imageSel.Location = new System.Drawing.Point(601, 273);
            this.imageSel.Name = "imageSel";
            this.imageSel.Size = new System.Drawing.Size(81, 29);
            this.imageSel.TabIndex = 6;
            this.imageSel.Text = "Select Image";
            this.imageSel.UseVisualStyleBackColor = true;
            this.imageSel.Click += new System.EventHandler(this.ImageSel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 452);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Answer";
            // 
            // answerText
            // 
            this.answerText.Location = new System.Drawing.Point(319, 446);
            this.answerText.Name = "answerText";
            this.answerText.Size = new System.Drawing.Size(371, 20);
            this.answerText.TabIndex = 2;
            this.answerText.TextChanged += new System.EventHandler(this.AnswerText_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 475);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 26);
            this.label3.TabIndex = 9;
            this.label3.Text = "Answer\r\nExplanation";
            // 
            // answerExplanation
            // 
            this.answerExplanation.Location = new System.Drawing.Point(319, 472);
            this.answerExplanation.Multiline = true;
            this.answerExplanation.Name = "answerExplanation";
            this.answerExplanation.Size = new System.Drawing.Size(371, 132);
            this.answerExplanation.TabIndex = 3;
            this.answerExplanation.TextChanged += new System.EventHandler(this.AnswerExplanation_TextChanged);
            // 
            // groupLbl
            // 
            this.groupLbl.AutoSize = true;
            this.groupLbl.Location = new System.Drawing.Point(271, 613);
            this.groupLbl.Name = "groupLbl";
            this.groupLbl.Size = new System.Drawing.Size(36, 13);
            this.groupLbl.TabIndex = 11;
            this.groupLbl.Text = "Group";
            // 
            // groupText
            // 
            this.groupText.Location = new System.Drawing.Point(319, 610);
            this.groupText.Name = "groupText";
            this.groupText.Size = new System.Drawing.Size(371, 20);
            this.groupText.TabIndex = 10;
            this.groupText.TextChanged += new System.EventHandler(this.GroupText_TextChanged);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 670);
            this.Controls.Add(this.groupLbl);
            this.Controls.Add(this.groupText);
            this.Controls.Add(this.answerExplanation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.answerText);
            this.Controls.Add(this.imageSel);
            this.Controls.Add(this.newItem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.questionText);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.add);
            this.Controls.Add(this.itemList);
            this.Name = "Settings";
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox itemList;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.OpenFileDialog pictureSelect;
        private System.Windows.Forms.TextBox questionText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button newItem;
        private System.Windows.Forms.Button imageSel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox answerText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox answerExplanation;
        private System.Windows.Forms.Label groupLbl;
        private System.Windows.Forms.TextBox groupText;
    }
}