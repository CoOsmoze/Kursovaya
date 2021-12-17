using System.IO;
using System.Windows;
using System.Windows.Media;

using Microsoft.Win32;
using Microsoft.Office.Interop.Word;
using Application = Microsoft.Office.Interop.Word.Application;

namespace Deshifrator
{
  /// <summary>
  /// Логика взаимодействия для MainWindow.xaml
  /// </summary>
  public partial class MainWindow : System.Windows.Window
  { 
    private const string txtFilter = "Text files (*.txt)|*.txt";
    private const string docFilter = "Docx files (*.docx)|*.docx";
    private Application app;

    public MainWindow()
    {
      app = new Application();

      InitializeComponent();
      KeyInput.Text = "скорпион";
      Input.Text = "бщцфаирщри, бл ячъбиуъ щбюэсяёш гфуаа!!!";
    }
    ~MainWindow()
    {
      app.Quit();
    }

    private void SaveDoc(string text)
    {
      Document doc = app.Documents.Add(Visible: false);
      Range range = doc.Range();
      range.Text = text;
      doc.Save();
      doc.Close();
    }

    private string OpenDoc(string path)
    {
      Document doc = app.Documents.Open(path);
      string result = "";
      for (int i = 0; i < doc.Paragraphs.Count; i++)
      {
        result += doc.Paragraphs[i + 1].Range.Text.Trim();
      }
      doc.Close();
      return result;
    }

    private void OpenButton_Click(object sender, RoutedEventArgs e)
    {
      OpenFileDialog ofd = new OpenFileDialog();
      ofd.Filter = txtFilter;
      if (ofd.ShowDialog() == true)
      {
        Input.Text = File.ReadAllText(ofd.FileName);
        Output.Text = "";
      }
    }

    private void SaveButton_Click(object sender, RoutedEventArgs e)
    {
      if (Output.Text.Length == 0)
      {
        MessageBox.Show("Нечего сохранять :(");
        return;
      }
      SaveFileDialog sfd = new SaveFileDialog();
      sfd.Filter = txtFilter;
      if (sfd.ShowDialog() == true)
      {
        File.WriteAllText(sfd.FileName, Output.Text);
      }
    }

    private bool CheckKey()
    {
      if (KeyInput.Text.Length == 0)
      {
        KeyInput.Background = Brushes.LightCoral;
        KeyInput.Focus();
        return false;
      }
      KeyInput.Background = Brushes.WhiteSmoke;
      return true;
    }
    private void DecriptButton_Click(object sender, RoutedEventArgs e)
    {
      if (!CheckKey()) return;
      KeyInput.Background = Brushes.WhiteSmoke;
      Output.Text = Crypto.Decryption(KeyInput.Text, Input.Text);
    }

    private void EncriptButton_Click(object sender, RoutedEventArgs e)
    {
      if (!CheckKey()) return;
      KeyInput.Background = Brushes.WhiteSmoke;
      Output.Text = Crypto.Encrypt(KeyInput.Text, Input.Text);
    }

    private void SaveDocButton_Click(object sender, RoutedEventArgs e)
    {
      if (Output.Text.Length == 0)
      {
        MessageBox.Show("Нечего сохранять :(");
        return;
      }
      SaveDoc(Output.Text);
    }

    private void OpenDocButton_Click(object sender, RoutedEventArgs e)
    {
      OpenFileDialog ofd = new OpenFileDialog();
      ofd.Filter = docFilter;
      if (ofd.ShowDialog() == true)
      {
        Input.Text = OpenDoc(ofd.FileName);
        Output.Text = "";
      }
    }
  }
}
