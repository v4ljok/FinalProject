namespace FinalProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblShuffledWord = new Label();
            txtEnteredWord = new TextBox();
            pictureBox1 = new PictureBox();
            btnCheck = new PictureBox();
            btnShuffle = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCheck).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnShuffle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lblShuffledWord
            // 
            lblShuffledWord.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblShuffledWord.BackColor = SystemColors.Info;
            lblShuffledWord.BorderStyle = BorderStyle.Fixed3D;
            lblShuffledWord.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblShuffledWord.Location = new Point(12, 131);
            lblShuffledWord.Name = "lblShuffledWord";
            lblShuffledWord.RightToLeft = RightToLeft.No;
            lblShuffledWord.Size = new Size(254, 39);
            lblShuffledWord.TabIndex = 0;
            lblShuffledWord.Text = "label1";
            lblShuffledWord.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtEnteredWord
            // 
            txtEnteredWord.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtEnteredWord.Location = new Point(12, 274);
            txtEnteredWord.Name = "txtEnteredWord";
            txtEnteredWord.Size = new Size(254, 43);
            txtEnteredWord.TabIndex = 3;
            txtEnteredWord.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-25, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(322, 129);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // btnCheck
            // 
            btnCheck.BackColor = Color.Transparent;
            btnCheck.Cursor = Cursors.Hand;
            btnCheck.Image = (Image)resources.GetObject("btnCheck.Image");
            btnCheck.Location = new Point(38, 323);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(202, 64);
            btnCheck.SizeMode = PictureBoxSizeMode.Zoom;
            btnCheck.TabIndex = 5;
            btnCheck.TabStop = false;
            btnCheck.Click += btnCheck_Click;
            // 
            // btnShuffle
            // 
            btnShuffle.BackColor = Color.Transparent;
            btnShuffle.Cursor = Cursors.Hand;
            btnShuffle.Image = (Image)resources.GetObject("btnShuffle.Image");
            btnShuffle.Location = new Point(12, 194);
            btnShuffle.Name = "btnShuffle";
            btnShuffle.Size = new Size(204, 64);
            btnShuffle.SizeMode = PictureBoxSizeMode.Zoom;
            btnShuffle.TabIndex = 6;
            btnShuffle.TabStop = false;
            btnShuffle.Click += btnShuffle_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(214, 194);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(64, 64);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 399);
            label1.Name = "label1";
            label1.Size = new Size(254, 42);
            label1.TabIndex = 8;
            label1.Text = "label1";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(278, 450);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(btnShuffle);
            Controls.Add(pictureBox1);
            Controls.Add(txtEnteredWord);
            Controls.Add(lblShuffledWord);
            Controls.Add(btnCheck);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCheck).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnShuffle).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblShuffledWord;
        private TextBox txtEnteredWord;
        private PictureBox pictureBox1;
        private PictureBox btnCheck;
        private PictureBox btnShuffle;
        private PictureBox pictureBox2;
        private Label label1;
    }
}