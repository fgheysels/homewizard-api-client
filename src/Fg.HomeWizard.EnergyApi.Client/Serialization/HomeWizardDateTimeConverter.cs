using System;
using System.Diagnostics;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Fg.HomeWizard.EnergyApi.Client.Serialization
{
    public class HomeWizardDateTimeConverter : JsonConverter<DateTime>
    {
        public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            Debug.Assert(typeToConvert == typeof(DateTime));

            long numericValue = reader.GetInt64();

            return DateTime.ParseExact(numericValue.ToString() ?? string.Empty, "yyMMddHHmmss", CultureInfo.CurrentCulture, DateTimeStyles.AssumeLocal);
        }

        public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToString("yyMMddHHmmss"));
        }
    }
}
