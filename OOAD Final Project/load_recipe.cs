﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOAD_Final_Project
{
    public partial class load_recipe : Form
    {
        public load_recipe()
        {
            InitializeComponent();
        }

        public load_recipe(server.recipe recipe)
        {
            InitializeComponent();
            string url = recipe.Video_url.Replace("watch?v=", "v/");
            recipeTitle.Text = recipe.Title + " (Tutorial)";
            recipeVideo.Movie = url;
            recipeVideo.Play();
            recipeDescription.Text = recipe.Desc;
        }

        private void exitMenuButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
