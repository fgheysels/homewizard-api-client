using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zeroconf;

namespace Fg.HomeWizard.EnergyApi.Client
{
    public static class HomeWizardDeviceResolver
    {
        public static async Task<HomeWizardDevice?> FindHomeWizardDeviceAsync(string deviceName, ILogger logger)
        {
            return (await FindHomeWizardDevicesAsync(logger)).FirstOrDefault(d => d.Name == deviceName);
        }

        public static async Task<IEnumerable<HomeWizardDevice>> FindHomeWizardDevicesAsync(ILogger logger)
        {
            IReadOnlyList<IZeroconfHost> results = await ZeroconfResolver.ResolveAsync("_hwenergy._tcp.local.");

            var devices = new List<HomeWizardDevice>();

            foreach (var device in results)
            {
                logger.LogDebug($"Device {device.DisplayName} found at IP {device.IPAddress}");
                devices.Add(new HomeWizardDevice(device.DisplayName, device.IPAddress));
            }

            return devices;
        }
    }
}
