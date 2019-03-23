using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using CharpZavertailo2.Annotations;
using CharpZavertailo2.Tools;
using CharpZavertailo2.Tools.Managers;
using CharpZavertailo2.Tools.Navigation;

namespace CharpZavertailo2.ViewModels.Authentication
{
    class PersonFillInfoViewModel : INotifyPropertyChanged
    {
     
        public PersonFillInfoViewModel()
        {
        }
        private DateTime _date = DateTime.Today;
        private string _name;
        private string _surname;
        private string _email;

        private RelayCommand<object> _addUserCommand;
        private ObservableCollection<Person> _users;
        private readonly DataGrid _dataGrid;

        private RelayCommand<object> _deleteRowCommand;
       
        private bool _isBirthdayFilter;
        private bool _isAdultFilter;

        internal PersonFillInfoViewModel(DataGrid dataGrid)
        {
            _users = new ObservableCollection<Person>(Helper.Users);
            _dataGrid = dataGrid;
            _dataGrid.CellEditEnding += CellEdit;
           
        }

        private bool _isAries;
        private bool _isTaurus;
        private bool _isGemini;
        private bool _isCancer;
        private bool _isLeo;
        private bool _isVirgo;
        private bool _isLibra;
        private bool _isScorpio;
        private bool _isSagittarius;
        private bool _isCapricorn;
        private bool _isAquarius;
        private bool _isPisces;

        private bool _isRat;
        private bool _isOx;
        private bool _isTiger;
        private bool _isRabbit;
        private bool _isDragon;
        private bool _isSnake;
        private bool _isHorse;
        private bool _isGoat;
        private bool _isMonkey;
        private bool _isRooster;
        private bool _isDog;
        private bool _isPig;

        public bool IsBirthdayFilter
        {
            get => _isBirthdayFilter;
            set
            {
                _isBirthdayFilter = value;
                OnPropertyChanged();
                OnPropertyChanged("Users");
            }
        }

        public bool IsAdultFilter
        {
            get => _isAdultFilter;
            set
            {
                _isAdultFilter = value;
                OnPropertyChanged();
                OnPropertyChanged("Users");
            }
        }

       public bool IsAquarius
       {
           get => _isAquarius;
           set
            {
                _isAquarius = value;
                OnPropertyChanged();
                OnPropertyChanged("Users");
            }
        }

       public bool IsAries
       {
           get => _isAries;
           set
           {
               _isAries = value;
               OnPropertyChanged();
               OnPropertyChanged("Users");
           }
       }

       public bool IsTaurus
       {
           get => _isTaurus;
           set
           {
               _isTaurus = value;
               OnPropertyChanged();
               OnPropertyChanged("Users");
           }
       }

       public bool IsGemini
       {
           get => _isGemini;
           set
           {
               _isGemini = value;
               OnPropertyChanged();
               OnPropertyChanged("Users");
           }
       }

       public bool IsCancer
       {
           get => _isCancer;
           set
           {
               _isCancer = value;
               OnPropertyChanged();
               OnPropertyChanged("Users");
           }
       }

       public bool IsLeo
       {
           get => _isLeo;
           set
           {
               _isLeo = value;
               OnPropertyChanged();
               OnPropertyChanged("Users");
           }
       }

       public bool IsVirgo
       {
           get => _isVirgo;
           set
           {
               _isVirgo = value;
               OnPropertyChanged();
               OnPropertyChanged("Users");

            }
        }

       public bool IsLibra
       {
           get => _isLibra;
           set
           {
               _isLibra = value;
               OnPropertyChanged();
               OnPropertyChanged("Users");
            }
        }

       public bool IsScorpio
       {
           get => _isScorpio;
           set
           {
               _isScorpio = value;
               OnPropertyChanged();
               OnPropertyChanged("Users");
            }
        }

       public bool IsSagittarius
        {
           get => _isSagittarius;
           set
           {
               _isSagittarius = value;
               OnPropertyChanged();
               OnPropertyChanged("Users");
            }
        }

       public bool IsCapricorn
       {
           get => _isCapricorn;
           set
           {
               _isCapricorn = value;
               OnPropertyChanged();
               OnPropertyChanged("Users");
            }
        }

       public bool IsPisces
       {
           get => _isPisces;
           set
           {
               _isPisces = value;
               OnPropertyChanged();
               OnPropertyChanged("Users");
            }
        }

