using RpgCharacterGenarator.Models;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RpgCharacterGenarator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Player> _players = new List<Player>();
        private CharacterManager characterManager;
        public MainWindow()
        {
            InitializeComponent();
            CharacterListView.ItemsSource = _players;
            characterManager = new CharacterManager();
        }

        private void RollAbilityScores_Click(object sender, RoutedEventArgs e)
        {
            int strength = characterManager.RollAbilityScore();
            int intelligence = characterManager.RollAbilityScore();

            StrengthTextBox.Text = strength.ToString();
            IntelligenceTextBox.Text = intelligence.ToString();


        }


        private void ClassComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ClassComboBox.SelectedItem is ComboBoxItem selectedItem)
            {
                string role = selectedItem.Content.ToString();

                if (role == "Fighter")
                {
                    RoleSpecificLabel.Content = "Armor";

                }
                else if (role == "Wizard")
                {
                    RoleSpecificLabel.Content = "Mana";
                }
            }
        }

        private void SaveCharacter_Click(object sender, RoutedEventArgs e)
        {

            // Kontrollera om alla textrutor är ifyllda
            if (string.IsNullOrWhiteSpace(NameTextBox.Text) ||
                string.IsNullOrWhiteSpace(StrengthTextBox.Text) ||
                string.IsNullOrWhiteSpace(IntelligenceTextBox.Text) ||
                string.IsNullOrWhiteSpace(RoleSpecificTextBox.Text) ||
                ClassComboBox.SelectedItem == null)
            {
                // Visa varningsruta om några fält är tomma
                MessageBox.Show("Please fill in all fields before saving the character.", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            string name = NameTextBox.Text;

            bool nameExists = _players.Any(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            if (nameExists)
            {
                MessageBox.Show("A character with this name already exists. Please choose a different name.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            int strength = int.Parse(StrengthTextBox.Text);
            int intelligence = int.Parse(IntelligenceTextBox.Text);


            if (ClassComboBox.SelectedItem is ComboBoxItem selectedItem)
            {
                string role = selectedItem.Content.ToString();

                if (role == "Fighter")
                {
                    int armor = int.Parse(RoleSpecificTextBox.Text);
                    Fighter fighter = new Fighter(name, strength, intelligence, armor);
                    _players.Add(fighter); // Lägg till i listan

                }
                else if (role == "Wizard")
                {
                    int mana = int.Parse(RoleSpecificTextBox.Text);
                    Wizard wizard = new Wizard(name, strength, intelligence, mana);
                    _players.Add(wizard); // Lägg till i listan
                }

                // Uppdatera ListView
                CharacterListView.Items.Refresh();

                NameTextBox.Text = string.Empty;
                StrengthTextBox.Text = string.Empty;
                IntelligenceTextBox.Text = string.Empty;
                RoleSpecificTextBox.Text = string.Empty;



            }
        }
    }
}