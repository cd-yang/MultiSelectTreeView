using Prism.Mvvm;
using System.Collections.ObjectModel;

namespace MultiSelectTreeView
{
    class TreeItem : BindableBase
    {
        public ObservableCollection<TreeItem> Children { get; set; }

        public object Data { get; set; }

        public bool IsSelected
        {
            get { return isSelected; }
            set { SetProperty(ref isSelected, value); }
        }

        private bool isSelected = true;
    }
}
