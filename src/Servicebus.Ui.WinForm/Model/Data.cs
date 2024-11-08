using System.Text.Json;

namespace Servicebus.Ui.WinForm.Model
{
    public class Data
    {
        private string _filePath => Path.Combine(Path.GetDirectoryName(Application.ExecutablePath.ToString()), "data.json");

        public List<Property> Properties { get; set; } = new List<Property>();

        public Data Get()
        {
            var jsonPath = _filePath;
            if (!File.Exists(jsonPath))
                Save();
            var jsonFile = File.ReadAllText(jsonPath);
            var config = JsonSerializer.Deserialize<Data>(jsonFile);
            return config;
        }

        public void Save()
        {
            Properties = Properties.Where(x=> !string.IsNullOrEmpty(x.Key)).ToList();
            var json = JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true});
            File.WriteAllText(_filePath, json);
        }
    }
}
