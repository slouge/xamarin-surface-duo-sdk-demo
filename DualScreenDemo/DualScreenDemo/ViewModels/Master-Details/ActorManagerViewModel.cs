using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.ObjectModel;
using DualScreenDemo.Contants;

namespace DualScreenDemo.ViewModels
{
    public class ActorManagerViewModel : DualScreenViewModelBase
    {
        private ObservableCollection<ActorViewModel> _items;
        private ActorViewModel _selectedItem;
        private bool _isInitialized;
        private readonly INavigationService _navigationService;

        public ActorManagerViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService ?? throw new ArgumentNullException("navigationService");

            LoadData();
        }

        public ObservableCollection<ActorViewModel> Items
        {
            get
            {
                return _items ?? (_items = new ObservableCollection<ActorViewModel>());
            }
        }

        public ActorViewModel SelectedItem
        {
            get
            {
                return _selectedItem;
            }

            set
            {
                if (Set(ref _selectedItem, value))
                {
                    if (!IsSpanned && value != null)
                    {
                        _navigationService.NavigateTo(PageKeys.DetailsPage, value);
                    }
                }
            }
        }

        private void LoadData()
        {
            if (_isInitialized)
                return;

            #region Initialize Data
            Items.Add(new ActorViewModel(_navigationService)
            {
                Name = "Leonardo DiCaprio",
                Roles = "Acteur, Producteur, Producteur délégué américain",
                Nationality = "Américain",
                BirthDate = new DateTime(1974, 11, 11),
                BirthLocation = "Hollywood, Californie - Etats-Unis",
                Picture = new Uri("http://fr.web.img3.acsta.net/c_240_320/pictures/15/06/24/14/36/054680.jpg"),
                Link = new Uri("http://www.allocine.fr/personne/fichepersonne_gen_cpersonne=12972.html")
            });

            Items.Add(new ActorViewModel(_navigationService)
            {
                Name = "Scarlett Johansson",
                Roles = "Actrice, Réalisatrice, Scénariste américaine",
                Nationality = "Américain",
                BirthDate = new DateTime(1984, 11, 22),
                BirthLocation = "New York, New York - Etats-Unis",
                Picture = new Uri("http://fr.web.img6.acsta.net/c_240_320/pictures/19/03/14/11/10/0992674.jpg"),
                Link = new Uri("http://www.allocine.fr/personne/fichepersonne_gen_cpersonne=27868.html")
            });

            Items.Add(new ActorViewModel(_navigationService)
            {
                Name = "Quentin Tarantino",
                Roles = "Acteur, Réalisateur, Scénariste américain",
                Nationality = "Américain",
                BirthDate = new DateTime(1963, 03, 27),
                BirthLocation = "Knoxville, Tennessee - Etats-Unis",
                Picture = new Uri("http://fr.web.img1.acsta.net/c_240_320/pictures/19/05/22/10/33/5945451.jpg"),
                Link = new Uri("http://www.allocine.fr/personne/fichepersonne_gen_cpersonne=15570.html")
            });


            Items.Add(new ActorViewModel(_navigationService)
            {
                Name = "Clint Eastwood",
                Roles = "Acteur, Réalisateur, Producteur américain",
                Nationality = "Américain",
                BirthDate = new DateTime(1930, 05, 31),
                BirthLocation = "San-Francisco, Californie - Etats-Unis",
                Picture = new Uri("http://fr.web.img6.acsta.net/c_240_320/pictures/15/10/15/16/51/136406.jpg"),
                Link = new Uri("http://www.allocine.fr/personne/fichepersonne_gen_cpersonne=1146.html")
            });

            Items.Add(new ActorViewModel(_navigationService)
            {
                Name = "Alexandra Daddario",
                Roles = "Actrice, Producteur délégué, Productrice américaine",
                Nationality = "Américain",
                BirthDate = new DateTime(1986, 03, 16),
                BirthLocation = "New York City, New York - Etats-Unis",
                Picture = new Uri("http://fr.web.img2.acsta.net/c_240_320/pictures/19/08/09/10/03/3182993.jpg"),
                Link = new Uri("http://www.allocine.fr/personne/fichepersonne_gen_cpersonne=198784.html")
            });

            Items.Add(new ActorViewModel(_navigationService)
            {
                Name = "Will Smith",
                Roles = "Acteur, Producteur, Producteur délégué américain",
                Nationality = "Américain",
                BirthDate = new DateTime(1968, 09, 25),
                BirthLocation = "Philadelphie, Pennsylvanie - Etats-Unis",
                Picture = new Uri("http://fr.web.img1.acsta.net/c_240_320/pictures/20/01/16/09/48/3201727.jpg"),
                Link = new Uri("http://www.allocine.fr/personne/fichepersonne_gen_cpersonne=19358.html")
            });


            Items.Add(new ActorViewModel(_navigationService)
            {
                Name = "Brad Pitt",
                Roles = "Acteur, Producteur, Producteur délégué américain",
                Nationality = "Américain",
                BirthDate = new DateTime(1963, 12, 18),
                BirthLocation = "Shawnee, Oklahoma - Etats-Unis",
                Picture = new Uri("http://fr.web.img6.acsta.net/c_240_320/pictures/20/02/10/10/37/1374948.jpg"),
                Link = new Uri("http://www.allocine.fr/personne/fichepersonne_gen_cpersonne=12302.html")
            });

            Items.Add(new ActorViewModel(_navigationService)
            {
                Name = "Robin Wright",
                Roles = "Actrice, Réalisatrice, Producteur délégué américaine",
                Nationality = "Américain",
                BirthDate = new DateTime(1966, 03, 08),
                BirthLocation = "Dallas, Texas - Etats-Unis",
                Picture = new Uri("http://fr.web.img6.acsta.net/c_240_320/pictures/17/05/18/10/54/541442.jpg"),
                Link = new Uri("http://www.allocine.fr/personne/fichepersonne_gen_cpersonne=8407.html")
            });


            Items.Add(new ActorViewModel(_navigationService)
            {
                Name = "Tom Cruise",
                Roles = "Acteur, Producteur, Producteur délégué américain",
                Nationality = "Américain",
                BirthDate = new DateTime(1962, 07, 03),
                BirthLocation = "Syracuse, Etat de New York - Etats-Unis",
                Picture = new Uri("http://fr.web.img4.acsta.net/c_240_320/pictures/18/07/13/09/57/3777492.jpg"),
                Link = new Uri("http://www.allocine.fr/personne/fichepersonne_gen_cpersonne=1722.html")
            });

            Items.Add(new ActorViewModel(_navigationService)
            {
                Name = "Natalie Portman",
                Roles = "Acteur, Producteur, Producteur délégué américain",
                Nationality = "Américain",
                BirthDate = new DateTime(1981, 06, 09),
                BirthLocation = "Syracuse, Etat de New York - Etats-Unis",
                Picture = new Uri("http://fr.web.img3.acsta.net/c_240_320/pictures/19/09/27/11/45/1268191.jpg"),
                Link = new Uri("http://www.allocine.fr/personne/fichepersonne_gen_cpersonne=18066.html")
            });

            Items.Add(new ActorViewModel(_navigationService)
            {

                Name = "Johnny Depp",
                Roles = "Acteur, Producteur, Réalisateur américain",
                Nationality = "Américain",
                BirthDate = new DateTime(1963, 06, 09),
                BirthLocation = "Owensboro, Kentucky - Etats-Unis",
                Picture = new Uri("http://fr.web.img1.acsta.net/c_240_320/pictures/17/05/19/11/33/566311.jpg"),
                Link = new Uri("http://www.allocine.fr/personne/fichepersonne_gen_cpersonne=12839.html")
            });

            Items.Add(new ActorViewModel(_navigationService)
            {
                Name = "Dwayne Johnson",
                Roles = "Acteur, Producteur, Producteur délégué américain",
                Nationality = "Américain",
                BirthDate = new DateTime(1972, 05, 02),
                BirthLocation = "Hayward, Californie - Etats-Unis",
                Picture = new Uri("http://fr.web.img6.acsta.net/c_240_320/pictures/14/07/24/17/14/366516.jpg"),
                Link = new Uri("http://www.allocine.fr/personne/fichepersonne_gen_cpersonne=38755.html")
            });


            Items.Add(new ActorViewModel(_navigationService)
            {
                Name = "Jake Gyllenhaal",
                Roles = "Acteur, Producteur, Producteur délégué américain",
                Nationality = "Américain",
                BirthDate = new DateTime(1980, 12, 19),
                BirthLocation = "Los Angeles, Californie - Etats-Unis",
                Picture = new Uri("http://fr.web.img1.acsta.net/c_240_320/pictures/17/04/18/16/41/286790.jpg"),
                Link = new Uri("http://www.allocine.fr/personne/fichepersonne_gen_cpersonne=31683.html")
            });

            Items.Add(new ActorViewModel(_navigationService)
            {
                Name = "Tom Hanks",
                Roles = "Acteur, Producteur, Producteur délégué américain",
                Nationality = "Américain",
                BirthDate = new DateTime(1956, 11, 09),
                BirthLocation = "Oakland, Californie - Etats-Unis",
                Picture = new Uri("http://fr.web.img6.acsta.net/c_240_320/pictures/20/01/30/15/03/1454869.jpg"),
                Link = new Uri("http://www.allocine.fr/personne/fichepersonne_gen_cpersonne=14100.html")
            });

            Items.Add(new ActorViewModel(_navigationService)
            {
                Name = "Jennifer Lawrence",
                Roles = "Actrice, Productrice, Réalisatrice américaine",
                Nationality = "Américain",
                BirthDate = new DateTime(1990, 08, 15),
                BirthLocation = "Louisville, Kentucky, Etats-Unis",
                Picture = new Uri("http://fr.web.img3.acsta.net/c_240_320/pictures/15/12/24/11/47/487503.jpg"),
                Link = new Uri("http://www.allocine.fr/personne/fichepersonne_gen_cpersonne=212326.html")
            });
            #endregion

            _isInitialized = true;
        }

        private void ClearSelection()
        {
            if (!IsSpanned)
            {
                SelectedItem = null;
            }
        }

        internal override void OnAppearing()
        {
            base.OnAppearing();

            ClearSelection();
        }

        internal override void OnSpanModeChanged()
        {
            base.OnSpanModeChanged();

            ClearSelection();
        }
    }
}
