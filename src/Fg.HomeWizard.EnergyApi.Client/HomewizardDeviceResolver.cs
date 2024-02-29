using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zeroconf;

namespace Fg.HomeWizard.EnergyApi.Client
{
    public static class HomeWizardDeviceResolver
    {
        public static async Task<HomewizardDevice?> FindHomeWizardDeviceAsync(string deviceName, ILogger logger)
        {
            return (await FindHomeWizardDevicesAsync(logger)).FirstOrDefault(d => d.Name == deviceName);
        }

        public static async Task<IEnumerable<HomewizardDevice>> FindHomeWizardDevicesAsync(ILogger logger)
        {
            IReadOnlyList<IZeroconfHost> results = await ZeroconfResolver.ResolveAsync("_hwenergy._tcp.local.");

            var devices = new List<HomewizardDevice>();

            foreach (var device in results)
            {
                logger.LogDebug($"Device {device.DisplayName} found at IP {device.IPAddress}");
                devices.Add(new HomewizardDevice(device.DisplayName, device.IPAddress));
            }

            return devices;
        }
    }
}
