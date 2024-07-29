using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookSystem.Classes;

namespace BookSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            FillGridView();
            AdjustGridView();
        }
        void AdjustGridView()
        {
            dataGridViewBooks.Columns[0].HeaderText = "BookId";
            dataGridViewBooks.Columns[1].HeaderText = "Title";
            dataGridViewBooks.Columns[2].HeaderText = "ISBN";
            dataGridViewBooks.Columns[3].HeaderText = "Publisher";
            dataGridViewBooks.Columns[4].HeaderText = "Author";
            dataGridViewBooks.Columns[5].HeaderText = "Category";
            dataGridViewBooks.Columns[0].Width = 50;
            dataGridViewBooks.Columns[1].Width = 200;
            dataGridViewBooks.Columns[2].Width = 90;
            dataGridViewBooks.Columns[3].Width = 120;
            dataGridViewBooks.Columns[4].Width = 120;
            dataGridViewBooks.Columns[5].Width = 120;
        }

        void FillGridView()
        {
            BookRepository bookRepository = new BookRepository();
            List<Book> bookList = bookRepository.GetBooks();
            dataGridViewBooks.DataSource = bookList;
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            FillGridView();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            NewBookForm formNewBook = new NewBookForm();
            formNewBook.ShowDialog();
        }

        private void btnOpenEditForm_Click(object sender, EventArgs e)
        {
            EditBook();
        }
        void EditBook()
        {
            int bookId;
            bookId = (int)dataGridViewBooks.CurrentRow.Cells[0].Value;

            EditBookForm formEditBook = new EditBookForm(bookId);
            formEditBook.ShowDialog();
        }
        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            DeleteBook();
        }

        void DeleteBook()
        {
            int bookId;
            bookId = (int)dataGridViewBooks.CurrentRow.Cells[0].Value;
            string? bookTitle = dataGridViewBooks.CurrentRow.Cells[1].Value.ToString();
            string message = "Are you sure that you want to delete the book '" + bookTitle + "'?";
            DialogResult dr = MessageBox.Show(message, "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                BookRepository bookRepository = new BookRepository(); 
                bookRepository.DeleteBook(bookId); 
                FillGridView(); 
            }
        }



    }
}
