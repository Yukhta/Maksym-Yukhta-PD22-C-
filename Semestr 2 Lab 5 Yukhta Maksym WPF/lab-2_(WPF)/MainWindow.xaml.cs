using System.Windows;

namespace lab_2__WPF_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ButtonsField bf = new ButtonsField(textBox2);
            bf.drawField(gridForButtons);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text != "")
            {
                comboBox.Items.Add(textBox.Text);
                textBox.Text = "";
            }
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (comboBox.Items.Count != 0)
                comboBox.Items.RemoveAt(comboBox.Items.Count - 1);
            else
                MessageBox.Show("Нічого видаляти", "Комірка пуста");
        }

        private void ComboBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }
    }
}
