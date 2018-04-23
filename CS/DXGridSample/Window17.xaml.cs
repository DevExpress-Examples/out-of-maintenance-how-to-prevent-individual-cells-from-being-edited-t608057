using System;
using System.Windows;
using System.ComponentModel;
using System.Collections.ObjectModel;
using DevExpress.Xpf.Grid;

namespace DevExpressGrid_Flashing
{
    /// <summary>
    /// Interaction logic for Window17.xaml
    /// </summary>

    public partial class Window17 : Window
    {
        public Window17()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, RoutedEventArgs e)
        {
        }


        private void view_ShowingEditor(object sender, ShowingEditorEventArgs e)
        {
            if (e.Column.FieldName == "Number1")
            {
                e.Cancel  = ((NewTestData)e.Row).MyBool;
            }
        }
      
    }
    public partial class NewTestData : INotifyPropertyChanged
    {
        private DateTime _MyDateTime;
        public DateTime MyDateTime
        {
            get { return _MyDateTime; }
            set
            {
                _MyDateTime = value;
            }
        }

        private bool _MyBool;
        public bool MyBool
        {
            get { return _MyBool; }
            set
            {
                _MyBool = value;
            }
        }
        private bool _MyBool2;
        public bool MyBool2
        {
            get { return false; }
            set
            {
                _MyBool2 = value;
            }
        }
        
        public decimal? Number1 { get; set; }

        private int _number2;
        public int Number2
        {
            get
            {
                return _number2;
            }
            set
            {
                _number2 = value;
                OnPropertyChanged("Number2");
            }
        }

        public string Text1 { get; set; }
        public string Text2 { get; set; }

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        protected void OnPropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
    public class MyData
    {
        public static ObservableCollection<NewTestData> Data
        {
            get {
                ObservableCollection<NewTestData>  list = new ObservableCollection<NewTestData>();
                for (int i = 0; i < 100; i++)
                {
                    list.Add(new NewTestData()
                    {
                        MyDateTime = DateTime.Now,
                        Number1 = i,
                        Number2 = i * 10,
                        Text1 = "row fdfglkj glfdjkgl dfjglkdj flgjlfdkjdflg jdflgjd" + i,
                        Text2 = "ROW " + i,
                    });
                }
                return list;
            }
        }   
    }  
}