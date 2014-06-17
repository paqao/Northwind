using NorthwndExplorer.ViewModels;
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
using System.Windows.Shapes;

namespace NorthwndExplorer
{
    /// <summary>
    /// Interaction logic for ProductsOnStage.xaml
    /// </summary>
    public partial class ProductsOnStage : Window
    {
        private List<ProductViewModel> viewModels = new List<ProductViewModel>();
        private NORTHWNDEntities1 ctx;
        public ProductsOnStage()
        {
            InitializeComponent();
            ctx  =new NORTHWNDEntities1();
            foreach (Product pr in ctx.Products)
            {
                viewModels.Add(new ProductViewModel(pr));
            }
            this.Produkty.ItemsSource = viewModels;
        }

        private void Pomniejsz_Click(object sender, RoutedEventArgs e)
        {
            using (var transaction =  ctx.Database.BeginTransaction(System.Data.IsolationLevel.ReadCommitted))
            {
                try
                {
                    foreach (ProductViewModel pvm in viewModels)
                    {
                        if (pvm.Quantity == 0)
                            throw new Exception();
                        pvm.Quantity--;
                    }
                    
                    transaction.Commit();
                    ctx.SaveChanges();
                }
                catch(Exception e2){
                    transaction.Rollback();
                }
            }
        }
    }
}
