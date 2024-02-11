namespace library
{
    partial class LibraryForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibraryForm));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ViewBooksBtn = new Button();
            ViewStudentsBtn = new Button();
            AddBooksBtn = new Button();
            AddStudentsBtn = new Button();
            IssueBooksBtn = new Button();
            ReturnBookBtn = new Button();
            TranactionBtn = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(2, 6);
            panel1.Margin = new Padding(2, 1, 2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(804, 54);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(138, 12);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(91, 35);
            label1.TabIndex = 2;
            label1.Text = "Menu";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(5, 1);
            pictureBox1.Margin = new Padding(2, 1, 2, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(62, 52);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(2, 63);
            pictureBox2.Margin = new Padding(2, 1, 2, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(804, 483);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // ViewBooksBtn
            // 
            ViewBooksBtn.BackgroundImage = (Image)resources.GetObject("ViewBooksBtn.BackgroundImage");
            ViewBooksBtn.BackgroundImageLayout = ImageLayout.None;
            ViewBooksBtn.Font = new Font("Microsoft JhengHei UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point);
            ViewBooksBtn.ImageAlign = ContentAlignment.MiddleLeft;
            ViewBooksBtn.Location = new Point(10, 140);
            ViewBooksBtn.Margin = new Padding(2, 1, 2, 1);
            ViewBooksBtn.Name = "ViewBooksBtn";
            ViewBooksBtn.Size = new Size(254, 47);
            ViewBooksBtn.TabIndex = 2;
            ViewBooksBtn.Text = "View Books";
            ViewBooksBtn.UseVisualStyleBackColor = true;
            ViewBooksBtn.Click += button1_Click;
            // 
            // ViewStudentsBtn
            // 
            ViewStudentsBtn.Font = new Font("Microsoft JhengHei UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point);
            ViewStudentsBtn.Image = (Image)resources.GetObject("ViewStudentsBtn.Image");
            ViewStudentsBtn.ImageAlign = ContentAlignment.MiddleLeft;
            ViewStudentsBtn.Location = new Point(10, 410);
            ViewStudentsBtn.Margin = new Padding(2, 1, 2, 1);
            ViewStudentsBtn.Name = "ViewStudentsBtn";
            ViewStudentsBtn.Size = new Size(254, 47);
            ViewStudentsBtn.TabIndex = 3;
            ViewStudentsBtn.Text = "View Students";
            ViewStudentsBtn.UseVisualStyleBackColor = true;
            ViewStudentsBtn.Click += ViewStudentsBtn_Click;
            // 
            // AddBooksBtn
            // 
            AddBooksBtn.Font = new Font("Microsoft JhengHei UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point);
            AddBooksBtn.Image = (Image)resources.GetObject("AddBooksBtn.Image");
            AddBooksBtn.ImageAlign = ContentAlignment.MiddleLeft;
            AddBooksBtn.Location = new Point(10, 302);
            AddBooksBtn.Margin = new Padding(2, 1, 2, 1);
            AddBooksBtn.Name = "AddBooksBtn";
            AddBooksBtn.Size = new Size(254, 47);
            AddBooksBtn.TabIndex = 4;
            AddBooksBtn.Text = "Add Books";
            AddBooksBtn.UseVisualStyleBackColor = true;
            AddBooksBtn.Click += AddBooksBtn_Click;
            // 
            // AddStudentsBtn
            // 
            AddStudentsBtn.Font = new Font("Microsoft JhengHei UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point);
            AddStudentsBtn.Image = (Image)resources.GetObject("AddStudentsBtn.Image");
            AddStudentsBtn.ImageAlign = ContentAlignment.MiddleLeft;
            AddStudentsBtn.Location = new Point(10, 356);
            AddStudentsBtn.Margin = new Padding(2, 1, 2, 1);
            AddStudentsBtn.Name = "AddStudentsBtn";
            AddStudentsBtn.Size = new Size(254, 47);
            AddStudentsBtn.TabIndex = 5;
            AddStudentsBtn.Text = "Add Students";
            AddStudentsBtn.UseVisualStyleBackColor = true;
            AddStudentsBtn.Click += AddStudentsBtn_Click;
            // 
            // IssueBooksBtn
            // 
            IssueBooksBtn.Font = new Font("Microsoft JhengHei UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point);
            IssueBooksBtn.Image = (Image)resources.GetObject("IssueBooksBtn.Image");
            IssueBooksBtn.ImageAlign = ContentAlignment.MiddleLeft;
            IssueBooksBtn.Location = new Point(10, 194);
            IssueBooksBtn.Margin = new Padding(2, 1, 2, 1);
            IssueBooksBtn.Name = "IssueBooksBtn";
            IssueBooksBtn.Size = new Size(254, 47);
            IssueBooksBtn.TabIndex = 6;
            IssueBooksBtn.Text = "Issue Books";
            IssueBooksBtn.UseVisualStyleBackColor = true;
            IssueBooksBtn.Click += button1_Click_1;
            // 
            // ReturnBookBtn
            // 
            ReturnBookBtn.Font = new Font("Microsoft JhengHei UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point);
            ReturnBookBtn.Image = (Image)resources.GetObject("ReturnBookBtn.Image");
            ReturnBookBtn.ImageAlign = ContentAlignment.MiddleLeft;
            ReturnBookBtn.Location = new Point(10, 248);
            ReturnBookBtn.Margin = new Padding(2, 1, 2, 1);
            ReturnBookBtn.Name = "ReturnBookBtn";
            ReturnBookBtn.Size = new Size(254, 47);
            ReturnBookBtn.TabIndex = 7;
            ReturnBookBtn.Text = "Return Book";
            ReturnBookBtn.UseVisualStyleBackColor = true;
            ReturnBookBtn.Click += ReturnBookBtn_Click;
            // 
            // TranactionBtn
            // 
            TranactionBtn.Font = new Font("Microsoft JhengHei UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point);
            TranactionBtn.Image = (Image)resources.GetObject("TranactionBtn.Image");
            TranactionBtn.ImageAlign = ContentAlignment.MiddleLeft;
            TranactionBtn.Location = new Point(10, 464);
            TranactionBtn.Margin = new Padding(2, 1, 2, 1);
            TranactionBtn.Name = "TranactionBtn";
            TranactionBtn.Size = new Size(254, 47);
            TranactionBtn.TabIndex = 8;
            TranactionBtn.Text = "Transactions";
            TranactionBtn.UseVisualStyleBackColor = true;
            TranactionBtn.Click += TranactionBtn_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft JhengHei UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(10, 86);
            button1.Margin = new Padding(2, 1, 2, 1);
            button1.Name = "button1";
            button1.Size = new Size(254, 47);
            button1.TabIndex = 9;
            button1.Text = "Borrowed Books";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_2;
            // 
            // LibraryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(806, 545);
            Controls.Add(button1);
            Controls.Add(TranactionBtn);
            Controls.Add(ReturnBookBtn);
            Controls.Add(IssueBooksBtn);
            Controls.Add(AddStudentsBtn);
            Controls.Add(AddBooksBtn);
            Controls.Add(ViewStudentsBtn);
            Controls.Add(ViewBooksBtn);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Margin = new Padding(2, 1, 2, 1);
            Name = "LibraryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "library";
            Load += LibraryForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button ViewBooksBtn;
        private Button IssueBooksBtn;
        private Button ReturnBookBtn;
        public Button ViewStudentsBtn;
        public Button AddBooksBtn;
        public Button AddStudentsBtn;
        public Button TranactionBtn;
        public Button button1;
    }
}