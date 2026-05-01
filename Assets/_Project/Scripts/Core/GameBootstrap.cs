using CoHonSu.Foundation.Debugging;
using CoHonSu.Foundation.SaveLoad;
using UnityEngine;

namespace CoHonSu.Foundation.Core
{
    public sealed class GameBootstrap : MonoBehaviour
    {
        [SerializeField] private bool loadOnStart = true;
        [SerializeField] private bool saveOnPause = true;
        [SerializeField] private bool showDebugPanel = true;

        public GameRuntimeState RuntimeState { get; private set; } = new GameRuntimeState();
        public ISaveService SaveService { get; private set; } = new PlayerPrefsSaveService();

        private void Awake()
        {
            DontDestroyOnLoad(gameObject);
            RuntimeState.SetPhase(GameRuntimePhase.Booting);
        }

        private void Start()
        {
            if (loadOnStart && SaveService.TryLoad(out SaveGameData saveData))
            {
                RuntimeState.ApplySave(saveData);
            }

            RuntimeState.SetPhase(GameRuntimePhase.Ready);

            if (showDebugPanel && GetComponent<FoundationDebugPanel>() == null)
            {
                gameObject.AddComponent<FoundationDebugPanel>().Bind(RuntimeState);
            }
        }

        private void OnApplicationPause(bool pauseStatus)
        {
            if (pauseStatus && saveOnPause)
            {
                Save();
            }
        }

        private void OnApplicationQuit()
        {
            Save();
        }

        public void Save()
        {
            SaveService.Save(RuntimeState.CreateSaveData());
        }
    }
}
