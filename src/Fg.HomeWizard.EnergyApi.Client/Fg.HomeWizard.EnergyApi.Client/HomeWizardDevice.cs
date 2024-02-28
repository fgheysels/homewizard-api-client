namespace Fg.HomeWizard.EnergyApi.Client
{
    public class HomeWizardDevice
    {
        public HomeWizardDevice(string device, string ipAddress)
        {
            Name = device;
            IPAddress = ipAddress;
        }

        public string Name { get; }
        public string IPAddress { get; }
    }
}