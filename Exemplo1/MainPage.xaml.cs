/*
 * Class:
 *      AMOV 2020/2021
 *      
 * Project:
 *      Xamarim Exemplo 1
 * 
 * Authors:
 *      Andre Mendes
 *      Pedro Carvalho
 *      Vasco Patricio
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Exemplo1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        //Button Event
        private void ButtonTextInput_Clicked(object sender, EventArgs e)
        {
            editorTextOutput.Text = editorTextInput.Text;
        }

    }
}
