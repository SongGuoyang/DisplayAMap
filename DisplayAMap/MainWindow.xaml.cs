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
using Esri.ArcGISRuntime.Geometry;
using Esri.ArcGISRuntime.Mapping;

namespace DisplayAMap
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class App : Application
    {

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            // Note: it is not best practice to store API keys in source code.
            // The API key is referenced here for the convenience of this tutorial.
            Esri.ArcGISRuntime.ArcGISRuntimeEnvironment.ApiKey = "AAPK0a727522755248fda7f620b41990f6fccPEp5xNAdz-iNjZc9m1YQMpaE5OBwuV52IzpQM4RlmS2tuUuNIwMS_W_gcWYC6vg";
        }

    }
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            MapPoint mapCenterPoint = new MapPoint(114.355, 30.473, SpatialReferences.Wgs84);
            MainMapView.SetViewpoint(new Viewpoint(mapCenterPoint, 100000));
        }
    }
}
