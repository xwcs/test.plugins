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
using xwcs.core.plgs;
using xwcs.core.evt;

namespace test.plugins
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IPluginHost
    {
        private Dictionary<string, IPlugin> _plugins;
        private EventProxy _proxy;

        public MainWindow()
        {
            InitializeComponent();

            _proxy = new EventProxy();
            _plugins = new Dictionary<string, IPlugin>();
            ICollection<IPlugin> plugins = PluginsLoader<IPlugin>.LoadPlugins("Plugins");
            if (plugins != null)
            {
                foreach (var item in plugins)
                {
                    
                    _plugins.Add(item.name, item);

                    Button b = new Button();
                    b.Content = item.name;
                    b.Click += buttonClick;
                    b.Width = 200;
                    b.Height = 30;
                    MainPanel.Children.Add(b);
                    item.init(this);
                }
            }
        }

        public EventProxy proxy
        {
            get { return _proxy; }
        }

        private void buttonClick(object sender, RoutedEventArgs e)
        {
            Button b = sender as Button;
            if (b != null)
            {
                string key = b.Content.ToString();
                if (_plugins.ContainsKey(key))
                {
                    IPlugin plugin = _plugins[key];
                    plugin.testFireEvent();
                }
            }
        }

    }
}
