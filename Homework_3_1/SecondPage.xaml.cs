using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Homework_3_1
{
    public partial class SecondPage : ContentPage
    {
        public SecondPage()
        {
            InitializeComponent();
        }

        public SecondPage(string userInput)
        {
            InitializeComponent();
            if (userInput == "")
            {
                labelInput.Text = "No text enter";
            }
            else
            {
                labelInput.Text = userInput;
            }
        }
    }
}
