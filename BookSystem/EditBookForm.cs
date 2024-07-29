using System;
using System.Windows.Forms;
using BookSystem.Classes;

namespace BookSystem
{
    public partial class EditBookForm : Form
    {
        int selectedBookId;
        public EditBookForm(int bookId)
        {
            InitializeComponent();
            selectedBookId = bookId;
            GetBookData();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            EditBookData();
            GotoMainForm();
        }

        void GetBookData()
        {
            BookRepository bookRepository = new BookRepository();
            Book book = bookRepository.GetBookData(selectedBookId);
            txtTitle.Text = book.Title;
            txtIsbn.Text = book.Isbn;
            txtPublisher.Text = book.PublisherName;
            txtAuthor.Text = book.AuthorName;
            txtCategory.Text = book.CategoryName;
        }

        void EditBookData()
        {
            Book book = new Book
            {
                BookId = selectedBookId,
                Title = txtTitle.Text,
                Isbn = txtIsbn.Text,
                PublisherName = txtPublisher.Text,
                AuthorName = txtAuthor.Text,
                CategoryName = txtCategory.Text
            };

            BookRepository bookRepository = new BookRepository();
            bookRepository.EditBook(book);
        }

        void GotoMainForm()
        {
            this.Close();
        }
    }
}
