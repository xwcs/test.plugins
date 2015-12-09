using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars.Docking;
using xwcs.core.plgs;
using xwcs.core.evt;
using System.Resources;

namespace test.plugins
{
    public partial class Form1 : Form, IPluginHost
    {
        private EventProxy _proxy;
        private Dictionary<string, IPlugin> _plugins;

        public Form1()
        {
            InitializeComponent();

            LoadWorkSpaces();

            _proxy = new EventProxy();
            _proxy.addEventHandler(EventType.AddToolBarRequestEvent, HandleAddToolbarRequestEvent);
            _proxy.addEventHandler(EventType.OpenPanelRequestEvent, HandleOpenPanelRequestEvent);
            _plugins = new Dictionary<string, IPlugin>();
            
            ICollection<IPlugin> plugins = PluginsLoader<IPlugin>.LoadPlugins("Plugins");
            if (plugins != null)
            {
                foreach (var item in plugins)
                {
                    _plugins.Add(item.guid, item);

                    /*
                    DevExpress.XtraBars.BarButtonItem barButtonItem = new DevExpress.XtraBars.BarButtonItem();
                    barButtonItem.Id = 2800;
                    barButtonItem.Tag = item.guid;
                    barButtonItem.Caption = item.name;
                    barButtonItem.ItemClick += buttonClick;
                    */
                    item.init(this);
                   // barSubItem7.AddItem(item.getButton());
                }
            }            
        }

        //private void HandleOpenPanelRequestEvent(OpenPanelRequest e)
        private void HandleOpenPanelRequestEvent(Event e)
        {
            OpenPanelRequest ee = (OpenPanelRequest)e.data;
            DockPanel dockPanel1 = dockManager1.AddPanel(DockingStyle.Bottom);
            dockPanel1.ID = Guid.Parse(ee.guid);
            dockPanel1.Text = "Panel Control " + dockPanel1.ID.ToString();

            DevExpress.XtraEditors.XtraUserControl pluginControl = (DevExpress.XtraEditors.XtraUserControl)ee.control;
            if (pluginControl != null) dockPanel1.ControlContainer.Controls.Add(pluginControl);
        }

        private void HandleAddToolbarRequestEvent(Event e)
        {
            AddToolBarRequest ee = (AddToolBarRequest)e.data;
            barSubItem7.AddItem(ee.button);
        }

        private void LoadWorkSpaces()
        {            
            //workspaceManager1.LoadWorkspace("Paly Space", "ws\\workspace1.xml");
        }

        /*
        private void buttonClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            DevExpress.XtraBars.BarButtonItem b = e.Item as DevExpress.XtraBars.BarButtonItem;
            if (b != null)
            {
                string key = b.Tag.ToString();
                if (_plugins.ContainsKey(key))
                {
                    IPlugin plugin = _plugins[key];
                    DockPanel dockPanel1 = dockManager1.AddPanel(DockingStyle.Top);
                    dockPanel1.ID = Guid.Parse(key);
                    dockPanel1.Text = "Panel Control " + dockPanel1.ID.ToString();

                    DevExpress.XtraEditors.XtraUserControl pluginControl = plugin.pluginControl;
                    if (pluginControl != null) dockPanel1.ControlContainer.Controls.Add(pluginControl);
                }
            }
        }
        */

        public EventProxy eventProxy
        {
            get { return _proxy; }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dockManager1.BeginUpdate();
            DockPanel dockPanel1 = dockManager1.AddPanel(DockingStyle.Top);
            dockPanel1.Text = "Panel 1";
            dockManager1.EndUpdate();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dockManager1.BeginUpdate();
            DockPanel dockPanel1 = dockManager1.AddPanel(DockingStyle.Top);
            dockPanel1.Text = "Panel 1";

            DockPanel dockPanel2 = dockPanel1.AddPanel();
            dockPanel2.Text = "Panel 2";
            DockPanel container = dockPanel1.ParentPanel;
            container.Tabbed = true;

            dockManager1.EndUpdate();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dockManager1.BeginUpdate();
            DockPanel dockPanel1 = dockManager1.AddPanel(DockingStyle.Top);
            dockPanel1.Text = "Panel 2";
            dockManager1.EndUpdate();
        }

        private void dockManager1_Load(object sender, EventArgs e)
        {
            System.Console.WriteLine("dockManager1_BeforeLoadLayout");
            System.Console.WriteLine(dockManager1.Panels.Count.ToString());
            //return;

            foreach(DockPanel panel in dockManager1.Panels)
            {
                string key = panel.ID.ToString();
                System.Console.WriteLine(key);
                if (_plugins.ContainsKey(key))
                {
                    IPlugin plugin = _plugins[key];
                    DevExpress.XtraEditors.XtraUserControl pluginControl = plugin.pluginControl;
                    if (pluginControl != null) panel.ControlContainer.Controls.Add(pluginControl);
                }
            }
        }
    }
}
