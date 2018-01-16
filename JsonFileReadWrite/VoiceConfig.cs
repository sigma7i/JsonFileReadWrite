using Newtonsoft.Json;

namespace JsonFileReadWrite
{
	public class VoiceConfig
	{
		/// <summary>
		/// SNR отношение сигнал/шум в Дб
		/// </summary>
		[JsonProperty(PropertyName = "signal_noise")]
		[JsonConverter(typeof(DecimalZeroConverter))]
		public ConfigParameter SignalNoise;

		/// <summary>
		/// Длина записи в секундах
		/// </summary>
		[JsonProperty(PropertyName = "duration")]
		[JsonConverter(typeof(DecimalZeroConverter))]
		public ConfigParameter Duration;

		/// <summary>
		/// Частота дискретизации в Гц
		/// </summary>
		[JsonProperty(PropertyName = "simple_rate")]
		[JsonConverter(typeof(DecimalZeroConverter))]
		public ConfigParameter SimpleRate;

		/// <summary>
		/// Количество каналов
		/// </summary>
		[JsonProperty(PropertyName = "channels")]
		[JsonConverter(typeof(DecimalZeroConverter))]
		public ConfigParameter Channels;

		/// <summary>
		/// Размер проверяемых данных в Кб
		/// </summary>
		[JsonProperty(PropertyName = "length")]
		[JsonConverter(typeof(DecimalZeroConverter))]
		public ConfigParameter Length;

		/// <summary>
		/// Глубина квантования
		/// </summary>
		[JsonProperty(PropertyName = "depth")]
		[JsonConverter(typeof(DecimalZeroConverter))]
		public ConfigParameter Depth;

		/// <summary>
		/// Граничные значения частоты для расчета SNR
		/// </summary>
		[JsonProperty(PropertyName = "frequency")]
		public ConfigParameter Frequency;
	}
}
