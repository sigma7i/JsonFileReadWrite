using Newtonsoft.Json;

namespace JsonFileReadWrite
{
	public struct ConfigParameter
	{
		/// <summary>
		/// максимальное значение параметра;
		/// </summary>
		[JsonProperty(PropertyName = "maximum")]
		public decimal Maximum;

		/// <summary>
		/// минимальное значение параметра;
		/// </summary>
		[JsonProperty(PropertyName = "minimum")]
		public decimal Minimum;

		/// <summary>
		/// Включение параметра в формирование итогового результата проверки
		/// </summary>
		[JsonProperty(PropertyName = "enable")]
		public bool Enable;
	}
}
