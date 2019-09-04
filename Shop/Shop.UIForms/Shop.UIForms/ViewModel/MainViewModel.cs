namespace Shop.UIForms.ViewModel
{
    public class MainViewModel
    {
        private static MainViewModel instance;

        public LoginViewModel Login { get; set; }

        public ProductsViewModel Products { get; set; }
        public MainViewModel()
        {
            instance = this;
        }

        public static MainViewModel GetInstance()
        {
            return instance == null ? new MainViewModel() : instance;
        }
    }
}
