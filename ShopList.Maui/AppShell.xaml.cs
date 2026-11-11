namespace ShopList.Maui
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            //Registra las rutas de navegacion de las paginas de la aplicaciom

            Routing.RegisterRoute(nameof(Views.EditShopListItemPage), typeof(Views.EditShopListItemPage));
        }
    }
}
