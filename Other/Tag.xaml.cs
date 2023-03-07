﻿using Windows.UI.Xaml.Controls;

namespace AccountingApp.Other
{
    public sealed partial class Tag : UserControl
    {
        private string tagName;
        private string key;
        private bool isReadOnlyTag = true;

        public delegate void KeyChanged(Tag tag);
        public event KeyChanged onKeyChanged;

        public event KeyChanged OnKeyChanged
        {
            add => onKeyChanged += value;
            remove => onKeyChanged -= value;
        }

        public string TagName { get => tagName; set => tagName = value; }
        public string Key { get => key; set
            {
                EditBox.IsReadOnly = false;

                key = value;
                EditBox.Text = value;
                EditBox.IsReadOnly = isReadOnlyTag;
            }
        }
        public bool IsReadOnlyTag { get => isReadOnlyTag; set { EditBox.IsReadOnly = value; isReadOnlyTag = value; } }

        public Tag()
        {
            InitializeComponent();
        }

        private void EditBox_LostFocus(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            if (!isReadOnlyTag) onKeyChanged?.Invoke(this);
        }
    }
}