using System.Threading.Tasks;

namespace Fg.HomeWizard.EnergyApi.Client
{
    public interface IHomeWizardService
    {
        Task<Measurement> GetCurrentMeasurementsAsync();
    }
}
