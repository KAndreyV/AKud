using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Task07
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


        public void ShowCategoriesButton_Click(object sender, RoutedEventArgs e)
        {
            using (PCContext contextPC = new PCContext())
            {
                string categories = "";
                List<ProductCategory> productCategories = contextPC.ProductCategories.ToList();
                foreach (ProductCategory product_category in productCategories)
                {
                    categories += product_category.Name + "\n";
                }
                OutputTextBox.Text = "Список категорий товаров:\n\n" + categories; 
            }
        }

        public void ShowSubcategoriesButton_Click(object sender, RoutedEventArgs e)
        {
            using (PSContext contextPS = new PSContext())
            {
                string subcategories = "";
                List<ProductSubcategory> productSubcategories = contextPS.ProductSubcategories.ToList();
                foreach (ProductSubcategory product_subcategory in productSubcategories)
                {
                    subcategories += product_subcategory.Name + "\n";
                }
                OutputTextBox.Text = "Список субкатегорий товаров:\n\n" + subcategories;
            }

        }
    }
}