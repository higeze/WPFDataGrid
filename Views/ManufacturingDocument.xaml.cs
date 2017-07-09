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

namespace Mfg
{
    /// <summary>
    /// Interaction logic for UriList.xaml
    /// </summary>
    public partial class ManufacturingDocument : UserControl
    {
        public ManufacturingDocument()
        {
            InitializeComponent();
        }
        //private bool _isRectDragInProg;
        //private void BlockArrow_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        //{
        //    _isRectDragInProg = true;
        //    (sender as UIElement).CaptureMouse();
        //}

        //private void BlockArrow_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        //{
        //    _isRectDragInProg = false;
        //    (sender as UIElement).ReleaseMouseCapture();
        //}

        //private void BlockArrow_MouseMove(object sender, MouseEventArgs e)
        //{
        //    if (!_isRectDragInProg) return;

        //    // get the position of the mouse relative to the Canvas
        //    var mousePos = e.GetPosition(canvas);

        //    // center the rect on the mouse
        //    double left = mousePos.X - ((sender as Microsoft.Expression.Shapes.BlockArrow).ActualWidth / 2);
        //    double top = mousePos.Y - ((sender as Microsoft.Expression.Shapes.BlockArrow).ActualHeight / 2);
        //    Canvas.SetLeft((sender as Microsoft.Expression.Shapes.BlockArrow), left);
        //    Canvas.SetTop((sender as Microsoft.Expression.Shapes.BlockArrow), top);
        //}

    }
}
