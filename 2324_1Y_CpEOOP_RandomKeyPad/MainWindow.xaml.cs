using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _2324_1Y_CpEOOP_RandomKeyPad
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<int> _control = new List<int>();
        List<int> _shuffled = new List<int>();
        List<Button> _keys = new List<Button>();
        Random _rnd = new Random();
        string _code = "123456";

        public MainWindow()
        {
            InitializeComponent();

            _keys.Add(btn1);
            _keys.Add(btn2);
            _keys.Add(btn3);
            _keys.Add(btn4);
            _keys.Add(btn5);
            _keys.Add(btn6);
            _keys.Add(btn7);
            _keys.Add(btn8);
            _keys.Add(btn9);
            _keys.Add(btn0);

            Setup();
            ShuffleAndDisplay();
        }

        private void Setup()
        {
            _control.Clear();
            _control.Add(1);
            _control.Add(2);
            _control.Add(3);
            _control.Add(4);
            _control.Add(5);
            _control.Add(6);
            _control.Add(7);
            _control.Add(8);
            _control.Add(9);
            _control.Add(0);
        }

        private void ShuffleAndDisplay()
        {
            int temp = 0;
            _shuffled.Clear();
            while(_control.Count > 0)
            {
                temp = _rnd.Next(_control.Count);
                _shuffled.Add(_control[temp]);
                _control.RemoveAt(temp);
            }

            for(int x = 0; x < _shuffled.Count; x++) 
            {
                _keys[x].Content = _shuffled[x];
            }
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            txtbValue.Text += ((Button)sender).Content.ToString();
            Setup();
            ShuffleAndDisplay();
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtbValue.Text = "";
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            if (txtbValue.Text == _code)
                MessageBox.Show("Welcome");
            else
                txtbValue.Text = "";
        }
    }
}
