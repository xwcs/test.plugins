using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xwcs.core.plgs;
using xwcs.core.evt;

namespace Plugin1
{
    public class Plugin1EventType
    {

        public static readonly object Plugin1ToolBarEvent = new object();
    }
    
    public class Plugin1ToolBarEvent : Event
    {
        public Plugin1ToolBarEvent(object sender, object data) : base(sender, Plugin1EventType.Plugin1ToolBarEvent, data)
        {
        }
    }
    
    public class Class1 : IPlugin
    {
        private IPluginHost _host;

        public string name
		{
			get { return "Plugin1"; }
		}

        public int type
        {
            //0 - Visual
            get { return 0; }
        }

        public string guid
        {
            get { return "aed146fa-4b28-4160-a42f-d418aa731d4c";  }
        }

        public DevExpress.XtraEditors.XtraUserControl pluginControl
        {
            get { return new XtraUserControl1(); }
        }

        private void makeButton()
        {
            DevExpress.XtraBars.BarButtonItem barButtonItem = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem.Id = 2800;
            barButtonItem.Tag = guid;
            barButtonItem.Caption = name;
            barButtonItem.ItemClick += buttonClick;

            _host.eventProxy.fireEvent(new AddToolBarRequestEvent(this, new AddToolBarRequest(barButtonItem)));
        }

        private void buttonClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _host.eventProxy.fireEvent(new Plugin1ToolBarEvent(this, "toolbar button clicked"));
        }

        public void init(IPluginHost h)
        {
            _host = h;
            _host.eventProxy.addEventHandler(EventType.GenericEvent, HandleGenericEvent);
            _host.eventProxy.addEventHandler(Plugin1EventType.Plugin1ToolBarEvent, HandlePlugin1ToolBarEvent);

            //send button to main form
            makeButton();
        }

        public void testFireEvent()
		{
            System.Console.WriteLine("Do Something in First Plugin");
            _host.eventProxy.fireEvent(new GenericEvent(this, "Message form first plugin"));
        }

        private void HandleGenericEvent(Event e)
        {
            System.Console.WriteLine("First plugin got event, data : " + e.data);
        }

        private void HandlePlugin1ToolBarEvent(Event e)
        {
            System.Console.WriteLine("Plugin1 got specific event : " + e.data);

            //make all for create user control .....
            _host.eventProxy.fireEvent(new OpenPanelRequestEvent(this, new OpenPanelRequest(DevExpress.XtraBars.Docking.DockingStyle.Bottom, new XtraUserControl1(), guid)));

        }
    }
}