       public bool IsRat
       {
           get => _isRat;
           set
           {
               _isRat = value;
               OnPropertyChanged();
               OnPropertyChanged("Users");
            }
        }

       public bool IsOx
       {
           get => _isOx;
           set
           {
               _isOx = value;
               OnPropertyChanged();
               OnPropertyChanged("Users");
            }
        }

       public bool IsTiger
       {
           get => _isTiger;
           set
           {
               _isTiger = value;
               OnPropertyChanged();
               OnPropertyChanged("Users");
            }
        }

       public bool IsRabbit
       {
           get => _isRabbit;
           set
           {
               _isRabbit = value;
               OnPropertyChanged();
               OnPropertyChanged("Users");
            }
        }

       public bool IsDragon
       {
           get => _isDragon;
           set
           {
               _isDragon = value;
               OnPropertyChanged();
               OnPropertyChanged("Users");
            }
        }

       public bool IsSnake
       {
           get => _isSnake;
           set
           {
               _isSnake = value;
               OnPropertyChanged();
               OnPropertyChanged("Users");
            }
        }

       public bool IsHorse
       {
           get => _isHorse;
           set
           {
               _isHorse = value;
               OnPropertyChanged();
               OnPropertyChanged("Users");
            }
        }

       public bool IsGoat
       {
           get => _isGoat;
           set
           {
               _isGoat = value;
               OnPropertyChanged();
               OnPropertyChanged("Users");
            }
        }

       public bool IsMonkey
       {
           get => _isMonkey;
           set
           {
               _isMonkey = value;
               OnPropertyChanged();
               OnPropertyChanged("Users");
            }
        }

       public bool IsRooster
       {
           get => _isRooster;
           set
           {
               _isRooster = value;
               OnPropertyChanged();
               OnPropertyChanged("Users");
            }
        }

       public bool IsDog
       {
           get => _isDog;
           set
           {
               _isDog = value;
               OnPropertyChanged();
               OnPropertyChanged("Users");
            }
        }

       public bool IsPig
       {
           get => _isPig;
           set
           {
               _isPig = value;
               OnPropertyChanged();
               OnPropertyChanged("Users");
            }
        }

        public ObservableCollection<Person> Users
        {
            get
            {
                IEnumerable<Person> query = Helper.Users;
                if (IsBirthdayFilter)
                    query = query.Where(x => x.IsBirthday);
                if (IsAdultFilter)
                    query = query.Where(x => x.IsAdult);
                if (IsAquarius)
                {
                    query = query.Where(x => x.SunSign.Contains("Aquarius"));
                }
                if (IsAries)
                {
                    query = query.Where(x => x.SunSign.Contains("Aries"));
                }
                if (IsTaurus)
                {
                    query = query.Where(x => x.SunSign.Contains("Taurus"));
                }
                if (IsGemini)
                {
                    query = query.Where(x => x.SunSign.Contains("Gemini"));
                }
                if (IsCancer)
                {
                    query = query.Where(x => x.SunSign.Contains("Cancer"));
                }
                if (IsLeo)
                {
                    query = query.Where(x => x.SunSign.Contains("Leo"));
                }
                if (IsVirgo)
                {
                    query = query.Where(x => x.SunSign.Contains("Virgo"));
                }
                if (IsLibra)
                {
                    query = query.Where(x => x.SunSign.Contains("Libra"));
                }
                if (IsScorpio)
                {
                    query = query.Where(x => x.SunSign.Contains("Scorpio"));
                }
                if (IsSagittarius)
                {
                    query = query.Where(x => x.SunSign.Contains("Sagittarius"));
                }  
                if (IsCapricorn)
                {
                    query = query.Where(x => x.SunSign.Contains("Capricorn"));
                }
                if (IsPisces)
                {
                    query = query.Where(x => x.SunSign.Contains("Pisces"));
                }
                if (IsRat)
                {
                    query = query.Where(x => x.ChineseSign.Contains("Rat"));
                }
                if (IsOx)
                {
                    query = query.Where(x => x.ChineseSign.Contains("Ox"));
                }
                if (IsTiger)
                {
                    query = query.Where(x => x.ChineseSign.Contains("Tiger"));
                }
                if (IsRabbit)
                {
                    query = query.Where(x => x.ChineseSign.Contains("Rabbit"));
                }
                if (IsDragon)
                {
                    query = query.Where(x => x.ChineseSign.Contains("Dragon"));
                }
                 if (IsSnake)
                {
                    query = query.Where(x => x.ChineseSign.Contains("Snake"));
                }
                 if (IsHorse)
                 {
                     query = query.Where(x => x.ChineseSign.Contains("Horse"));
                 }
                 if (IsGoat)
                 {
                     query = query.Where(x => x.ChineseSign.Contains("Goat"));
                 }
                 if (IsMonkey)
                 {
                     query = query.Where(x => x.ChineseSign.Contains("Monkey"));
                 }
                 if (IsRooster)
                 {
                     query = query.Where(x => x.ChineseSign.Contains("Rooster"));
                 }
                 if (IsDog)
                 {
                     query = query.Where(x => x.ChineseSign.Contains("Dog"));
                 }
                 if (IsPig)
                 {
                     query = query.Where(x => x.ChineseSign.Contains("Pig"));
                 }
                _users = new ObservableCollection<Person>(query);
                return _users;
            }
            set
            {
                _users = value;
                OnPropertyChanged();
            }
        }

