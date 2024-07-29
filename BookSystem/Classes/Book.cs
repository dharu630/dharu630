using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;

namespace BookSystem.Classes
{
    public class Book
    {
        public int BookId { get; set; }
        public string? Title { get; set; }
        public string? Isbn { get; set; }
        public string? PublisherName { get; set; }
        public string? AuthorName { get; set; }
        public string? CategoryName { get; set; }
    }

    public class BookRepository
    {
        string connectionString = "Data Source=FIGHTER;Initial Catalog=Library;Integrated Security=True;TrustServerCertificate=True";

        public List<Book> GetBooks()
        {
            List<Book> bookList = new List<Book>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string selectSQL = @"
                    SELECT 
                        b.BookId, 
                        b.Title, 
                        b.Isbn, 
                        p.PublisherName, 
                        a.AuthorName, 
                        c.CategoryName
                    FROM 
                        BOOK b
                        JOIN PUBLISHER p ON b.PublisherId = p.PublisherId
                        JOIN AUTHOR a ON b.AuthorId = a.AuthorId
                        JOIN CATEGORY c ON b.CategoryId = c.CategoryId";

                SqlCommand cmd = new SqlCommand(selectSQL, con);
                con.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Book book = new Book
                        {
                            BookId = Convert.ToInt32(dr["BookId"]),
                            Title = dr["Title"].ToString(),
                            Isbn = dr["Isbn"].ToString(),
                            PublisherName = dr["PublisherName"].ToString(),
                            AuthorName = dr["AuthorName"].ToString(),
                            CategoryName = dr["CategoryName"].ToString()
                        };
                        bookList.Add(book);
                    }
                }
            }
            return bookList;
        }

        public void CreateBook(Book book)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("CreateBook", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@Title", book.Title);
                cmd.Parameters.AddWithValue("@Isbn", book.Isbn);
                cmd.Parameters.AddWithValue("@PublisherName", book.PublisherName);
                cmd.Parameters.AddWithValue("@AuthorName", book.AuthorName);
                cmd.Parameters.AddWithValue("@CategoryName", book.CategoryName);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        public Book GetBookData(int bookId)
        {
            Book book = new Book();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string selectSQL = @"
                    SELECT 
                        b.BookId, 
                        b.Title, 
                        b.Isbn, 
                        p.PublisherName, 
                        a.AuthorName, 
                        c.CategoryName
                    FROM 
                        BOOK b
                        JOIN PUBLISHER p ON b.PublisherId = p.PublisherId
                        JOIN AUTHOR a ON b.AuthorId = a.AuthorId
                        JOIN CATEGORY c ON b.CategoryId = c.CategoryId
                    WHERE b.BookId = @BookId";

                SqlCommand cmd = new SqlCommand(selectSQL, con);
                cmd.Parameters.AddWithValue("@BookId", bookId);
                con.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        book.BookId = Convert.ToInt32(dr["BookId"]);
                        book.Title = dr["Title"].ToString();
                        book.Isbn = dr["Isbn"].ToString();
                        book.PublisherName = dr["PublisherName"].ToString();
                        book.AuthorName = dr["AuthorName"].ToString();
                        book.CategoryName = dr["CategoryName"].ToString();
                    }
                }
            }
            return book;
        }

        public void EditBook(Book book)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("EditBook", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@BookId", book.BookId);
                cmd.Parameters.AddWithValue("@Title", book.Title);
                cmd.Parameters.AddWithValue("@Isbn", book.Isbn);
                cmd.Parameters.AddWithValue("@PublisherName", book.PublisherName);
                cmd.Parameters.AddWithValue("@AuthorName", book.AuthorName);
                cmd.Parameters.AddWithValue("@CategoryName", book.CategoryName);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        public void DeleteBook(int bookId)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("DeleteBook", con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.AddWithValue("@BookId", bookId);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
               
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
