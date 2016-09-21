using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ListView_and_Styling
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();

            MainListView.ItemsSource = new List<Person>
            {

                new Person
                {
                    Name = "Mohamed",
                    Age = 34

                },
                new Person
                {
                    Name = "Mohamed",
                    Age = 34

                },
                new Person
                {
                    Name = "Mohamed",
                    Age = 4

                },
                new Person
                {
                    Name = "Mohamed",
                    Age = 34

                }



            };
        }
    }
}