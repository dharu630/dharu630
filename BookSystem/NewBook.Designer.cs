namespace BookSystem
{
    partial class NewBookForm
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
            txtTitle = new Label();
            txtIsbn = new Label();
            txtPublisher = new Label();
            txtAuthor = new Label();
            txtCategory = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            btnOK = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // txtTitle
            // 
            txtTitle.AutoSize = true;
            txtTitle.Location = new Point(29, 38);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(41, 20);
            txtTitle.TabIndex = 0;
            txtTitle.Text = "Title:";
            txtTitle.Click += this.txtTitle_Click;
            // 
            // txtIsbn
            // 
            txtIsbn.AutoSize = true;
            txtIsbn.Location = new Point(29, 101);
            txtIsbn.Name = "txtIsbn";
            txtIsbn.Size = new Size(44, 20);
            txtIsbn.TabIndex = 1;
            txtIsbn.Text = "ISBN:";
            txtIsbn.Click += this.txtIsbn_Click;
            // 
            // txtPublisher
            // 
            txtPublisher.AutoSize = true;
            txtPublisher.Location = new Point(29, 167);
            txtPublisher.Name = "txtPublisher";
            txtPublisher.Size = new Size(72, 20);
            txtPublisher.TabIndex = 2;
            txtPublisher.Text = "Publisher:";
            txtPublisher.Click += this.txtPublisher_Click;
            // 
            // txtAuthor
            // 
            txtAuthor.AutoSize = true;
            txtAuthor.Location = new Point(29, 238);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(57, 20);
            txtAuthor.TabIndex = 3;
            txtAuthor.Text = "Author:";
            txtAuthor.Click += this.txtAuthor_Click;
            // 
            // txtCategory
            // 
            txtCategory.AutoSize = true;
            txtCategory.Location = new Point(32, 308);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(72, 20);
            txtCategory.TabIndex = 4;
            txtCategory.Text = "Category:";
            txtCategory.Click += this.txtCategory_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(29, 61);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(368, 27);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += this.textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(29, 124);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(368, 27);
            textBox2.TabIndex = 6;
            textBox2.TextChanged += this.textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(29, 190);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(359, 27);
            textBox3.TabIndex = 7;
            textBox3.TextChanged += this.textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(29, 261);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(368, 27);
            textBox4.TabIndex = 8;
            textBox4.TextChanged += this.textBox4_TextChanged;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(32, 331);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(365, 27);
            textBox5.TabIndex = 9;
            textBox5.TextChanged += this.textBox5_TextChanged;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(436, 383);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(68, 34);
            btnOK.TabIndex = 10;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(536, 383);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(73, 34);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += this.btnCancel_Click;
            // 
            // NewBookForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(636, 450);
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
            Name = "NewBookForm";
            Text = "NewBook";
            Load += this.NewBookForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtTitle;
        private Label txtIsbn;
        private Label txtPublisher;
        private Label txtAuthor;
        private Label txtCategory;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button btnOK;
        private Button btnCancel;
    }
}