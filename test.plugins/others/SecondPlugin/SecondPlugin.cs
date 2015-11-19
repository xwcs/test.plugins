using xwcs.core.plgs;
using xwcs.core.evt;

namespace SecondPlugin
{
	public class SecondPlugin : IPlugin
	{
        private IPluginHost _host;

        public SecondPlugin()
        {
        }

        #region IPlugin Members

        public string name
		{
			get
			{
				return "Second Plugin";
			}
		}

        public void init(IPluginHost h)
        {
            _host = h;
            _host.proxy.addEventHandler(EventType.GenericEvent, HandleGenericEvent);
        }

        public void testFireEvent()
		{
            System.Console.WriteLine("Do Something in Second Plugin");
            _host.proxy.fireEvent(new GenericEvent(this, "Message from second plugin"));
        }

        #endregion

        private void HandleGenericEvent(EventData e)
        {
            System.Console.WriteLine("Second plugin got event, data : " + e.data);
        }

    }
}
