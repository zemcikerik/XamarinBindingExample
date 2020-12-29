using System.Collections.Generic;
using Xamarin.Forms;

namespace ExampleApplication
{
    public partial class MainPage : ContentPage
    {
        public IList<Monkey> Monkeys { get; }
        private Monkey _previousMonkey;

        public MainPage()
        {
            InitializeComponent();
            Monkeys = CreateExampleData();
            BindingContext = this;
        }

        private void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem is Monkey monkey)
            {
                if (_previousMonkey != null)
                {
                    _previousMonkey.Name = _previousMonkey.Name.Replace(" (Selected)", string.Empty);
                }

                monkey.Name += " (Selected)";
                _previousMonkey = monkey;
            }
        }

        private static IList<Monkey> CreateExampleData()
        {
            return new List<Monkey>
            {
                new Monkey
                {
                    Name = "Baboon",
                    Location = "Africa & Asia",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fc/Papio_anubis_%28Serengeti%2C_2009%29.jpg/200px-Papio_anubis_%28Serengeti%2C_2009%29.jpg"
                },
                new Monkey
                {
                    Name = "Capuchin Monkey",
                    Location = "Central & South America",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/40/Capuchin_Costa_Rica.jpg/200px-Capuchin_Costa_Rica.jpg"
                },
                new Monkey
                {
                    Name = "Blue Monkey",
                    Location = "Central and East Africa",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/83/BlueMonkey.jpg/220px-BlueMonkey.jpg"
                },
                new Monkey
                {
                    Name = "Squirrel Monkey",
                    Location = "Central & South America",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/20/Saimiri_sciureus-1_Luc_Viatour.jpg/220px-Saimiri_sciureus-1_Luc_Viatour.jpg"
                },
                new Monkey
                {
                    Name = "Golden Lion Tamarin",
                    Location = "Brazil",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/87/Golden_lion_tamarin_portrait3.jpg/220px-Golden_lion_tamarin_portrait3.jpg"
                },
                new Monkey
                {
                    Name = "Howler Monkey",
                    Location = "South America",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/0d/Alouatta_guariba.jpg/200px-Alouatta_guariba.jpg"
                },
                new Monkey
                {
                    Name = "Japanese Macaque",
                    Location = "Japan",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c1/Macaca_fuscata_fuscata1.jpg/220px-Macaca_fuscata_fuscata1.jpg"
                },
                new Monkey
                {
                    Name = "Mandrill",
                    Location = "Southern Cameroon, Gabon, Equatorial Guinea, and Congo",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/75/Mandrill_at_san_francisco_zoo.jpg/220px-Mandrill_at_san_francisco_zoo.jpg"
                },
                new Monkey
                {
                    Name = "Proboscis Monkey",
                    Location = "Borneo",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e5/Proboscis_Monkey_in_Borneo.jpg/250px-Proboscis_Monkey_in_Borneo.jpg"
                },
                new Monkey
                {
                    Name = "Red-shanked Douc",
                    Location = "Vietnam, Laos",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/9f/Portrait_of_a_Douc.jpg/159px-Portrait_of_a_Douc.jpg"
                },
                new Monkey
                {
                    Name = "Gray-shanked Douc",
                    Location = "Vietnam",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/0b/Cuc.Phuong.Primate.Rehab.center.jpg/320px-Cuc.Phuong.Primate.Rehab.center.jpg"
                },
                new Monkey
                {
                    Name = "Golden Snub-nosed Monkey",
                    Location = "China",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c8/Golden_Snub-nosed_Monkeys%2C_Qinling_Mountains_-_China.jpg/165px-Golden_Snub-nosed_Monkeys%2C_Qinling_Mountains_-_China.jpg"
                },
                new Monkey
                {
                    Name = "Black Snub-nosed Monkey",
                    Location = "China",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/59/RhinopitecusBieti.jpg/320px-RhinopitecusBieti.jpg"
                },
                new Monkey
                {
                    Name = "Tonkin Snub-nosed Monkey",
                    Location = "Vietnam",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/9c/Tonkin_snub-nosed_monkeys_%28Rhinopithecus_avunculus%29.jpg/320px-Tonkin_snub-nosed_monkeys_%28Rhinopithecus_avunculus%29.jpg"
                },
                new Monkey
                {
                    Name = "Thomas's Langur",
                    Location = "Indonesia",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/31/Thomas%27s_langur_Presbytis_thomasi.jpg/142px-Thomas%27s_langur_Presbytis_thomasi.jpg"
                },
                new Monkey
                {
                    Name = "Purple-faced Langur",
                    Location = "Sri Lanka",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/02/Semnopithèque_blanchâtre_mâle.JPG/192px-Semnopithèque_blanchâtre_mâle.JPG"
                },
                new Monkey
                {
                    Name = "Gelada",
                    Location = "Ethiopia",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/13/Gelada-Pavian.jpg/320px-Gelada-Pavian.jpg"
                }
            };
        }
    }
}