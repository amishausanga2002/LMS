namespace library
{
    partial class IssueBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IssueBook));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            brwdate = new Label();
            memberrid = new Label();
            isbnnumber = new Label();
            dateTimePicker1 = new DateTimePicker();
            memberID = new TextBox();
            isbnnum = new TextBox();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(34, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(68, 73);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(269, 28);
            label1.Name = "label1";
            label1.Size = new Size(221, 40);
            label1.TabIndex = 1;
            label1.Text = "Borrow Book";
            // 
            // brwdate
            // 
            brwdate.AutoSize = true;
            brwdate.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            brwdate.Location = new Point(60, 143);
            brwdate.Name = "brwdate";
            brwdate.Size = new Size(57, 25);
            brwdate.TabIndex = 2;
            brwdate.Text = "Date";
            // 
            // memberrid
            // 
            memberrid.AutoSize = true;
            memberrid.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            memberrid.Location = new Point(60, 196);
            memberrid.Name = "memberrid";
            memberrid.Size = new Size(116, 25);
            memberrid.TabIndex = 3;
            memberrid.Text = "Member ID";
            // 
            // isbnnumber
            // 
            isbnnumber.AutoSize = true;
            isbnnumber.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            isbnnumber.Location = new Point(60, 248);
            isbnnumber.Name = "isbnnumber";
            isbnnumber.Size = new Size(141, 25);
            isbnnumber.TabIndex = 4;
            isbnnumber.Text = "ISBN Number";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(334, 143);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 6;
            // 
            // memberID
            // 
            memberID.Location = new Point(334, 196);
            memberID.Name = "memberID";
            memberID.Size = new Size(200, 23);
            memberID.TabIndex = 7;
            // 
            // isbnnum
            // 
            isbnnum.Location = new Point(334, 250);
            isbnnum.Name = "isbnnum";
            isbnnum.Size = new Size(200, 23);
            isbnnum.TabIndex = 8;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(571, 370);
            button1.Name = "button1";
            button1.Size = new Size(77, 34);
            button1.TabIndex = 10;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(457, 370);
            button2.Name = "button2";
            button2.Size = new Size(77, 34);
            button2.TabIndex = 11;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            // 
            // IssueBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(730, 427);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(isbnnum);
            Controls.Add(memberID);
            Controls.Add(dateTimePicker1);
            Controls.Add(isbnnumber);
            Controls.Add(memberrid);
            Controls.Add(brwdate);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Margin = new Padding(2, 1, 2, 1);
            Name = "IssueBook";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "IssueBook";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label brwdate;
        private Label memberrid;
        private Label isbnnumber;
        private DateTimePicker dateTimePicker1;
        private TextBox memberID;
        private TextBox isbnnum;
        private Button button1;
        private Button button2;
    }
}