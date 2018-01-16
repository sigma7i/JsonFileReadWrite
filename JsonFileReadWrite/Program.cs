using System;
using System.IO;
using KellermanSoftware.CompareNetObjects;
using Newtonsoft.Json;

namespace JsonFileReadWrite
{
	class Program
	{
		static void Main(string[] args)
		{
			var config = GetVoiceConfigObject();

			SaveJsonFile(config, "File.json");

			var result = ReadJsonFile<VoiceConfig>("File.json");

			CompareLogic compareLogic = new CompareLogic();

			ComparisonResult compareResult = compareLogic.Compare(config, result);

			if (!compareResult.AreEqual)
				Console.WriteLine(compareResult.DifferencesString);
		}

		public static void SaveJsonFile(object data, string path)
		{
			using (StreamWriter file = File.CreateText(path))
			{
				JsonSerializer serializer = new JsonSerializer();
				serializer.Formatting = Formatting.Indented;
				serializer.Serialize(file, data);
			}
		}

		public static T ReadJsonFile<T>(string path)
		{
			using (StreamReader r = new StreamReader(path))
			{
				string json = r.ReadToEnd();
				return JsonConvert.DeserializeObject<T>(json);
			}
		}

		private static VoiceConfig GetVoiceConfigObject()
		{
			var config = new VoiceConfig();

			config.SignalNoise.Enable = true;
			config.SignalNoise.Maximum = 100;
			config.SignalNoise.Minimum = 20;

			config.Duration.Enable = true;
			config.Duration.Maximum = 35;
			config.Duration.Minimum = 1;

			config.SimpleRate.Enable = true;
			config.SimpleRate.Maximum = 96000;
			config.SimpleRate.Minimum = 8000;

			config.Channels.Enable = true;
			config.Channels.Maximum = 2;
			config.Channels.Minimum = 1;

			config.Length.Enable = true;
			config.Length.Maximum = 1500;
			config.Length.Minimum = 100;

			config.Depth.Enable = true;
			config.Depth.Maximum = 32;
			config.Depth.Minimum = 8;

			config.Frequency.Enable = true;
			config.Frequency.Maximum = 3000.0M;
			config.Frequency.Minimum = 20.0M;

			return config;
		}

		private static ImageConfig GetImageConfigObject()
		{
			var config = new ImageConfig();

			config.Model.Path = "model/main_clnf_general.txt";

			config.Classifiers.Path = "classifiers/haarcascade_frontalface_alt.xml";

			config.Length.Enable = true;
			config.Length.Maximum = 100000;
			config.Length.Minimum = 500;

			config.HeadHorizontalSize.Enable = true;
			config.HeadHorizontalSize.Maximum = 0.75M;
			config.HeadHorizontalSize.Minimum = 0.5M;

			config.HeadVerticalSize.Enable = true;
			config.HeadVerticalSize.Maximum = 0.9M;
			config.HeadVerticalSize.Minimum = 0.6M;

			config.FaceHorizontalPosition.Enable = true;
			config.FaceHorizontalPosition.Maximum = 0.55M;
			config.FaceHorizontalPosition.Minimum = 0.45M;

			config.FaceVerticalPosition.Enable = true;
			config.FaceVerticalPosition.Maximum = 0.5M;
			config.FaceVerticalPosition.Minimum = 0.3M;

			config.Width.Enable = true;
			config.Width.Maximum = 4096;
			config.Width.Minimum = 640;

			config.Height.Enable = true;
			config.Height.Maximum = 4096;
			config.Height.Minimum = 480;

			config.Channels.Enable = true;
			config.Channels.Maximum = 5;
			config.Channels.Minimum = 1;

			config.Depth.Enable = true;
			config.Depth.Maximum = 32;
			config.Depth.Minimum = 8;

			config.HeadRx.Enable = true;
			config.HeadRx.Maximum = 5;
			config.HeadRx.Minimum = 0;

			config.HeadRy.Enable = true;
			config.HeadRy.Maximum = 5;
			config.HeadRy.Minimum = 0;

			config.HeadRz.Enable = true;
			config.HeadRz.Maximum = 8;
			config.HeadRz.Minimum = 0;

			config.EyesDistance.Enable = true;
			config.EyesDistance.Maximum = 4096;
			config.EyesDistance.Minimum = 120;

			return config;
		}
	}
}
