using System;
using System.Windows.Forms;
using BookSystem.Classes;

namespace BookSystem
{
    public partial class NewBookForm : Form
    {
        public NewBookForm()
        {
            InitializeComponent();
        }
        void SaveBookData()
        {
            try
            {
                Book book = new Book
                {
                    Title = txtTitle.Text,
                    Isbn = txtIsbn.Text,
                    PublisherName = txtPublisher.Text,
                    AuthorName = txtAuthor.Text,
                    CategoryName = txtCategory.Text
                };

                BookRepository bookRepository = new BookRepository();
                bookRepository.CreateBook(book);

                MessageBox.Show("Book added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding book: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            SaveBookData();
            GotoMainForm();
        }

        
        void GotoMainForm()
        {
            this.Close();
        }
    }
}