        public RelayCommand<object> DeleteCommand
        {
            get { return _deleteRowCommand ?? (_deleteRowCommand = new RelayCommand<object>(DeleteImpl)); }
        }

        public DateTime Date
        {
            get => _date;

            set
            {
                _date = value;
                OnPropertyChanged();
            }
        }

        public string Name
        {
            get => _name;

            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }

        public string Surname
        {
            get => _surname;

            set
            {
                _surname = value;
                OnPropertyChanged();
            }
        }

        public string Email
        {
            get => _email;

            set
            {
                _email = value;
                OnPropertyChanged();
            }
        }

        public RelayCommand<Object> AddUserCommand
        {
            get
            {
                return _addUserCommand ?? (_addUserCommand = new RelayCommand<object>(
                           ProceedImpl, o => IsOk()));
            }
        }

        
        private bool IsOk()
        {
            return !string.IsNullOrWhiteSpace(_email) && !string.IsNullOrWhiteSpace(_name) && !string.IsNullOrWhiteSpace(_surname);
        }

        private async void ProceedImpl(object o)
        {
            LoaderManager.Instance.ShowLoader();
            Person person = null;
            try
            {
                await Task.Run(() =>
                {
                    person = new Person(_name, _surname, _email, _date);
                    
                }
                );

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            if (person != null)
            {
                if (person.IsBirthday)
                {
                    MessageBox.Show(
                        $"Happy B-Day to you, Happy B-Day to you, Happy B-Day dear {_name}, Happy B-Day to you!");
                }
                StationManager.CurrentPerson = person;
                StationManager.CurrentPerson = Helper.CreateUser(_name, _surname, _email, _date);
                if (!_users.Contains(Helper.Users[Helper.Users.Count - 1]))
                    _users.Add(StationManager.CurrentPerson);
                LoaderManager.Instance.HideLoader();
                NavigationManager.Instance.Navigate(ViewType.PersonFillInfo);
                LoaderManager.Instance.HideLoader();

            }
            else
            {
                LoaderManager.Instance.HideLoader();

            }
        }

        private void DeleteImpl(object o)
        {
            Person item = (Person)_dataGrid.SelectedItems[0];
            if (item != null)
            {
                Helper.Users.Remove(item);
                _users.Remove(item);
            }
        }

        void CellEdit(object sender, DataGridCellEditEndingEventArgs e)
        {
            if (e.EditAction == DataGridEditAction.Commit)
            {
                if (e.Column is DataGridBoundColumn column)
                {
                    var bindingPath = (column.Binding as Binding)?.Path.Path;
                    int rowIndex = e.Row.GetIndex();
                    var el = e.EditingElement as TextBox;
                    try
                    {
                        if (el != null)
                        {
                            string value = el.Text;
                            Person person = (Person)_dataGrid.Items.GetItemAt(rowIndex);
                            switch (bindingPath)
                            {
                                case "Name":
                                    person.Name = value;
                                    break;
                                case "Surname":
                                    person.Surname = value;
                                    break;
                                case "Email":
                                    person.Email = value;
                                    break;
                                case "BDateString":
                                    person.BDateString = value;
                                    break;
                                default:
                                    throw new Exception();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        e.Cancel = true;
                    }
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
