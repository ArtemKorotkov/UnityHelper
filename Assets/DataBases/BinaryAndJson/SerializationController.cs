using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Newtonsoft.Json;
using UnityEngine;

namespace Source
{
    public class SerializationController : MonoBehaviour
    {
        private BinaryStorage _binaryStorage;
        private JsonStorage _jsonStorage;
        private GameData _gameData;

        public void Start()
        {
            _binaryStorage = new BinaryStorage();
            _jsonStorage = new JsonStorage();
            
            _gameData = new GameData();
            
            _gameData.name = "ArtemBinary";
            _binaryStorage.Save(_gameData);
            var resultBinary = (GameData) _binaryStorage.Load();
            Debug.Log(resultBinary.name);

            _gameData.name = "ArtemJson";
            _jsonStorage.Save(_gameData);
            var resultJson = (GameData) _jsonStorage.Load();
            Debug.Log(resultJson.name);
        }

    }
    

    public class BinaryStorage
    {
        private string _filePath;
        private BinaryFormatter _formatter;

        public BinaryStorage()
        {
            var saveDirectory = UnityEngine.Application.persistentDataPath + "/saves";

            if (!Directory.Exists(saveDirectory))
                Directory.CreateDirectory(saveDirectory);

            _filePath = saveDirectory + "/GameSave.Bin";
            _formatter = new BinaryFormatter();
        }

        public void Save(object saveData)
        {
            var file = File.Create(_filePath);
            _formatter.Serialize(file, saveData);
            file.Close();
        }

        public object Load()
        {
            if (!File.Exists(_filePath))
                return null;
            
            var file = File.Open(_filePath, FileMode.Open);
            var savedData = _formatter.Deserialize(file);
            file.Close();

            return savedData;
        }
    }

    public class JsonStorage
    {
        private string _filePath;

        public JsonStorage()
        {
            var saveDirectory = UnityEngine.Application.persistentDataPath + "/savesJson";

            if (!Directory.Exists(saveDirectory))
                Directory.CreateDirectory(saveDirectory);

            _filePath = saveDirectory + "/GameSave.Json";
        }

        public void Save(object saveData)
        {
            var jsonData = JsonConvert.SerializeObject(saveData);

            File.WriteAllText(_filePath, jsonData);
        }

        public object Load()
        {
            if (!File.Exists(_filePath))
                return null;

            var savedData = JsonConvert.DeserializeObject<GameData>(File.ReadAllText(_filePath));
            return savedData;
        }
    }

    [Serializable]
    public class GameData
    {
        public int index;
        public string name;
        public float speed;

        public GameData()
        {
            index = 0;
            name = "One";
            speed = 0f;
        }
    }
}