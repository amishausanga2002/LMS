namespace library
{
    partial class transactionItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            date = new TextBox();
            isbn = new TextBox();
            title = new TextBox();
            name = new TextBox();
            type = new TextBox();
            id = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // date
            // 
            date.Location = new Point(545, 105);
            date.Name = "date";
            date.ReadOnly = true;
            date.Size = new Size(174, 23);
            date.TabIndex = 23;
            // 
            // isbn
            // 
            isbn.Location = new Point(545, 64);
            isbn.Name = "isbn";
            isbn.ReadOnly = true;
            isbn.Size = new Size(174, 23);
            isbn.TabIndex = 22;
            // 
            // title
            // 
            title.Location = new Point(545, 23);
            title.Name = "title";
            title.ReadOnly = true;
            title.Size = new Size(174, 23);
            title.TabIndex = 21;
            // 
            // name
            // 
            name.Location = new Point(172, 109);
            name.Name = "name";
            name.ReadOnly = true;
            name.Size = new Size(174, 23);
            name.TabIndex = 20;
            // 
            // type
            // 
            type.Location = new Point(172, 64);
            type.Name = "type";
            type.ReadOnly = true;
            type.Size = new Size(174, 23);
            type.TabIndex = 19;
            // 
            // id
            // 
            id.Location = new Point(172, 21);
            id.Name = "id";
            id.ReadOnly = true;
            id.Size = new Size(174, 23);
            id.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(417, 105);
            label6.Name = "label6";
            label6.Size = new Size(42, 21);
            label6.TabIndex = 17;
            label6.Text = "Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(417, 66);
            label5.Name = "label5";
            label5.Size = new Size(106, 21);
            label5.TabIndex = 16;
            label5.Text = "ISBN Number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(417, 23);
            label4.Name = "label4";
            label4.Size = new Size(91, 21);
            label4.TabIndex = 15;
            label4.Text = "Book Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(23, 107);
            label3.Name = "label3";
            label3.Size = new Size(109, 21);
            label3.TabIndex = 14;
            label3.Text = "Student Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(23, 62);
            label2.Name = "label2";
            label2.Size = new Size(125, 21);
            label2.TabIndex = 13;
            label2.Text = "Transaction Type";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(23, 23);
            label1.Name = "label1";
            label1.Size = new Size(108, 21);
            label1.TabIndex = 12;
            label1.Text = "Transaction ID";
            // 
            // transactionItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(date);
            Controls.Add(isbn);
            Controls.Add(title);
            Controls.Add(name);
            Controls.Add(type);
            Controls.Add(id);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "transactionItem";
            Size = new Size(760, 162);
            Load += transactionItem_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox date;
        private TextBox isbn;
        private TextBox title;
        private TextBox name;
        private TextBox type;
        private TextBox id;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
