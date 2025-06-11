using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace Construction_Managment_Program_System
{
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private bool _isSidebarExpanded;
        public bool IsSidebarExpanded
        {
            get { return _isSidebarExpanded; }
            set
            {
                if (_isSidebarExpanded != value)
                {
                    _isSidebarExpanded = value;
                    OnPropertyChanged(nameof(IsSidebarExpanded));
                }
            }
        }

        // Зберігаємо екземпляри сторінок, щоб не перестворювати їх
        private Pages.DashboardPage _dashboardPage;
        private Pages.PeoplePage _peoplePage;
        private Pages.GradesPage _gradesPage;
        private Pages.WorkPage _workPage;
        private Pages.AccountsPage _accountsPage;
        private Pages.ClientsPage _clientsPage;
        private Pages.ContactsPage _contactsPage;
        private Pages.CommunicationsPage _communicationsPage;
        private Pages.CatalogsPage _catalogsPage;
        private Pages.IntegrationsPage _integrationsPage;
        private Pages.SettingsPage _settingsPage;

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;

            // Ініціалізуємо екземпляри сторінок
            _dashboardPage = new Pages.DashboardPage();
            _peoplePage = new Pages.PeoplePage();
            _gradesPage = new Pages.GradesPage();
            _workPage = new Pages.WorkPage();
            _accountsPage = new Pages.AccountsPage();
            _clientsPage = new Pages.ClientsPage();
            _contactsPage = new Pages.ContactsPage();
            _communicationsPage = new Pages.CommunicationsPage();
            _catalogsPage = new Pages.CatalogsPage();
            _integrationsPage = new Pages.IntegrationsPage();
            _settingsPage = new Pages.SettingsPage();

            // Встановлюємо початковий стан сайдбару як розгорнутий
            IsSidebarExpanded = true;

            // Завантажуємо початкову сторінку (наприклад, Dashboard)
            MainContentArea.Content = _dashboardPage;

            // Встановлюємо початково вибраний елемент у навігаційному списку
            if (NavigationListBox.Items.Count > 0)
            {
                NavigationListBox.SelectedIndex = 0; // Вибираємо перший елемент (Dashboard)
            }
        }

        private void ToggleSidebarButton_Click(object sender, RoutedEventArgs e)
        {
            IsSidebarExpanded = !IsSidebarExpanded;
        }

        private void NavigationListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (NavigationListBox.SelectedItem is ListBoxItem selectedItem)
            {
                string tag = selectedItem.Tag as string;
                // Завантажуємо відповідну сторінку в MainContentArea
                switch (tag)
                {
                    case "Dashboard":
                        MainContentArea.Content = _dashboardPage;
                        break;
                    case "People":
                        MainContentArea.Content = _peoplePage;
                        break;
                    case "Grades":
                        MainContentArea.Content = _gradesPage;
                        break;
                    case "Work":
                        MainContentArea.Content = _workPage;
                        break;
                    case "Accounts":
                        MainContentArea.Content = _accountsPage;
                        break;
                    case "Clients":
                        MainContentArea.Content = _clientsPage;
                        break;
                    case "Contacts":
                        MainContentArea.Content = _contactsPage;
                        break;
                    case "Communications":
                        MainContentArea.Content = _communicationsPage;
                        break;
                    case "Catalogs":
                        MainContentArea.Content = _catalogsPage;
                        break;
                    case "Integrations":
                        MainContentArea.Content = _integrationsPage;
                        break;
                    case "Settings":
                        MainContentArea.Content = _settingsPage;
                        break;
                    default:
                        // Fallback для невідомих тегів
                        MainContentArea.Content = new TextBlock { Text = $"Невідома сторінка: {tag}", HorizontalAlignment = HorizontalAlignment.Center, VerticalAlignment = VerticalAlignment.Center, FontSize = 24, Foreground = System.Windows.Media.Brushes.Red };
                        break;
                }
            }
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Кнопка 'Назад' натиснута!");
            // Тут ви можете додати логіку для навігації назад у стеку сторінок.
        }

        private void ForwardButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Кнопка 'Вперед' натиснута!");
            // Тут ви можете додати логіку для навігації вперед у стеку сторінок.
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}