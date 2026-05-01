using CoHonSu.Foundation.SaveLoad;

namespace CoHonSu.Foundation.Core
{
    public sealed class GameRuntimeState
    {
        public GameRuntimePhase Phase { get; private set; } = GameRuntimePhase.Booting;
        public string PlayerId { get; private set; } = "local-player";
        public int FoundationVersion { get; private set; } = 1;
        public bool HasLoadedSave { get; private set; }

        public void SetPhase(GameRuntimePhase phase)
        {
            Phase = phase;
        }

        public void ApplySave(SaveGameData saveData)
        {
            if (saveData == null)
            {
                return;
            }

            PlayerId = string.IsNullOrWhiteSpace(saveData.playerId) ? PlayerId : saveData.playerId;
            FoundationVersion = saveData.foundationVersion;
            HasLoadedSave = true;
        }

        public SaveGameData CreateSaveData()
        {
            return new SaveGameData
            {
                playerId = PlayerId,
                foundationVersion = FoundationVersion
            };
        }
    }
}
