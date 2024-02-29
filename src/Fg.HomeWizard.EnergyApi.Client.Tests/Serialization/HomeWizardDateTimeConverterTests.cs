using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Fg.HomeWizard.EnergyApi.Client.Serialization;

namespace Fg.HomeWizard.EnergyApi.Client.Tests.Serialization
{
    public class HomeWizardDateTimeConverterTests
    {
        [Fact]
        public void CanParseHomeWizardDateTimeString()
        {
            JsonSerializerOptions options = new JsonSerializerOptions();
            options.Converters.Add(new HomeWizardDateTimeConverter());

            DateTime result = JsonSerializer.Deserialize<DateTime>("240229213504", options);
            Assert.Equal(new DateTime(2024, 2, 29, 21, 35, 4), result);
        }
    }
}
