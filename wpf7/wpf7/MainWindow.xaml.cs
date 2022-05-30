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

namespace wpf7
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void canvas1_Drop(object sender, DragEventArgs e)
        {
            if (e.Source is Canvas)
            {
                TextBlock src = e.Data.GetData(typeof(TextBlock))
                as TextBlock;
                Point p = e.GetPosition(canvas1);
                Canvas.SetLeft(src, p.X - src.ActualWidth / 2);
                Canvas.SetTop(src, p.Y - src.ActualHeight / 2);
            }
            else
            {
                var trg = e.Source as TextBlock;
                var src = e.Data.GetData(typeof(TextBlock)) as TextBlock;
                trg.Background = null;
                if (src == trg)
                    return;
                if ((src.Tag as string)[0] > (trg.Tag as string)[0])
                {
                    Canvas.SetLeft(src, Canvas.GetLeft(trg));
                    Canvas.SetTop(src, Canvas.GetTop(trg));
                    trg.Visibility = Visibility.Hidden;
                }
                else
                    src.Visibility = Visibility.Hidden;
            }
        }

        private void label1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TextBlock t = e.Source as TextBlock;
            if (t == null)
                return;
            t.Foreground = Brushes.Red;
            if (e.ChangedButton == MouseButton.Left)
                if (DragDrop.DoDragDrop(t, t, DragDropEffects.All) == DragDropEffects.None)
                    t.Visibility = Visibility.Hidden;
            t.Foreground = Brushes.Black;
        }

        private void canvas1_DragEnter(object sender, DragEventArgs e)
        {
           
            e.Handled = true;
            e.Effects = DragDropEffects.Move;
            var trg = e.Source as TextBlock;
            if (trg == null)
                return;
            trg.Background = Brushes.Yellow;
        }

        private void grid1_Drop(object sender, DragEventArgs e)
        {
            var trg = e.Source as TextBox;
            if (trg == null)
                return;
            var src = e.Data.GetData(typeof(TextBlock)) as TextBlock;
            if ((src.Tag as string) [0] >= (trg.Tag as string) [0] )
            {
                trg.Text = src.Text;
                trg.Tag = src.Tag;
            }
           
            src.Visibility = Visibility.Hidden;
        }

        private void grid1_PreviewDragEnter(object sender, DragEventArgs e)
        {
            var trg = e.Source as TextBox;
            if (trg == null)
                return;
            e.Handled = true;
            e.Effects = trg.Text == " " ?
                DragDropEffects.Move : DragDropEffects.None;
        }

        private void canvas1_DragLeave(object sender, DragEventArgs e)
        {
            e.Handled = true;
            var trg = e.Source as TextBlock;
            if (trg == null)
                return;
            trg.Background = null;
        }
    }
}
