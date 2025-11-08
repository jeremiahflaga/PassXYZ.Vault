using System.Diagnostics;

namespace PassXYZ.Vault
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        //  NOTE: we can overwrite the CreateWindow method to manage the lifecycle
        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new PxWindow(new MainPage());

            //Window window = new Window(new AppShell());

            //window.Created += (s, e) =>
            //{
            //    Debug.WriteLine("PassXYZ.Vault.App: 1. Created event");
            //};
            //window.Activated += (s, e) =>
            //{
            //    Debug.WriteLine("PassXYZ.Vault.App: 2. Activated event");
            //};
            //window.Deactivated += (s, e) =>
            //{
            //    Debug.WriteLine("PassXYZ.Vault.App: 3. Deactivated event");
            //};
            //window.Stopped += (s, e) =>
            //{
            //    Debug.WriteLine("PassXYZ.Vault.App: 4. Stopped event");
            //};
            //window.Resumed += (s, e) =>
            //{
            //    Debug.WriteLine("PassXYZ.Vault.App: 5. Resumed event");
            //};
            //window.Destroying += (s, e) =>
            //{
            //    Debug.WriteLine("PassXYZ.Vault.App: 6. Destroying event");
            //};

            //return window;
        }
    }
}