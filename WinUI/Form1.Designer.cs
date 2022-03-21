
namespace WinUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.EnterPetButton = new System.Windows.Forms.Button();
            this.PetNameTextbox = new System.Windows.Forms.TextBox();
            this.SpeciesTextBox = new System.Windows.Forms.TextBox();
            this.AgeTextBox = new System.Windows.Forms.TextBox();
            this.Pets = new System.Windows.Forms.Label();
            this.PetsListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add pet to database";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pet Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Species";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Age";
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(13, 175);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(40, 13);
            this.StatusLabel.TabIndex = 4;
            this.StatusLabel.Text = "Status:";
            // 
            // EnterPetButton
            // 
            this.EnterPetButton.Location = new System.Drawing.Point(25, 133);
            this.EnterPetButton.Name = "EnterPetButton";
            this.EnterPetButton.Size = new System.Drawing.Size(75, 23);
            this.EnterPetButton.TabIndex = 5;
            this.EnterPetButton.Text = "Enter Pet";
            this.EnterPetButton.UseVisualStyleBackColor = true;
            this.EnterPetButton.Click += new System.EventHandler(this.EnterPetButton_Click);
            // 
            // PetNameTextbox
            // 
            this.PetNameTextbox.Location = new System.Drawing.Point(74, 41);
            this.PetNameTextbox.Name = "PetNameTextbox";
            this.PetNameTextbox.Size = new System.Drawing.Size(100, 20);
            this.PetNameTextbox.TabIndex = 6;
            // 
            // SpeciesTextBox
            // 
            this.SpeciesTextBox.Location = new System.Drawing.Point(74, 67);
            this.SpeciesTextBox.Name = "SpeciesTextBox";
            this.SpeciesTextBox.Size = new System.Drawing.Size(100, 20);
            this.SpeciesTextBox.TabIndex = 7;
            // 
            // AgeTextBox
            // 
            this.AgeTextBox.Location = new System.Drawing.Point(74, 93);
            this.AgeTextBox.Name = "AgeTextBox";
            this.AgeTextBox.Size = new System.Drawing.Size(100, 20);
            this.AgeTextBox.TabIndex = 8;
            // 
            // Pets
            // 
            this.Pets.AutoSize = true;
            this.Pets.Location = new System.Drawing.Point(342, 9);
            this.Pets.Name = "Pets";
            this.Pets.Size = new System.Drawing.Size(28, 13);
            this.Pets.TabIndex = 9;
            this.Pets.Text = "Pets";
            // 
            // PetsListBox
            // 
            this.PetsListBox.FormattingEnabled = true;
            this.PetsListBox.Location = new System.Drawing.Point(218, 25);
            this.PetsListBox.Name = "PetsListBox";
            this.PetsListBox.Size = new System.Drawing.Size(272, 134);
            this.PetsListBox.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 197);
            this.Controls.Add(this.PetsListBox);
            this.Controls.Add(this.Pets);
            this.Controls.Add(this.AgeTextBox);
            this.Controls.Add(this.SpeciesTextBox);
            this.Controls.Add(this.PetNameTextbox);
            this.Controls.Add(this.EnterPetButton);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Pet Logger";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Button EnterPetButton;
        private System.Windows.Forms.TextBox PetNameTextbox;
        private System.Windows.Forms.TextBox SpeciesTextBox;
        private System.Windows.Forms.TextBox AgeTextBox;
        private System.Windows.Forms.Label Pets;
        private System.Windows.Forms.ListBox PetsListBox;
    }
}

