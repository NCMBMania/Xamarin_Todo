using System;
using Xamarin.Forms;

namespace Todo
{
    public partial class TodoItemPage : ContentPage
    {
        public TodoItemPage()
        {
            InitializeComponent();
        }

        async void OnSaveClicked(object sender, EventArgs e)
        {
            var item = (TodoItem)BindingContext;
            var obj = item.GetNCMBObject();
            await obj.SaveAsync();
            await Navigation.PopAsync();
        }

        async void OnDeleteClicked(object sender, EventArgs e)
        {
            var item = (TodoItem)BindingContext;
            var obj = item.GetNCMBObject();
            await obj.DeleteAsync();
            await Navigation.PopAsync();
        }

        async void OnCancelClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
