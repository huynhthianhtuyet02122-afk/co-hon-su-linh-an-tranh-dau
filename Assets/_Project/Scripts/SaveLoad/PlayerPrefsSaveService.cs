using UnityEngine;

namespace CoHonSu.Foundation.SaveLoad
{
    public sealed class PlayerPrefsSaveService : ISaveService
    {
        private const string PlayerPrefsStorageIdentifier = "cohonsu.foundation.save.v1";

        public bool TryLoad(out SaveGameData saveData)
        {
            saveData = null;

            if (!PlayerPrefs.HasKey(PlayerPrefsStorageIdentifier))
            {
                return false;
            }

            string json = PlayerPrefs.GetString(PlayerPrefsStorageIdentifier);
            saveData = JsonUtility.FromJson<SaveGameData>(json);
            return saveData != null;
        }

        public void Save(SaveGameData saveData)
        {
            if (saveData == null)
            {
                return;
            }

            string json = JsonUtility.ToJson(saveData);
            PlayerPrefs.SetString(PlayerPrefsStorageIdentifier, json);
            PlayerPrefs.Save();
        }

        public void Delete()
        {
            PlayerPrefs.DeleteKey(PlayerPrefsStorageIdentifier);
        }
    }
}
