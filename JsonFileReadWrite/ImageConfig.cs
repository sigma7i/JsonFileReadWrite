using Newtonsoft.Json;

namespace JsonFileReadWrite
{
	public class ImageConfig
	{

		public struct StringConfigParameter
		{
			[JsonProperty(PropertyName = "path")]
			public string Path;
		}

		/// <summary>
		/// Путь до файла модели расстановки точек
		/// </summary>
		[JsonProperty(PropertyName = "model")]
		public StringConfigParameter Model;

		/// <summary>
		/// Путь до файла классификатора, для детектирования изображений лица
		/// </summary>
		[JsonProperty(PropertyName = "classifiers")]
		public StringConfigParameter Classifiers;

		/// <summary>
		/// Размер изображения в байтах
		/// </summary>
		[JsonProperty(PropertyName = "length")]
		[JsonConverter(typeof(DecimalZeroConverter))]
		public ConfigParameter Length;

		/// <summary>
		/// Размер головы по ширине, относительно ширины изображения
		/// </summary>
		[JsonProperty(PropertyName = "head_horizontal_size")]
		public ConfigParameter HeadHorizontalSize;

		/// <summary>
		/// Размер головы по высоте, относительно высоты изображения
		/// </summary>
		[JsonProperty(PropertyName = "head_vertical_size")]
		public ConfigParameter HeadVerticalSize;

		/// <summary>
		/// Горизонтальное положение головы относительно ширины изображения
		/// </summary>
		[JsonProperty(PropertyName = "face_horizontal_position")]
		public ConfigParameter FaceHorizontalPosition;

		/// <summary>
		/// Вертикальное расположение головы относительно высоты изображения
		/// </summary>
		[JsonProperty(PropertyName = "face_vertical_position")]
		public ConfigParameter FaceVerticalPosition;

		/// <summary>
		/// Ширина изображения
		/// </summary>
		[JsonProperty(PropertyName = "width")]
		[JsonConverter(typeof(DecimalZeroConverter))]
		public ConfigParameter Width;

		/// <summary>
		/// Высота изображения
		/// </summary>
		[JsonProperty(PropertyName = "height")]
		[JsonConverter(typeof(DecimalZeroConverter))]
		public ConfigParameter Height;

		/// <summary>
		/// Количество каналов изображения
		/// </summary>
		[JsonProperty(PropertyName = "channels")]
		[JsonConverter(typeof(DecimalZeroConverter))]
		public ConfigParameter Channels;

		/// <summary>
		/// Глубина
		/// </summary>
		[JsonProperty(PropertyName = "depth")]
		[JsonConverter(typeof(DecimalZeroConverter))]
		public ConfigParameter Depth;

		/// <summary>
		///  Угол наклона головы по оси х
		/// </summary>
		[JsonProperty(PropertyName = "head_rx")]
		[JsonConverter(typeof(DecimalZeroConverter))]
		public ConfigParameter HeadRx;

		/// <summary>
		/// Угол наклона головы по оси у
		/// </summary>
		[JsonProperty(PropertyName = "head_ry")]
		[JsonConverter(typeof(DecimalZeroConverter))]
		public ConfigParameter HeadRy;

		/// <summary>
		/// Угол поворота головы по оси z
		/// </summary>
		[JsonProperty(PropertyName = "head_rz")]
		[JsonConverter(typeof(DecimalZeroConverter))]
		public ConfigParameter HeadRz;

		/// <summary>
		/// Расстояние между глаз в пикселах
		/// </summary>
		[JsonProperty(PropertyName = "eyes_distance")]
		[JsonConverter(typeof(DecimalZeroConverter))]
		public ConfigParameter EyesDistance;
	}
}
