using System.Text.Json;

namespace Fg.HomeWizard.EnergyApi.Client.Tests.Serialization
{
    public class MeasurementDeserializationTests
    {
        [Fact]
        public void CanDeserializeJsonToMeasurement()
        {
            string json =
                @"{""wifi_ssid"":""wifinetworkname"",""wifi_strength"":32,""smr_version"":50,""meter_model"":""Fluvius 253769484_A"",""unique_id"":""31598152452033335343637"",""active_tariff"":2,""total_power_import_kwh"":4049.143,""total_power_import_t1_kwh"":1397.678,""total_power_import_t2_kwh"":2051.465,""total_power_export_kwh"":5166.889,""total_power_export_t1_kwh"":3947.068,""total_power_export_t2_kwh"":1219.821,""active_power_w"":2804,""active_power_l1_w"":361,""active_power_l2_w"":184,""active_power_l3_w"":2258,""active_voltage_l1_v"":233.2,""active_voltage_l2_v"":232.7,""active_voltage_l3_v"":231.5,""active_current_l1_a"":1.71,""active_current_l2_a"":1.07,""active_current_l3_a"":9.76,""active_power_average_w"":945,""montly_power_peak_w"":3701,""montly_power_peak_timestamp"":240204161500,""total_gas_m3"":1850.601,""gas_timestamp"":240229213504,""gas_unique_id"":""37464C4F32313232303933323134"",""external"":[{""unique_id"":""3853455430303030333139393435"",""type"":""water_meter"",""timestamp"":240229213510,""value"":144.823,""unit"":""m3""},{""unique_id"":""3746ABCXYZ123933323134"",""type"":""gas_meter"",""timestamp"":240229213504,""value"":1340.601,""unit"":""m3""}]}";

            var result = JsonSerializer.Deserialize<Measurement>(json);

            Assert.NotNull(result);
            Assert.Equal(new DateTime(2024, 2, 4, 16, 15, 00), result.MonthlyPowerPeakTimestamp);
        }
    }
}
