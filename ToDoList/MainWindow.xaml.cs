using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ToDoList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

       

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            btnAdd.IsEnabled = true;
            lstBoxList.Items.Add(txtInput.Text);
            txtInput.Text = "";
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            lstBoxList.Items.Remove(lstBoxList.SelectedItem); // delete the item selected on list menu
            btnDelete.IsEnabled = false; // make the button unclickable.

        }

        private void lstBoxList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            btnDelete.IsEnabled = true;
        }

        private void txtInput_KeyDown(object sender, KeyEventArgs e)
        {
            // if nothing is written in the txt field, then disable add button
            if(txtInput.Text.Length == 0)
            {
                btnAdd.IsEnabled = false;
            }
            // otherwise enable add button and proceed to taking user input and adding to the list
            else
            {
                btnAdd.IsEnabled = true; // enable add button
                if (e.Key == Key.Enter)
                {
                    lstBoxList.Items.Add(txtInput.Text);
                    txtInput.Text = "";
                }
            }
            
        }
    }
}
