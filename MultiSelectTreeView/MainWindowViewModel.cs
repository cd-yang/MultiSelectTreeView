using Prism.Mvvm;
using System.Collections.ObjectModel;

namespace MultiSelectTreeView
{
    class MainWindowViewModel : BindableBase
    {
        public ObservableCollection<TreeItem> TreeData { get; } = new ObservableCollection<TreeItem>();

        public MainWindowViewModel()
        {
            AddTestData();
        }

        private void AddTestData()
        {
            TreeData.Add(new TreeItem
            {
                Data = new Test("1"),
                Children = new ObservableCollection<TreeItem>
                {
                    new TreeItem
                    {
                        Data = new Test("1.1"),
                        Children = new ObservableCollection<TreeItem>
                        {
                            new TreeItem
                            {
                                Data = new Test("1.1.1"),
                            },
                            new TreeItem
                            {
                                Data = new Test("1.1.2"),
                            },
                        }
                    },
                    new TreeItem
                    {
                        Data = new Test("1.2"),
                    }
                }
            });
            TreeData.Add(new TreeItem
            {
                Data = new Test("2"),
                Children = new ObservableCollection<TreeItem>
                {
                    new TreeItem
                    {
                        Data = new Test("2.1"),
                        Children = new ObservableCollection<TreeItem>
                        {
                            new TreeItem
                            {
                                Data = new Test("2.1.1"),
                            },
                            new TreeItem
                            {
                                Data = new Test("2.1.2"),
                            },
                        }
                    },
                    new TreeItem
                    {
                        Data = new Test("2.2"),
                    }
                }
            });
        }
    }

    public class Test
    {
        public string Label { get; set; }

        public Test(string value)
        {
            Label = value;
        }
    }
}
