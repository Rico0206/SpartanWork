using System;
using System.IO;
using CsvHelper;
using System.Collections.Generic;
using System.Globalization;
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

namespace NetflixDatabase
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        QueryWindow qw = new QueryWindow();
        List<DatabaseElements> elements = new List<DatabaseElements>();
        public MainWindow()
        {
            InitializeComponent();

            
            using (var reader = new StreamReader(@"C:\Users\phant\Documents\Complete\netflixx.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                elements = csv.GetRecords<DatabaseElements>().ToList();
            }

            ShowDatabase.ItemsSource = elements;
            DateTime result;

            foreach (var e in elements)
            {
                DateTime.Parse(e.DateReleased);
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            qw.Show();

            var netflixQuery =
                from element in elements
                where element.Imdb >= 9
                orderby Title descending
                select new 
                { 
                    Id = element.NetflixId, 
                    Title = element.Title,
                    Typ = element.Type, 
                    Rating = element.Imdb,
                    Release_Date = element.DateReleased
                };


            qw.ShowQuery.ItemsSource = netflixQuery;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            qw.Show();

            var netflixQuery =
                from element in elements
                where element.Actors.Contains("Kenya") || element.Actors.Contains("Liam")
                select element;

                qw.ShowQuery.ItemsSource = netflixQuery;
          

            
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            qw.Show();

            var netflixQuery =
                from element in elements
                group element by element.DateReleased into elementGroup
                orderby elementGroup.Key
                select elementGroup;

            foreach (var item in netflixQuery)
            {
                foreach (var ele in item)
                {
                    qw.ShowQuery.ItemsSource = item;
                }
            }

        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            qw.Show();
            var netflixQuery =
                from element in elements
                let imdbRating = element.Imdb
                where imdbRating > 8 && element.Language == "spanish"
                orderby imdbRating descending
                select new
                {
                    Id = element.NetflixId,
                    Title = element.Title,
                    Typ = element.Type,
                    Release = element.TitleReleased,
                    Rating = imdbRating
                };

            qw.ShowQuery.ItemsSource = netflixQuery;


        }
    }
}
