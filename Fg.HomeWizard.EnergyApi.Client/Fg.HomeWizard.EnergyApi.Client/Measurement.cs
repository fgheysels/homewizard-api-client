using System.Text.Json.Serialization;

namespace Fg.HomeWizard.EnergyApi.Client
{
    public class Measurement
    {
        /// <summary>
        /// The unique identifier from the smart meter
        /// </summary>
        [JsonPropertyName("unique_id")]
        public string HomewizardDeviceId { get; set; }

        /// <summary>
        /// The DSMR version of the smart meter
        /// </summary>
        [JsonPropertyName("smr_version")]
        public int SmrVersion { get; set; }

        /// <summary>
        /// The brand identification the smart meter
        /// </summary>
        [JsonPropertyName("meter_model")]
        public string MeterModel { get; set; }

        /// <summary>
        /// The Wi-Fi network that the meter is connected to
        /// </summary>
        [JsonPropertyName("wifi_ssid")]
        public string WifiSSid { get; set; }

        /// <summary>
        /// The strength of the Wi-Fi signal in %
        /// </summary>
        [JsonPropertyName("wifi_strength")]
        public int WifiStrength { get; set; }

        /// <summary>
        /// The energy usage meter reading for all tariffs in kWh
        /// </summary>
        [JsonPropertyName("total_power_import_kwh")]
        public double TotalPowerImportInKwh { get; set; }

        /// <summary>
        /// The energy usage meter reading for tariff 1 in kWh
        /// </summary>
        [JsonPropertyName("total_power_import_t1_kwh")]
        public double TotalPowerImportInKwhForTarif1 { get; set; }

        /// <summary>
        /// The energy usage meter reading for tariff 2 in kWh
        /// </summary>
        [JsonPropertyName("total_power_import_t2_kwh")]
        public double TotalPowerImportInKwhForTarif2 { get; set; }

        /// <summary>
        /// The energy usage meter reading for tariff 3 in kWh
        /// </summary>
        [JsonPropertyName("total_power_import_t3_kwh")]
        public double TotalPowerImportInKwhForTarif3 { get; set; }

        /// <summary>
        /// The energy usage meter reading for tariff 4 in kWh
        /// </summary>
        [JsonPropertyName("total_power_import_t4_kwh")]
        public double TotalPowerImportInKwhForTarif4 { get; set; }

        /// <summary>
        /// The energy feed-in meter reading for all tariffs in kWh
        /// </summary>
        [JsonPropertyName("total_power_export_kwh")]
        public double TotalPowerExportInKwh { get; set; }

        /// <summary>
        /// The energy feed-in meter reading for tariff 1 in kWh
        /// </summary>
        [JsonPropertyName("total_power_export_t1_kwh")]
        public double TotalPowerExportInKwhForTarif1 { get; set; }

        /// <summary>
        /// The energy feed-in meter reading for tariff 2 in kWh
        /// </summary>
        [JsonPropertyName("total_power_export_t2_kwh")]
        public double TotalPowerExportInKwhForTarif2 { get; set; }

        /// <summary>
        /// The energy feed-in meter reading for tariff 3 in kWh
        /// </summary>
        [JsonPropertyName("total_power_export_t3_kwh")]
        public double TotalPowerExportInKwhForTarif3 { get; set; }

        /// <summary>
        /// The energy feed-in meter reading for tariff 4 in kWh
        /// </summary>
        [JsonPropertyName("total_power_export_t4_kwh")]
        public double TotalPowerExportInKwhForTarif4 { get; set; }

        /// <summary>
        /// The total active usage in watt
        /// </summary>
        [JsonPropertyName("active_power_w")]
        public double ActivePowerInWatt { get; set; }

        /// <summary>
        /// The active usage for phase 1 in watt
        /// </summary>
        [JsonPropertyName("active_power_l1_w")]
        public double ActivePowerPhase1InWatt { get; set; }

        /// <summary>
        /// The active usage for phase 2 in watt
        /// </summary>
        [JsonPropertyName("active_power_l2_w")]
        public double ActivePowerPhase2InWatt { get; set; }

        /// <summary>
        /// The active usage for phase 3 in watt
        /// </summary>
        [JsonPropertyName("active_power_l3_w")]
        public double ActivePowerPhase3InWatt { get; set; }

        /// <summary>
        /// The active voltage for phase 1 in volt
        /// </summary>
        [JsonPropertyName("active_voltage_l1_v")]
        public double ActiveVoltagePhase1 { get; set; }

        /// <summary>
        /// The active voltage for phase 2 in volt
        /// </summary>
        [JsonPropertyName("active_voltage_l2_v")]
        public double ActiveVoltagePhase2 { get; set; }

        /// <summary>
        /// The active voltage for phase 3 in volt
        /// </summary>
        [JsonPropertyName("active_voltage_l3_v")]
        public double ActiveVoltagePhase3 { get; set; }

        /// <summary>
        /// The active current for phase 1 in ampere
        /// </summary>
        [JsonPropertyName("active_current_l1_a")]
        public double ActiveCurrentPhase1 { get; set; }

        /// <summary>
        /// The active current for phase 2 in ampere
        /// </summary>
        [JsonPropertyName("active_current_l2_a")]
        public double ActiveCurrentPhase2 { get; set; }

        /// <summary>
        /// The active current for phase 3 in ampere
        /// </summary>
        [JsonPropertyName("active_current_l3_a")]
        public double ActiveCurrentPhase3 { get; set; }
    }
}
