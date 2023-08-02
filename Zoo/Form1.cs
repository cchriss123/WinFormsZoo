using System;
using System.Windows.Forms;
using Zoo.animals;


namespace Zoo
{
    public partial class Form1 : Form
    {

        Zoo zoo = new Zoo("9:00 - 17:00", 100);
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StartTextBoxProperties();
            UpdateTextBoxProperties();
            zoo.AddDefaultVisitors();
            zoo.AddDefaultAnimals();
            UpdateListViewVisitors();
            UpdateListViewAnimals();
            PopulateComboBoxAnimalTypes();
            comboBoxAnimalType.SelectedItem = comboBoxAnimalType.Items[0];

        }


        private void ConfirmEntranceFee_Click_1(object sender, EventArgs e)
        {
            if (!double.TryParse(textBoxFee.Text, out double fee))
            {
                MessageBox.Show("Please enter a valid number for the fee.");
                return;
            }
            zoo.EntranceFee = fee;
            UpdateTextBoxProperties();

        }

        private void ConfirmOpeningHours_Click(object sender, EventArgs e)
        {
            zoo.OpeningHours = textBoxHours.Text;
            UpdateTextBoxProperties();
        }

        private void UpdateTextBoxProperties()
        {
            textBoxProperties.Text = $"Öppettider: {zoo.OpeningHours} | Entréavgift: {zoo.EntranceFee} kr";
        }


        private void StartTextBoxProperties()
        {
            textBoxHours.Text = zoo.OpeningHours;
            textBoxFee.Text = zoo.EntranceFee.ToString();
        }

        private void UpdateListViewVisitors()
        {
            int oldSelectedIndex = listBoxVisitors.SelectedIndex;
            listBoxVisitors.Items.Clear();

            foreach (var visitor in zoo.GetVisitors())
            {
                listBoxVisitors.Items.Add(visitor.Name);
            }
            listBoxVisitors.SelectedIndex = oldSelectedIndex;
        }

        private void ConfirmNewVisitor_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxVisitorName.Text)) // If the textbox is empty or only contains whitespace no visitor will be added
                return;

            Visitor visitor = new Visitor(textBoxVisitorName.Text);

            foreach (var v in zoo.GetVisitors())
            {
                if (v.Name == visitor.Name)
                {
                    MessageBox.Show("Visitor with that name already exists.");
                    return;
                }
            }

            zoo.AddVisitor(visitor);
            UpdateListViewVisitors();
        }

        private void PopulateComboBoxAnimalTypes()
        {
            comboBoxAnimalType.Items.Clear();

            foreach (var animalType in zoo.GetAnimalTypes())
            {
                comboBoxAnimalType.Items.Add(animalType);
            }
        }

        private void confirmAddAnimal_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxAnimalName.Text)) // If the textbox is empty or only contains whitespace no animal will be added
            {
                MessageBox.Show("Please enter a name for the animal.");
                return;
            }
              
            if (comboBoxAnimalType.SelectedItem == null)
            {
                MessageBox.Show("Please select an animal type.");
                return;
            }

            if (!int.TryParse(textBoxAnimalAge.Text, out int age))
            {
                MessageBox.Show("Please enter a valid number for the age.");
                return;
            }

            string animalType = comboBoxAnimalType.SelectedItem.ToString();
            Animal animal = null;

            switch (animalType)
            {
                case "Lion":
                    animal = new Lion(age, textBoxAnimalName.Text);
                    break;
                case "LionCub":
                    animal = new LionCub(age, textBoxAnimalName.Text);
                    break;
                case "Wolf":
                    animal = new Wolf(age, textBoxAnimalName.Text);
                    break;
            }

            foreach (var a in zoo.GetAnimals())
            {
                 if(a.Name == animal.Name)
                 {
                    MessageBox.Show("Animal with that name already exists.");
                    return;
                 }                    
            }

            zoo.AddAnimal(animal);
            UpdateListViewAnimals();
        }

        private void UpdateListViewAnimals()
        {
            int oldSelectedIndex = listBoxAnimals.SelectedIndex;
            listBoxAnimals.Items.Clear();

            foreach (var animal in zoo.GetAnimals())            
                listBoxAnimals.Items.Add(animal.ToString());

            listBoxAnimals.SelectedIndex = oldSelectedIndex; // Needed to avoid index out of range exception after clicking buttonFeed a second time
        }

        private void callZooKeeper_Click(object sender, EventArgs e)
        {
            if (listBoxVisitors.SelectedItem == null)
            {
                MessageBox.Show("Please select a visitor.");
                return;
            }

            if (listBoxAnimals.SelectedItem == null)
            {
                MessageBox.Show("Please select an animal.");
                return;
            }

            Visitor visitor = zoo.GetVisitors()[listBoxVisitors.SelectedIndex];
            Animal animal = zoo.GetAnimals()[listBoxAnimals.SelectedIndex];
            
            textBoxKeeperResponse.Text = zoo.zooKeeper.GetGreeting(visitor, animal);
                               
            buttonFeed.Visible = true;
            buttonInteract.Visible = true;

        }

        private void buttonFeed_Click(object sender, EventArgs e)
        {
           
            Animal animal = zoo.GetAnimals()[listBoxAnimals.SelectedIndex];
            textBoxKeeperResponse.Clear();

            Visitor visitor = zoo.GetVisitors()[listBoxVisitors.SelectedIndex];
            
            textBoxKeeperResponse.AppendText(zoo.zooKeeper.AnnounceFeeding(animal)+"\r\n\r\n");
            textBoxKeeperResponse.AppendText(visitor.feedAnimal(zoo.zooKeeper, animal));

            UpdateListViewAnimals();


        }

        private void buttonInteract_Click(object sender, EventArgs e)
        {
            int oldSelectedIndex = listBoxAnimals.SelectedIndex;

            Animal animal = zoo.GetAnimals()[oldSelectedIndex];
            textBoxKeeperResponse.Clear();
            textBoxKeeperResponse.AppendText(zoo.zooKeeper.InteractWithAnimal(animal));
            UpdateListViewAnimals();
        
        }
    }
}
