using iProject.Model;
using iProject.Model.Enum;
using iProject.View;
using MaterialDesignThemes.Wpf;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Configuration;
using System.Linq;

namespace iProject.ViewModel
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public MainWindowViewModel(ISnackbarMessageQueue snackbarMessageQueue)
        {
            _allItems = GenerateMenuItems(snackbarMessageQueue);
            FilterItems(null);

        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private readonly ObservableCollection<NoviMenuItem> _allItems;
        private ObservableCollection<NoviMenuItem>? _MenuItems;
        private NoviMenuItem? _selectedItem;
        private int _selectedIndex;
        private string? _searchKeyword;

        public string? SearchKeyword
        {
            get => _searchKeyword;
            set
            {
                _searchKeyword = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SearchKeyword)));
                FilterItems(_searchKeyword);
            }
        }

        public ObservableCollection<NoviMenuItem>? MenuItems
        {
            get => _MenuItems;
            set
            {
                _MenuItems = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(MenuItems)));
            }
        }

        public NoviMenuItem? SelectedItem
        {
            get => _selectedItem;
            set
            {
                if (value == null || value.Equals(_selectedItem)) return;

                _selectedItem = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SelectedItem)));
            }
        }

        public int SelectedIndex
        {
            get => _selectedIndex;
            set
            {
                _selectedIndex = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SelectedIndex)));
            }
        }

        private ObservableCollection<NoviMenuItem> GenerateMenuItems(ISnackbarMessageQueue snackbarMessageQueue)
        {
            if (snackbarMessageQueue is null)
                throw new ArgumentNullException(nameof(snackbarMessageQueue));

            return new ObservableCollection<NoviMenuItem>
            {
                new NoviMenuItem("Login", new Login{ DataContext = new LoginViewModel(snackbarMessageQueue)},
                                    new []
                    {
                        DocumentationLink.DemoPageLink<Login>(),
                        DocumentationLink.DemoPageLink<LoginViewModel>("Login View Model")
                    }
                ),
                new NoviMenuItem("Report Actual", new ReportActual { DataContext = new ReportActual() },
                    new []
                    {
                        DocumentationLink.DemoPageLink<ReportActual>("ReportActual View"),
                        DocumentationLink.DemoPageLink<ReportActualViewModel>("ReportActual View Model")
                    }),
                new NoviMenuItem("Sample1", new Sample1(),
                                    new []
                    {
                        DocumentationLink.DemoPageLink<Sample1>()
                    }
                ),
                new NoviMenuItem("Sample Datacontext", new Sample2 { DataContext = new Sample2ViewModel() },
                    new []
                    {
                        DocumentationLink.WikiLink("Brush-Names", "Brushes"),
                        DocumentationLink.WikiLink("Custom-Palette-Hues", "Custom Palettes"),
                        DocumentationLink.WikiLink("Swatches-and-Recommended-Colors", "Swatches"),
                        DocumentationLink.DemoPageLink<Sample2>("Demo View"),
                        DocumentationLink.DemoPageLink<Sample2ViewModel>("Demo View Model"),
                        DocumentationLink.ApiLink<PaletteHelper>()
                    })
                //new MenuItem("Color Tool", new ColorTool { DataContext = new ColorToolViewModel() },
                //    new []
                //    {
                //        DocumentationLink.WikiLink("Brush-Names", "Brushes"),
                //        DocumentationLink.WikiLink("Custom-Palette-Hues", "Custom Palettes"),
                //        DocumentationLink.WikiLink("Swatches-and-Recommended-Colors", "Swatches"),
                //        DocumentationLink.DemoPageLink<ColorTool>("Demo View"),
                //        DocumentationLink.DemoPageLink<ColorToolViewModel>("Demo View Model"),
                //        DocumentationLink.ApiLink<PaletteHelper>()
                //    }),
                //new MenuItem("Buttons", new Buttons { DataContext = new ButtonsViewModel() } ,
                //    new []
                //    {
                //        DocumentationLink.WikiLink("Button-Styles", "Buttons"),
                //        DocumentationLink.DemoPageLink<Buttons>("Demo View"),
                //        DocumentationLink.DemoPageLink<ButtonsViewModel>("Demo View Model"),
                //        DocumentationLink.StyleLink("Button"),
                //        DocumentationLink.StyleLink("PopupBox"),
                //        DocumentationLink.ApiLink<PopupBox>()
                //    })
                //    {
                //        VerticalScrollBarVisibilityRequirement = ScrollBarVisibility.Auto
                //    },
                //new MenuItem("Toggles", new Toggles(),
                //    new []
                //    {
                //        DocumentationLink.DemoPageLink<Toggles>(),
                //        DocumentationLink.StyleLink("ToggleButton"),
                //        DocumentationLink.StyleLink("CheckBox"),
                //        DocumentationLink.ApiLink<Toggles>()
                //    })
                //    {
                //        VerticalScrollBarVisibilityRequirement = ScrollBarVisibility.Auto
                //    },
                //new MenuItem("Rating Bar", new RatingBar(), new []
                //{
                //    DocumentationLink.DemoPageLink<RatingBar>(),
                //    DocumentationLink.StyleLink("RatingBar"),
                //    DocumentationLink.ApiLink<RatingBar>()
                //}),
                //new MenuItem("Fields", new Fields(),
                //    new []
                //    {
                //        DocumentationLink.DemoPageLink<Fields>(),
                //        DocumentationLink.StyleLink("TextBox")
                //    })
                //    {
                //        VerticalScrollBarVisibilityRequirement = ScrollBarVisibility.Auto
                //    },
                //new MenuItem("Fields line up", new FieldsLineUp(), new []
                //{
                //    DocumentationLink.DemoPageLink<FieldsLineUp>()
                //}),
                //new MenuItem("ComboBoxes", new ComboBoxes(),
                //    new []
                //    {
                //        DocumentationLink.DemoPageLink<ComboBoxes>(),
                //        DocumentationLink.StyleLink("ComboBox")
                //    })
                //    {
                //        VerticalScrollBarVisibilityRequirement = ScrollBarVisibility.Auto
                //    },
                //new MenuItem("Pickers", new Pickers { DataContext = new PickersViewModel()},
                //    new []
                //    {
                //        DocumentationLink.DemoPageLink<Pickers>(),
                //        DocumentationLink.StyleLink("Clock"),
                //        DocumentationLink.StyleLink("DatePicker"),
                //        DocumentationLink.ApiLink<TimePicker>()
                //    }),
                //new MenuItem("Sliders", new Sliders(), new []
                //    {
                //        DocumentationLink.DemoPageLink<Sliders>(),
                //        DocumentationLink.StyleLink("Slider")
                //    }),
                //new MenuItem("Chips", new Chips(), new []
                //    {
                //        DocumentationLink.DemoPageLink<Chips>(),
                //        DocumentationLink.StyleLink("Chip"),
                //        DocumentationLink.ApiLink<Chip>()
                //    }),
                //new MenuItem("Typography", new Typography(), new []
                //    {
                //        DocumentationLink.DemoPageLink<Typography>(),
                //        DocumentationLink.StyleLink("TextBlock")
                //    })
                //    {
                //        VerticalScrollBarVisibilityRequirement = ScrollBarVisibility.Auto,
                //        HorizontalScrollBarVisibilityRequirement = ScrollBarVisibility.Auto
                //    },
                //new MenuItem("Cards", new Cards(), new []
                //    {
                //        DocumentationLink.DemoPageLink<Cards>(),
                //        DocumentationLink.StyleLink("Card"),
                //        DocumentationLink.ApiLink<Card>()
                //    })
                //{
                //    VerticalScrollBarVisibilityRequirement = ScrollBarVisibility.Auto
                //},
                //new MenuItem("Icon Pack", new IconPack { DataContext = new IconPackViewModel(snackbarMessageQueue) },
                //    new []
                //    {
                //        DocumentationLink.DemoPageLink<IconPack>("Demo View"),
                //        DocumentationLink.DemoPageLink<IconPackViewModel>("Demo View Model"),
                //        DocumentationLink.ApiLink<PackIcon>()
                //    }),
                //new MenuItem("Colour Zones", new ColorZones(),
                //    new []
                //    {
                //        DocumentationLink.DemoPageLink<ColorZones>(),
                //        DocumentationLink.ApiLink<ColorZone>()
                //    }),
                //new MenuItem("Lists", new Lists { DataContext = new ListsAndGridsViewModel()},
                //    new []
                //    {
                //        DocumentationLink.DemoPageLink<Lists>("Demo View"),
                //        DocumentationLink.DemoPageLink<ListsAndGridsViewModel>("Demo View Model", "Domain"),
                //        DocumentationLink.StyleLink("ListBox"),
                //        DocumentationLink.StyleLink("ListView")
                //    })
                //{
                //    VerticalScrollBarVisibilityRequirement = ScrollBarVisibility.Auto
                //},
                //new MenuItem("Trees", new Trees { DataContext = new TreesViewModel() },
                //    new []
                //    {
                //        DocumentationLink.DemoPageLink<Trees>("Demo View"),
                //        DocumentationLink.DemoPageLink<TreesViewModel>("Demo View Model"),
                //        DocumentationLink.StyleLink("TreeView")
                //    }),
                //new MenuItem("Data Grids", new DataGrids { DataContext = new ListsAndGridsViewModel()},
                //    new []
                //    {
                //        DocumentationLink.DemoPageLink<DataGrids>("Demo View"),
                //        DocumentationLink.DemoPageLink<ListsAndGridsViewModel>("Demo View Model", "Domain"),
                //        DocumentationLink.StyleLink("DataGrid")
                //    }),
                //new MenuItem("Expander", new Expander(),
                //    new []
                //    {
                //        DocumentationLink.DemoPageLink<Expander>(),
                //        DocumentationLink.StyleLink("Expander")
                //    }),
                //new MenuItem("Group Boxes", new GroupBoxes(),
                //    new []
                //    {
                //        DocumentationLink.DemoPageLink<GroupBoxes>(),
                //        DocumentationLink.StyleLink("GroupBox")
                //    }),
                //new MenuItem("Menus & Tool Bars", new MenusAndToolBars(),
                //    new []
                //    {
                //        DocumentationLink.DemoPageLink<MenusAndToolBars>(),
                //        DocumentationLink.StyleLink("Menu"),
                //        DocumentationLink.StyleLink("ToolBar")
                //    }),
                //new MenuItem("Progress Indicators", new Progress(),
                //    new []
                //    {
                //        DocumentationLink.DemoPageLink<Progress>(),
                //        DocumentationLink.StyleLink("ProgressBar")
                //    }),
                //new MenuItem("Navigation Rail", new NavigationRail { DataContext = null},
                //    new []
                //    {
                //        DocumentationLink.DemoPageLink<NavigationRail>("Demo View"),
                //        DocumentationLink.StyleLink("TabControl"),
                //    })
                //{
                //    VerticalScrollBarVisibilityRequirement = ScrollBarVisibility.Auto
                //},
                //new MenuItem("Dialogs", new Dialogs { DataContext = new DialogsViewModel()},
                //    new []
                //    {
                //        DocumentationLink.WikiLink("Dialogs", "Dialogs"),
                //        DocumentationLink.DemoPageLink<Dialogs>("Demo View"),
                //        DocumentationLink.DemoPageLink<DialogsViewModel>("Demo View Model", "Domain"),
                //        DocumentationLink.ApiLink<DialogHost>()
                //    }),
                //new MenuItem("Drawer", new Drawers(),
                //    new []
                //    {
                //        DocumentationLink.DemoPageLink<Drawers>("Demo View"),
                //        DocumentationLink.ApiLink<DrawerHost>()
                //    }),
                //new MenuItem("Snackbar", new Snackbars(),
                //    new []
                //    {
                //        DocumentationLink.WikiLink("Snackbar", "Snackbar"),
                //        DocumentationLink.DemoPageLink<Snackbars>(),
                //        DocumentationLink.StyleLink("Snackbar"),
                //        DocumentationLink.ApiLink<Snackbar>(),
                //        DocumentationLink.ApiLink<ISnackbarMessageQueue>()
                //    }),
                //new MenuItem("Transitions", new Transitions(),
                //    new []
                //    {
                //        DocumentationLink.WikiLink("Transitions", "Transitions"),
                //        DocumentationLink.DemoPageLink<Transitions>(),
                //        DocumentationLink.ApiLink<Transitioner>("Transitions"),
                //        DocumentationLink.ApiLink<TransitionerSlide>("Transitions"),
                //        DocumentationLink.ApiLink<TransitioningContent>("Transitions"),
                //    }),
                //new MenuItem("Shadows", new Shadows(),
                //    new []
                //    {
                //        DocumentationLink.DemoPageLink<Shadows>(),
                //    })
            };
        }

        private void FilterItems(string? keyword)
        {
            var filteredItems =
                string.IsNullOrWhiteSpace(keyword) ?
                _allItems :
                _allItems.Where(i => i.Name.ToLower().Contains(keyword!.ToLower()));

            MenuItems = new ObservableCollection<NoviMenuItem>(filteredItems);
        }
    }
}
