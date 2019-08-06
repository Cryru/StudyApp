namespace StudyApp
{
    partial class Game
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
            this.pic = new System.Windows.Forms.PictureBox();
            this.questionText = new System.Windows.Forms.Label();
            this.answer4 = new System.Windows.Forms.Button();
            this.answer3 = new System.Windows.Forms.Button();
            this.answer1 = new System.Windows.Forms.Button();
            this.answer2 = new System.Windows.Forms.Button();
            this.prev = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // pic
            // 
            this.pic.BackColor = System.Drawing.Color.Black;
            this.pic.Dock = System.Windows.Forms.DockStyle.Top;
            this.pic.Location = new System.Drawing.Point(0, 0);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(837, 332);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic.TabIndex = 0;
            this.pic.TabStop = false;
            // 
            // questionText
            // 
            this.questionText.AutoSize = true;
            this.questionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionText.Location = new System.Drawing.Point(12, 335);
            this.questionText.Name = "questionText";
            this.questionText.Size = new System.Drawing.Size(119, 24);
            this.questionText.TabIndex = 1;
            this.questionText.Text = "questionText";
            // 
            // answer4
            // 
            this.answer4.Location = new System.Drawing.Point(431, 489);
            this.answer4.Name = "answer4";
            this.answer4.Size = new System.Drawing.Size(274, 60);
            this.answer4.TabIndex = 5;
            this.answer4.Text = "answer";
            this.answer4.UseVisualStyleBackColor = true;
            this.answer4.Click += new System.EventHandler(this.Answer4_Click);
            // 
            // answer3
            // 
            this.answer3.Location = new System.Drawing.Point(151, 489);
            this.answer3.Name = "answer3";
            this.answer3.Size = new System.Drawing.Size(274, 60);
            this.answer3.TabIndex = 6;
            this.answer3.Text = "answer";
            this.answer3.UseVisualStyleBackColor = true;
            this.answer3.Click += new System.EventHandler(this.Answer3_Click);
            // 
            // answer1
            // 
            this.answer1.Location = new System.Drawing.Point(151, 423);
            this.answer1.Name = "answer1";
            this.answer1.Size = new System.Drawing.Size(274, 60);
            this.answer1.TabIndex = 7;
            this.answer1.Text = "answer";
            this.answer1.UseVisualStyleBackColor = true;
            this.answer1.Click += new System.EventHandler(this.Answer1_Click);
            // 
            // answer2
            // 
            this.answer2.Location = new System.Drawing.Point(431, 423);
            this.answer2.Name = "answer2";
            this.answer2.Size = new System.Drawing.Size(274, 60);
            this.answer2.TabIndex = 8;
            this.answer2.Text = "answer";
            this.answer2.UseVisualStyleBackColor = true;
            this.answer2.Click += new System.EventHandler(this.Answer2_Click);
            // 
            // prev
            // 
            this.prev.Location = new System.Drawing.Point(12, 592);
            this.prev.Name = "prev";
            this.prev.Size = new System.Drawing.Size(119, 60);
            this.prev.TabIndex = 9;
            this.prev.Text = "Previous";
            this.prev.UseVisualStyleBackColor = true;
            this.prev.Click += new System.EventHandler(this.Prev_Click);
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(706, 592);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(119, 60);
            this.next.TabIndex = 10;
            this.next.Text = "Next";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 664);
            this.Controls.Add(this.next);
            this.Controls.Add(this.prev);
            this.Controls.Add(this.answer2);
            this.Controls.Add(this.answer1);
            this.Controls.Add(this.answer3);
            this.Controls.Add(this.answer4);
            this.Controls.Add(this.questionText);
            this.Controls.Add(this.pic);
            this.Name = "Game";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Game_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Label questionText;
        private System.Windows.Forms.Button answer4;
        private System.Windows.Forms.Button answer3;
        private System.Windows.Forms.Button answer1;
        private System.Windows.Forms.Button answer2;
        private System.Windows.Forms.Button prev;
        private System.Windows.Forms.Button next;
    }
}