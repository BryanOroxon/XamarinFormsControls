using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Xamarin.Forms;

namespace Xamarin_Forms_Controls.Views
{
    class SearchBarView : ContentPage
    {
        Label resultsLabel;

        public SearchBarView()
        {
            Label header = new Label
            {
                Text = "SearchBar",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            SearchBar searchBar = new SearchBar
            {
                Placeholder = "Propiedad Xamarin.Forms",
            };
            searchBar.SearchButtonPressed += OnSearchBarButtonPressed;

            resultsLabel = new Label();
            resultsLabel.FontSize = 24;

            this.Content = new StackLayout
            {
                Children =
                {
                    header,
                    searchBar,
                    new ScrollView
                    {
                        Content = resultsLabel,
                        VerticalOptions = LayoutOptions.FillAndExpand
                    }
                }
            };
        }

        void OnSearchBarButtonPressed(object sender, EventArgs args)
        {
            SearchBar searchBar = (SearchBar)sender;
            string searchText = searchBar.Text;

            var list = new List<Tuple<Type, Type>>();
            resultsLabel.Text = string.Empty;

            Assembly xamarinFormsAssembly = typeof(View).GetTypeInfo().Assembly;

            foreach (Type type in xamarinFormsAssembly.ExportedTypes)
            {
                TypeInfo typeInfo = type.GetTypeInfo();

                if (typeInfo.IsPublic)
                {
                    foreach (PropertyInfo property in typeInfo.DeclaredProperties)
                    {
                        if (property.Name.Equals(searchText))
                        {
                            list.Add(Tuple.Create<Type, Type>(type, property.PropertyType));
                        }
                    }
                }
            }

            if (list.Count == 0)
            {
                resultsLabel.Text =
                    String.Format("No hay propiedades Xamarin.Forms con " +
                                  "el nombre {0} ",
                                  searchText);
            }
            else
            {
                resultsLabel.Text = "El ";

                foreach (Tuple<Type, Type> tuple in list)
                {
                    resultsLabel.Text +=
                        String.Format("{0} tipo define una propiedad llamada {1} de tipo {2}",
                                      tuple.Item1.Name, searchText, tuple.Item2.Name);

                    if (tuple != list.Last())
                    {
                        resultsLabel.Text += "; y el ";
                    }
                }

                resultsLabel.Text += ".";
            }
        }
    }
}