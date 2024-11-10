using KutuphaneOtomasyon.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace KutuphaneOtomasyon
{
    public partial class LoginForm : Form
    {
        List<Person> persons = new List<Person>();
        List<Book> books = new List<Book>();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            string userName, password = "";
            userName = textBox_userName.Text;
            password = textBox_password.Text;
            bool control = false;
            foreach (Person person in persons)
            {
                if (userName == person.getUserName() && password == person.getPassword() && person.getPermission().ToUpper() == "ADMİN")
                {
                    AdminForm adminForm = new AdminForm(persons,books);
                    adminForm.Show();
                    this.Hide();
                    control = true;
                    break;
                }
                else if (userName == person.getUserName() && password == person.getPassword() && person.getPermission().ToUpper() == "MEMBER")
                {
                    MemberForm memberForm = new MemberForm(books);
                    memberForm.Show();
                    this.Hide();
                    control = true;
                    break;
                }
            }
            if (!control)
            {
                MessageBox.Show("There is an error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_userName.Text = string.Empty;
            textBox_password.Text = string.Empty;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            persons.Add(new Person(1, "Hamza", "Akılotu", DateTime.Now, "Hamza23", "1071", "Admin"));
            persons.Add(new Person(2, "Fatih", "Sultan", DateTime.Now, "Mehmet34", "1453", "Member"));
            books.Add(new Book(1, "İçimizdeki Şeytan", "Sebahattin Ali", "Türkçe", "Yapı Kredi Yayınları", "Roman", 15, 200, 2016));
            books.Add(new Book(2, "Uçurtma Avcısı", "Khaled Hosseini", "İngilizce", "Everest Yayıncılık", "Roman", 25, 150, 2018));
        }
    }
}
