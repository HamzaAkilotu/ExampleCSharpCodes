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
    public partial class AdminForm : Form
    {
        List<Person> persons;
        List<Book> books;
        public AdminForm(List<Person> persons, List<Book> books)
        {
            InitializeComponent();
            this.persons = persons;
            this.books = books;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            foreach (Person person in persons)
            {
                dataGridView_person.Rows.Add(person.getId(), person.getName(), person.getLastName(), person.getCreationDate(), person.getUserName(), person.getPassword(), person.getPermission());
            }
            foreach (Book book in books)
            {
                dataGridView_book.Rows.Add(book.getBookİd(), book.getBookName(), book.getBookWriter(), book.getBookLanguage(), book.getBookType(), book.getPiece(), book.getPageCount(), book.getPublicationYear(), book.getPublisher());
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            dataGridView_person.Rows.Add(Convert.ToInt32(textBox_id.Text), textBox_name.Text, textBox_lastname.Text, maskedTextBox_creationDate.Text, textBox_userName.Text, textBox_password.Text, textBox_permission.Text);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            dataGridView_person.Rows.Remove(dataGridView_person.CurrentRow);
        }
        public void refreshTextPerson()
        {
            textBox_id.Text = dataGridView_person.CurrentRow.Cells[0].Value.ToString();
            textBox_name.Text = dataGridView_person.CurrentRow.Cells[1].Value.ToString();
            textBox_lastname.Text = dataGridView_person.CurrentRow.Cells[2].Value.ToString();
            maskedTextBox_creationDate.Text = dataGridView_person.CurrentRow.Cells[3].Value.ToString();
            textBox_userName.Text = dataGridView_person.CurrentRow.Cells[4].Value.ToString();
            textBox_password.Text = dataGridView_person.CurrentRow.Cells[5].Value.ToString();
            textBox_permission.Text = dataGridView_person.CurrentRow.Cells[6].Value.ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            refreshTextPerson();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            string id = textBox_id.Text;
            string name = textBox_name.Text;
            string lastname = textBox_lastname.Text;
            string creationDate = maskedTextBox_creationDate.Text;
            string userName = textBox_userName.Text;
            string password = textBox_password.Text;
            string permission = textBox_permission.Text;
            dataGridView_person.Rows.Remove(dataGridView_person.CurrentRow);
            dataGridView_person.Rows.Add(id, name, lastname, creationDate, userName, password, permission);
        }

        private void groupBox_adminForm_Enter(object sender, EventArgs e)
        {

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < groupBox_memberProcesses.Controls.Count; i++)
            {
                if (groupBox_memberProcesses.Controls[i] is TextBox || groupBox_memberProcesses.Controls[i] is MaskedTextBox)
                {
                    groupBox_memberProcesses.Controls[i].Text = string.Empty;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox_permission_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_bookClear_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < groupBox_bookProcesses.Controls.Count; i++)
            {
                if (groupBox_bookProcesses.Controls[i] is TextBox)
                {
                    groupBox_bookProcesses.Controls[i].Text = string.Empty;
                }
            }
        }

        private void btn_bookAdd_Click(object sender, EventArgs e)
        {
            dataGridView_book.Rows.Add(textBox_bookİd.Text, textBox_bookName.Text, textBox_bookWriter.Text, textBox_bookLanguage.Text, textBox_bookType.Text, textBox_bookPageCount.Text, textBox_bookPiece.Text, textBox_publicationYear.Text, textBox_publisher.Text);

        }

        private void btn_bookDelete_Click(object sender, EventArgs e)
        {
            dataGridView_book.Rows.Remove(dataGridView_book.CurrentRow);
        }
        public void refreshTextBook()
        {
            textBox_bookİd.Text = dataGridView_book.CurrentRow.Cells[0].Value.ToString();
            textBox_bookName.Text = dataGridView_book.CurrentRow.Cells[1].Value.ToString();
            textBox_bookWriter.Text = dataGridView_book.CurrentRow.Cells[2].Value.ToString();
            textBox_bookLanguage.Text = dataGridView_book.CurrentRow.Cells[3].Value.ToString();
            textBox_bookType.Text = dataGridView_book.CurrentRow.Cells[4].Value.ToString();
            textBox_publisher.Text = dataGridView_book.CurrentRow.Cells[5].Value.ToString();
            textBox_bookPiece.Text = dataGridView_book.CurrentRow.Cells[6].Value.ToString();
            textBox_publicationYear.Text = dataGridView_book.CurrentRow.Cells[7].Value.ToString();
            textBox_bookPageCount.Text = dataGridView_book.CurrentRow.Cells[8].Value.ToString();
        }
        private void btn_bookRefresh_Click(object sender, EventArgs e)
        {
            string bookİd = textBox_bookİd.Text;
            string bookName = textBox_bookName.Text;
            string bookWriter = textBox_bookWriter.Text;
            string bookLanguage = textBox_bookLanguage.Text;
            string bookType = textBox_bookType.Text;
            string publisher = textBox_publisher.Text;
            string bookPiece = textBox_bookPiece.Text;
            string publicationYear = textBox_publicationYear.Text;
            string pageCount = textBox_bookPageCount.Text;
            dataGridView_book.Rows.Remove(dataGridView_book.CurrentRow);
            dataGridView_book.Rows.Add(bookİd, bookName, bookWriter, bookLanguage, bookType, publisher, publicationYear, bookPiece, pageCount);
        }
        private void dataGridView_book_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            refreshTextBook();
        }

        private void btn_personSearch_Click(object sender, EventArgs e)
        {
            Person aimPerson = null;
            int aimId = Convert.ToInt32(textBox_personSearchId.Text);
            bool personFound = false;
            foreach (Person person in persons)
            {
                if (person.getId() == aimId)
                {
                    aimPerson = person;
                    personFound = true;
                    break;
                }
            }

            dataGridView_person.Rows.Clear();

            if (personFound)
            {
                MessageBox.Show("Found Result : " + aimPerson.getName() + " " + aimPerson.getLastName());
            }
            else
            {
                MessageBox.Show("Person not found with ID: " + aimId);
            }
            dataGridView_person.Rows.Add(aimPerson.getId(), aimPerson.getName(), aimPerson.getLastName(), aimPerson.getCreationDate(), aimPerson.getUserName(), aimPerson.getPassword(), aimPerson.getPermission());
        }

        private void btn_personRefresh_Click(object sender, EventArgs e)
        {
            dataGridView_person.Rows.Remove(dataGridView_person.CurrentRow);
            foreach (Person aimPerson in persons)
            {
                dataGridView_person.Rows.Add(aimPerson.getId(), aimPerson.getName(), aimPerson.getLastName(), aimPerson.getCreationDate(), aimPerson.getUserName(), aimPerson.getPassword(), aimPerson.getPermission());
            }
        }

        private void btn_bookSearch_Click(object sender, EventArgs e)
        {
            Book aimBook = null;
            int aimId = Convert.ToInt32(textBox_bookSearchId.Text);
            bool bookFound = false;
            foreach (Book book in books)
            {
                if (book.getBookİd() == aimId)
                {
                    aimBook = book;
                    bookFound = true;
                    break;
                }
            }

            dataGridView_book.Rows.Clear();

            if (bookFound)
            {
                MessageBox.Show("Found Result : " + aimBook.getBookName() + " by " + aimBook.getBookWriter());
            }
            else
            {
                MessageBox.Show("Book not found with ID: " + aimId);
            }

            dataGridView_book.Rows.Add(
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


        private void btn_refreshBook_Click(object sender, EventArgs e)
        {
            dataGridView_book.Rows.Remove(dataGridView_book.CurrentRow);
            foreach (Book aimBook in books)
            {
                dataGridView_book.Rows.Add(aimBook.getBookİd(), aimBook.getBookName(), aimBook.getBookWriter(), aimBook.getBookLanguage(), aimBook.getBookType(), aimBook.getPiece(), aimBook.getPageCount(), aimBook.getPublicationYear(), aimBook.getPublisher());
            }
        }

        private void btn_adminQuit_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
            MessageBox.Show("Log Out", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
