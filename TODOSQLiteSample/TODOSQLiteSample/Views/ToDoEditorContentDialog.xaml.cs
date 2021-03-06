﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using TODOSQLiteSample.ViewModels;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace TODOSQLiteSample.Views
{
    public sealed partial class ToDoEditorContentDialog : ContentDialog
    {
        public ToDoEditorContentDialog()
        {
            this.InitializeComponent();
        }

        public event EventHandler<TodoItemViewModel> DeleteTodoItemClicked;

        private void DeleteItemClicked(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
            if (DeleteTodoItemClicked != null)
            {
                DeleteTodoItemClicked(this, (TodoItemViewModel)this.DataContext);
            }
        }
    }
}
