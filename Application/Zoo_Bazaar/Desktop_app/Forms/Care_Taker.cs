﻿using Desktop_app.Forms;
using Logic;
using LogicCL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Desktop_app
{
    public partial class Care_Taker : Form
    {
        //String stdDetails = "{0,-15}{1,-20}{2,-20}{3,-20}{4,-20}{5,-20}{6,-20}";
        private Zookeeper zookeeper;
        public Care_Taker(User loggedInUser)
        {
            zookeeper = (Zookeeper)loggedInUser;
            zookeeper.MakeActive();
            InitializeComponent();
            this.Size = new Size(1521, 910);
            refreshAnimalList();
        }

        private void refreshAnimalList()
        {
            lv_Animals.Items.Clear();
            foreach (Animal animal in zookeeper.Repository.GetAnimalList())
            {
                var animalInfo = new ListViewItem(new[] { animal.Name, animal.Birthdate, animal.Type, animal.Species, animal.Location, animal.BirthPlace });
                animalInfo.Tag = animal.Id.ToString();
                lv_Animals.Items.Add(animalInfo);
            }
        }

        

       

        private void button1_Click(object sender, EventArgs e)
        {

            refreshAnimalList();
        }

        private void btn_details_zookeeper_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            List<Animal> animalList = zookeeper.Repository.GetAnimalList().OfType<Animal>().ToList();

            Animal selectedAnimal = animalList.Find(employee => employee.Id == Convert.ToInt32(lv_Animals.SelectedItems[0].Tag));
            Detail_ZooKeeper detail_ZooKeeper = new Detail_ZooKeeper(zookeeper, selectedAnimal);
            detail_ZooKeeper.ShowDialog();
            if (detail_ZooKeeper.DialogResult == DialogResult.OK)
            {
                detail_ZooKeeper.Dispose();
            }
            else if (detail_ZooKeeper.DialogResult == DialogResult.Cancel)
            {
                detail_ZooKeeper.Dispose();
            }
            this.Show();
        }

     

        private void lv_Animals_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (lv_Animals.SelectedItems.Count > 0)
            {
                List<Animal> animalList = zookeeper.Repository.GetAnimalList().OfType<Animal>().ToList();

                Animal selectedAnimal = animalList.Find(employee => employee.Id == Convert.ToInt32(lv_Animals.SelectedItems[0].Tag));

                

                //Animal
                //selectedEmployeeId = Convert.ToInt32(lv_Animals.SelectedItems[0].Tag);
                TB_Name.Text = selectedAnimal.Name;
                TB_BirthDate.Value = DateTime.Parse(selectedAnimal.Birthdate);
                TB_Father.Text = selectedAnimal.FatherId.ToString();
                TB_Mother.Text = selectedAnimal.Mother.ToString();
                TB_BirthPlace.Text =selectedAnimal.BirthPlace;

                //Category
                TB_Species.Text = selectedAnimal.Species;
                TB_Location.Text = selectedAnimal.Location;
                TB_Diet.Text = selectedAnimal.Diet;
                TB_Type.Text = selectedAnimal.Type;

                //Condition
                TB_Health.Text = selectedAnimal.Sick.ToString();
                TB_Notes.Text = selectedAnimal.Notes;
               
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btn_ViewDetails_Click(object sender, EventArgs e)
        {

        }

        private void Overview_Click(object sender, EventArgs e)
        {

        }
    }
}