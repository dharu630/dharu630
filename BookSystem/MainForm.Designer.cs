namespace BookSystem
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            dataGridViewBooks = new DataGridView();
            btnNew = new Button();
            btnOpenEditForm = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewBooks
            // 
            dataGridViewBooks.BackgroundColor = Color.Yellow;
            dataGridViewBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBooks.Location = new Point(72, 99);
            dataGridViewBooks.Margin = new Padding(5, 3, 5, 3);
            dataGridViewBooks.Name = "dataGridViewBooks";
            dataGridViewBooks.RowHeadersWidth = 51;
            dataGridViewBooks.RowTemplate.Height = 29;
            dataGridViewBooks.Size = new Size(816, 283);
            dataGridViewBooks.TabIndex = 0;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(270, 420);
            btnNew.Margin = new Padding(5, 3, 5, 3);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(156, 40);
            btnNew.TabIndex = 1;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnOpenEditForm
            // 
            btnOpenEditForm.Location = new Point(510, 416);
            btnOpenEditForm.Margin = new Padding(5, 3, 5, 3);
            btnOpenEditForm.Name = "btnOpenEditForm";
            btnOpenEditForm.Size = new Size(161, 44);
            btnOpenEditForm.TabIndex = 2;
            btnOpenEditForm.Text = "Edit";
            btnOpenEditForm.UseVisualStyleBackColor = true;
            btnOpenEditForm.Click += btnOpenEditForm_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(746, 415);
            btnDelete.Margin = new Padding(5, 3, 5, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(146, 43);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click_1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(942, 518);
            Controls.Add(btnDelete);
            Controls.Add(btnOpenEditForm);
            Controls.Add(btnNew);
            Controls.Add(dataGridViewBooks);
            Font = new Font("Showcard Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.Black;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 3, 5, 3);
            Name = "MainForm";
            Text = "Library System";
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewBooks;
        private Button btnNew;
        private Button btnOpenEditForm;
        private Button btnDelete;
    }
}