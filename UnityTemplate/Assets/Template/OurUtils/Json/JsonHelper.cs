using Newtonsoft.Json;
using System.IO;
using System;
using UnityEngine;

namespace OurUtils
{
    public class JsonHelper
    {
        protected JsonHelper() { }

        public static string Serialize(System.Object obj)
        {
            string json = JsonConvert.SerializeObject(obj, Formatting.Indented,
                    new JsonSerializerSettings
                    {
                        Formatting = Newtonsoft.Json.Formatting.Indented,
                        ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
                    });
            return json;
        }

        public static T Deserialize<T>(string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }

        public static T ReadData<T>(string filePath)
        {
            string jsonRead;
            try
            {
                string extension = Path.GetExtension(filePath);
                if (string.IsNullOrEmpty(extension))
                {
                    filePath += ".txt";
                }
                jsonRead = System.IO.File.ReadAllText(filePath);
                return Deserialize<T>(jsonRead);
            }
            catch (Exception ex)
            {
                Debug.LogError($"Error reading file: {ex.Message}");
                return default;
            }
        }

        public static void SaveData(System.Object saveObject, string filePath)
        {
            //string json = JsonConvert.SerializeObject(saveObject, Formatting.Indented);

            string json = Serialize(saveObject);

            string extension = Path.GetExtension(filePath);
            if (string.IsNullOrEmpty(extension))
            {
                filePath += ".txt";
            }

            string dirPath = Path.GetDirectoryName(filePath);
            if (!Directory.Exists(dirPath))
            {
                Directory.CreateDirectory(dirPath);
            }
            else
            {
                File.WriteAllText(filePath, string.Empty);
            }

            using (StreamWriter sw = (File.Exists(filePath)) ? File.AppendText(filePath) : File.CreateText(filePath))
            {
                sw.WriteLine(json);
            }

            Debug.Log($"Save file success at: {filePath}");
        }
    }
}