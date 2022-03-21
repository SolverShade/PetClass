using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogicLibrary.PetChecker
{
    public class PetBuilder
    {
        private Label _statusLabel { get; set; }

        private bool nameValid = false;
        private bool speciesValid = false;
        private bool ageValid = false; 
        public PetBuilder(Label statusLabel) 
        {
            _statusLabel = statusLabel; 
        }

        public string GrabAndCheckName(string name)
        {
            if (name.All(Char.IsLetter))
            {
                nameValid = true;
                return name;
            }
            else
            {
                _statusLabel.Text = "Status: The name you provided included charachters that arent part of the normal alphabet.";
                nameValid = false;
                return "";
            }
        }

        public string GrabAndCheckSpecies(string species)
        {
            if (species.All(Char.IsLetter))
            {
                speciesValid = true;
                return species;
            }
            else
            {
                _statusLabel.Text = "Status: The species you provided included charachters that arent part of the normal alphabet.";
                speciesValid = false;
                return "";
            }
        }

        public int GrabAndCheckAge(string ageText)
        {
            if (ageText.All(Char.IsNumber))
            {
                ageValid = true;
                int.TryParse(ageText, out int age);
                return age;
            }
            else
            {
                _statusLabel.Text = "Status: The Age you provided included charachters that aren't normal whole numbers/integers.";
                ageValid = false;
                return -1;
            }
        }

        public bool AllChecksValid()
        {
            if (nameValid == true && speciesValid == true && ageValid == true)
            {
                _statusLabel.Text = "Status: Success!"; 
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
