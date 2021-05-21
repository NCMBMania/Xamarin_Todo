using System;
using Xamarin.Forms;
using NCMBClient;
using System.Collections.Generic;

namespace Todo
{
    public partial class TodoListPage : ContentPage
    {
        public TodoListPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            var query = new NCMBQuery("TodoItem");
            var todos = await query
                .Limit(100)
                .FetchAllAsync();
            var ary = new List<TodoItem>();
            foreach (var todo in todos)
            {
                var item = new TodoItem();
                item.SetNCMBObject(todo);
                ary.Add(item);
            }
            listView.ItemsSource = ary;
            
        }

        async void OnItemAdded(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TodoItemPage
            {
                BindingContext = new TodoItem()
            });
        }

        async void OnListItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new TodoItemPage
                {
                    BindingContext = e.SelectedItem as TodoItem
                });
            }
        }
    }
}
