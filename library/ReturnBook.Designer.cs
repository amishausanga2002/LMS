namespace library
{
    partial class ReturnBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnBook));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            isbnNo = new TextBox();
            studentID = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(28, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(101, 89);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(227, 38);
            label1.Name = "label1";
            label1.Size = new Size(210, 40);
            label1.TabIndex = 1;
            label1.Text = "Book Return";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(68, 168);
            label2.Name = "label2";
            label2.Size = new Size(141, 25);
            label2.TabIndex = 2;
            label2.Text = "ISBN Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(68, 216);
            label3.Name = "label3";
            label3.Size = new Size(112, 25);
            label3.TabIndex = 3;
            label3.Text = "Student ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(68, 268);
            label4.Name = "label4";
            label4.Size = new Size(114, 25);
            label4.TabIndex = 4;
            label4.Text = "Issue Date";
            // 
            // isbnNo
            // 
            isbnNo.Location = new Point(372, 168);
            isbnNo.Name = "isbnNo";
            isbnNo.Size = new Size(225, 23);
            isbnNo.TabIndex = 6;
            // 
            // studentID
            // 
            studentID.Location = new Point(372, 216);
            studentID.Name = "studentID";
            studentID.Size = new Size(225, 23);
            studentID.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(372, 268);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(225, 23);
            dateTimePicker1.TabIndex = 8;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(599, 392);
            button1.Name = "button1";
            button1.Size = new Size(80, 33);
            button1.TabIndex = 10;
            button1.Text = "Return";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(499, 392);
            button2.Name = "button2";
            button2.Size = new Size(80, 33);
            button2.TabIndex = 11;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            // 
            // ReturnBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(775, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(studentID);
            Controls.Add(isbnNo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Margin = new Padding(2, 1, 2, 1);
            Name = "ReturnBook";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ReturnBook";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox isbnNo;
        private TextBox studentID;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private Button button2;
    }
}