﻿using ChuckNorrisAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace ChuckJoke
{
    public partial class Form1 : Form
    {

        //Once you have the project you have two goals
        //Add a button to click that will get a random joke using the API included in the solution
        //Add a dropdown list and display a list of categories in the dropdown when the form first loads, again using the API included in the solution

        public Form1()
        {
            InitializeComponent();
        }

        public async void getJokeBtn_ClickAsync(object sender, EventArgs e)
        {
            Joke joke = await ChuckNorrisClient.GetRandomJoke();

            MessageBox.Show(joke.JokeText);
        }
    }
}
