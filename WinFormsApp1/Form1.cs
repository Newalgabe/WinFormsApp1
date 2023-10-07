namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private List<Person> persons = new List<Person>();

        public Form1()
        {
            InitializeComponent();
        }

        private void AddPersonButton_Click(object sender, EventArgs e)
        {
            string name = NameTextBox.Text;
            string surname = SurnameTextBox.Text;
            int age = int.Parse(AgeTextBox.Text);

            Person person = new Person(name, surname, age);

            persons.Add(person);

            RefreshListBox();

            NameTextBox.Text = "";
            SurnameTextBox.Text = "";
            AgeTextBox.Text = "";
        }

        private void DeletePersonButton_Click(object sender, EventArgs e)
        {
            Person selectedPerson = PersonsListBox.SelectedItem as Person;

            if (selectedPerson != null)
            {
                persons.Remove(selectedPerson);
                RefreshListBox();
            }
        }

        private void RefreshListBox()
        {
            PersonsListBox.Items.Clear();
            foreach (Person p in persons)
            {
                PersonsListBox.Items.Add(p);
            }
        }

        public class Person
        {
            public string Name { get; set; }
            public string Surname { get; set; }
            public int Age { get; set; }

            public Person(string name, string surname, int age)
            {
                Name = name;
                Surname = surname;
                Age = age;
            }

            public override string ToString()
            {
                return $"{Name} {Surname} ({Age})";
            }
        }
    }

}