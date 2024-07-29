namespace BookSystem
{
    partial class EditBookForm
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
            btnCancel = new Button();
            btnOK = new Button();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            txtCategory = new Label();
            txtAuthor = new Label();
            txtPublisher = new Label();
            txtIsbn = new Label();
            txtTitle = new Label();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.IndianRed;
            btnCancel.Location = new Point(452, 393);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(73, 34);
            btnCancel.TabIndex = 23;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnOK
            // 
            btnOK.BackColor = Color.Olive;
            btnOK.Location = new Point(352, 393);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(68, 34);
            btnOK.TabIndex = 22;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = false;
            btnOK.Click += btnOK_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(113, 329);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(365, 27);
            textBox5.TabIndex = 21;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(110, 259);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(368, 27);
            textBox4.TabIndex = 20;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(113, 188);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(365, 27);
            textBox3.TabIndex = 19;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(110, 122);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(368, 27);
            textBox2.TabIndex = 18;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(110, 59);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(368, 27);
            textBox1.TabIndex = 17;
            // 
            // txtCategory
            // 
            txtCategory.AutoSize = true;
            txtCategory.Location = new Point(113, 306);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(72, 20);
            txtCategory.TabIndex = 16;
            txtCategory.Text = "Category:";
            // 
            // txtAuthor
            // 
            txtAuthor.AutoSize = true;
            txtAuthor.Location = new Point(110, 236);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(57, 20);
            txtAuthor.TabIndex = 15;
            txtAuthor.Text = "Author:";
            // 
            // txtPublisher
            // 
            txtPublisher.AutoSize = true;
            txtPublisher.Location = new Point(110, 165);
            txtPublisher.Name = "txtPublisher";
            txtPublisher.Size = new Size(72, 20);
            txtPublisher.TabIndex = 14;
            txtPublisher.Text = "Publisher:";
            // 
            // txtIsbn
            // 
            txtIsbn.AutoSize = true;
            txtIsbn.Location = new Point(110, 99);
            txtIsbn.Name = "txtIsbn";
            txtIsbn.Size = new Size(44, 20);
            txtIsbn.TabIndex = 13;
            txtIsbn.Text = "ISBN:";
            // 
            // txtTitle
            // 
            txtTitle.AutoSize = true;
            txtTitle.Location = new Point(110, 36);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(41, 20);
            txtTitle.TabIndex = 12;
            txtTitle.Text = "Title:";
            // 
            // EditBookForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(551, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(txtCategory);
            Controls.Add(txtAuthor);
            Controls.Add(txtPublisher);
            Controls.Add(txtIsbn);
            Controls.Add(txtTitle);
            ForeColor = Color.Purple;
            Name = "EditBookForm";
            Text = "EditBookForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnOK;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label txtCategory;
        private Label txtAuthor;
        private Label txtPublisher;
        private Label txtIsbn;
        private Label txtTitle;
    }
}