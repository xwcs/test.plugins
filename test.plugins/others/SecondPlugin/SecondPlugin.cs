using PluginContracts;
using Events;

namespace SecondPlugin
{
	public class SecondPlugin : IPlugin
	{
        private IHost _host;

        public SecondPlugin()
        {
        }

        #region IPlugin Members

        public string Name
		{
			get
			{
				return "Second Plugin";
			}
		}

        public void Init(IHost h)
        {
            _host = h;
            _host.proxy.addEventHandler(EventKind.GenericEvent, HnadleGenericEvent);
            _host.proxy.addEventHandler(EventKind.CloseEvent, HandleCloseEvent);

        }

        public void Do()
		{
            System.Console.WriteLine("Do Something in Second Plugin");
            _host.proxy.fireEvent(new GenericEvent(this, "message form second"));
        }

        #endregion

        private void HnadleGenericEvent(EventData e)
        {
            System.Console.WriteLine("Second plugin : Som tu !!! : " + e.Data);
        }

        private void HandleCloseEvent(EventData e)
        {
            System.Console.WriteLine("Second plugin : Close !!! : " + e.Data);
        }
    }
}
