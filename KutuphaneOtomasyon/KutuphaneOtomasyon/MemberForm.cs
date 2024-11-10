using KutuphaneOtomasyon.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyon
{
    public partial class MemberForm : Form
    {
        List<Book> books;
        public MemberForm(List<Book> Books)
        {
            this.books = Books;
            InitializeComponent();
        }

        private void btn_memberQuit_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
            MessageBox.Show("Log Out", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MemberForm_Load(object sender, EventArgs e)
        {
            foreach (Book book in books)
            {
                dataGridView_member.Rows.Add(
                book.getBookİd(),
                book.getBookName(),
                book.getBookWriter(),
                book.getBookLanguage(),
                book.getBookType(),
                book.getPiece(),
                book.getPageCount(),
                book.getPublicationYear(),
                book.getPublisher()
                );
            }
        }

        private void btn_memberSearch_Click(object sender, EventArgs e)
        {
            Book aimBook = null;
            int bookId = Convert.ToInt32(textBox_memberBook.Text);
            bool bookFound = false;
            foreach (Book book in books)
            {
                if (book.getBookİd() == bookId)
                {
                    aimBook = book;
                    bookFound = true;
                    break;
                }
            }

            dataGridView_member.Rows.Clear();
            dataGridView_member.Rows.Add(
                aimBook.getBookİd(),
                aimBook.getBookName(),
                aimBook.getBookWriter(),
                aimBook.getBookLanguage(),
                aimBook.getBookType(),
                aimBook.getPiece(),
                aimBook.getPageCount(),
                aimBook.getPublicationYear(),
                aimBook.getPublisher()
                );

            if (bookFound)
            {
                MessageBox.Show("Found Result : " + aimBook.getBookName() + " by " + aimBook.getBookWriter());
            }
            else
            {
                MessageBox.Show("Book not found with ID: " + bookId);
            }
        }

        private void btn_refreshMember_Click(object sender, EventArgs e)
        {
            dataGridView_member.Rows.Remove(dataGridView_member.CurrentRow);
            foreach (Book aimBook in books)
            {
                dataGridView_member.Rows.Add(
                aimBook.getBookİd(),
                aimBook.getBookName(),
                aimBook.getBookWriter(),
                aimBook.getBookLanguage(),
                aimBook.getBookType(),
                aimBook.getPiece(),
                aimBook.getPageCount(),
                aimBook.getPublicationYear(),
                aimBook.getPublisher()
                );
            }
        }

        private void dataGridView_member_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
