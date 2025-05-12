using Newtonsoft.Json;
using System.IO;

public class Config
{
    public int MinWordLength { get; set; }
}

public class ConfigurationManager
{
    public static Config LoadConfiguration(string filePath)
    {
        if (!File.Exists(filePath))
        {
            throw new FileNotFoundException($"File konfigurasi tidak ditemukan di path: {filePath}");
        }

        var json = File.ReadAllText(filePath);

        if (string.IsNullOrEmpty(json))
        {
            throw new InvalidDataException("File konfigurasi kosong atau tidak valid.");
        }

        var config = JsonConvert.DeserializeObject<Config>(json);

        if (config == null)
        {
            throw new InvalidDataException("File konfigurasi tidak valid.");
        }

        return config;
    }
}
