using LogicLibrary.PetChecker;
using LogicLibrary.Pets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinUI
{
    public partial class Form1 : Form
    {
        private PetBuilder petBuilder;
        private MockPetDatabase petDataBase; 
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            petBuilder = new PetBuilder(StatusLabel);
            petDataBase = new MockPetDatabase(PetsListBox);
        }

        private void EnterPetButton_Click(object sender, EventArgs e)
        {
            string petName = petBuilder.GrabAndCheckName(PetNameTextbox.Text);
            string petSpecies = petBuilder.GrabAndCheckSpecies(SpeciesTextBox.Text);
            int petAge = petBuilder.GrabAndCheckAge(AgeTextBox.Text); 

            if(petBuilder.AllChecksValid() == true)
            {
                Pet currentPet = new Pet(petName, petSpecies, petAge);
                petDataBase.pets.Add(currentPet);
                petDataBase.DisplayPets();
            }
        }
    }
}
