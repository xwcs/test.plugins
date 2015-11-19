using xwcs.core.plgs;
using xwcs.core.evt;

namespace FirstPlugin
{
    public class FirstPlugin :IPlugin
	{
        private IPluginHost _host;

        public FirstPlugin()
        {
        }

        #region IPlugin Members

        public string name
		{
			get
			{
				return "First Plugin";
			}
		}

        public void init(IPluginHost h)
        {
            _host = h;
            _host.proxy.addEventHandler(EventType.GenericEvent, HandleGenericEvent);
        }

        public void testFireEvent()
		{
            System.Console.WriteLine("Do Something in First Plugin");
            _host.proxy.fireEvent(new GenericEvent(this, "Message form first plugin"));
        }

        #endregion

        private void HandleGenericEvent(EventData e)
        {
            System.Console.WriteLine("First plugin got event, data : " + e.data);
        }
    }
}
