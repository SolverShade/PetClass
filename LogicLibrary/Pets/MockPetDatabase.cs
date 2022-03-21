using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogicLibrary.Pets
{
    public class MockPetDatabase
    {
        public List<Pet> pets = new List<Pet>();
        private ListBox _petsDisplay { get; set; }

        public MockPetDatabase(ListBox petsDisplay)
        {
            _petsDisplay = petsDisplay; 
        }

        public void DisplayPets()
        {
            _petsDisplay.Items.Clear();

            foreach(Pet pet in pets)
            {
                _petsDisplay.Items.Add("Name: " + pet.Name);
                _petsDisplay.Items.Add("Species: " + pet.Species);
                _petsDisplay.Items.Add("Age: " + pet.Age);
                _petsDisplay.Items.Add("");
            }
        }
    }
}
