using PluginContracts;
using Events;

namespace FirstPlugin
{
    public class FirstPlugin : IPlugin
	{
        private IHost _host;

        public FirstPlugin()
        {
        }

        #region IPlugin Members

        public string Name
		{
			get
			{
				return "First Plugin";
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
            System.Console.WriteLine("Do Something in First Plugin");
            _host.proxy.fireEvent(new GenericEvent(this, "message form first"));
        }

        #endregion

        private void HnadleGenericEvent(EventData e)
        {
               System.Console.WriteLine("First plugin : Som tu !!! : " + e.Data);
        }

        private void HandleCloseEvent(EventData e)
        {
            System.Console.WriteLine("First plugin : Close !!! : " + e.Data);
        }
    }
}
