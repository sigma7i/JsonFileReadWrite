using System;
using System.Globalization;
using System.Linq;
using Newtonsoft.Json;

namespace JsonFileReadWrite
{
	internal class DecimalZeroConverter : JsonConverter
	{
		public override bool CanConvert(Type objectType)
		{
			return objectType == typeof(ConfigParameter);
		}

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue,
			JsonSerializer serializer)
		{
			return serializer.Deserialize<ConfigParameter>(reader);
		}

		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			if (value == null)
			{
				serializer.Serialize(writer, null);
				return;
			}

			var fields = value.GetType().GetFields();

			writer.WriteStartObject();

			foreach (var field in fields)
			{

				var attribute = (JsonPropertyAttribute)field.GetCustomAttributes(typeof(JsonPropertyAttribute), false).FirstOrDefault();

				if (attribute != null)
				{
					writer.WritePropertyName(attribute.PropertyName);
				}
				else
				{
					writer.WritePropertyName(field.Name);
				}

				if (field.FieldType == typeof(decimal))
				{
					var number = (decimal)field.GetValue(value);

					WriteWithoutZero(writer, number);
				}
				else
					writer.WriteValue(field.GetValue(value));
			}

			writer.WriteEndObject();
		}

		private void WriteWithoutZero(JsonWriter writer, decimal number)
		{
			if (number % 1 == 0)
				writer.WriteRawValue(number.ToString("F0", CultureInfo.InvariantCulture));
			else
			{
				writer.WriteRawValue(number.ToString(CultureInfo.InvariantCulture));
			}
		}
	}
}
