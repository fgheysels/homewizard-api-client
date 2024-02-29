using System.Threading.Tasks;
using Fg.HomeWizard.EnergyApi.Client;

namespace Fg.HomeWizard.EnergyApi.Client
{
    public interface IHomeWizardService
    {
        Task<Measurement> GetCurrentMeasurements();
    }
}
