using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControlsCS
{
    public partial class PersonControl : UserControl
    {
        public PersonControl()
        {
            InitializeComponent();
        }

        private Person person;

        public Person Person
        {
            get
            {
                person.FirstName = firstNameTextBox.Text;
                person.LastName = lastNameTextBox.Text;
                person.Age = int.Parse(ageTextBox.Text);
                return person;
            }
            set
            {
                firstNameTextBox.Text = value.FirstName;
                lastNameTextBox.Text = value.LastName;
                ageTextBox.Text = value.Age.ToString();
                person = value;
            }
        }

    }
}
