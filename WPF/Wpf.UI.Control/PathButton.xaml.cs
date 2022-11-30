using System;
using System.Collections.Generic;
using System.Drawing;
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
using Color = System.Drawing.Color;

namespace Wpf.UI.Control
{
    /// <summary>
    /// PathButton.xaml 的交互逻辑
    /// </summary>
    public partial class PathButton : Button
    {
        public Geometry PathData
        {
            get { return (Geometry)GetValue(PathDataProperty); }
            set { SetValue(PathDataProperty, value); }
        }

        // Using a DependencyProperty as the backing store for PathData.  This enables animation, styling, binding, etc...
         public static readonly DependencyProperty PathDataProperty =
             DependencyProperty.Register("PathData", typeof(Geometry), typeof(PathButton), new PropertyMetadata(new PathGeometry()));
        public System.Windows.Media.Brush PathStrokeBrush
        {
            get { return (System.Windows.Media.Brush)GetValue(PathStrokeBrushProperty); }
            set { SetValue(PathStrokeBrushProperty, value); }
        }

        public static readonly DependencyProperty PathStrokeBrushProperty =
            DependencyProperty.Register("PathStrokeBrushProperty", typeof(System.Windows.Media.Brush), typeof(PathButton), new PropertyMetadata(System.Windows.Media.Brushes.DarkGray));

        public double PathStrokeThickness
        {
            get { return (double)GetValue(PathStrokeThicknessProperty); }
            set { SetValue(PathStrokeThicknessProperty, value); }
        } 

        public static readonly DependencyProperty PathStrokeThicknessProperty =
            DependencyProperty.Register("PathStrokeThickness", typeof(double), typeof(PathButton), new PropertyMetadata(1.0));

        public System.Windows.Media.Brush FillBrush
        {
            get { return (System.Windows.Media.Brush)GetValue(FillBrushProperty); }
            set { SetValue(FillBrushProperty, value); }
        }
        public static readonly DependencyProperty FillBrushProperty =
            DependencyProperty.Register("FillBrush", typeof(System.Windows.Media.Brush), typeof(PathButton), new PropertyMetadata(System.Windows.Media.Brushes.DarkGray));
        public PathButton()
        {
            InitializeComponent();
            DataContext = this;
            PathStrokeThickness = 1.0;
            //System.Windows.Media.Color color = System.Windows.Media.Color.FromArgb(255,255,255,255); 
            //PathStrokeBrush= new SolidColorBrush(color);
            PathStrokeBrush = System.Windows.Media.Brushes.Black;
            FillBrush = System.Windows.Media.Brushes.Blue;
        }
    }
}
