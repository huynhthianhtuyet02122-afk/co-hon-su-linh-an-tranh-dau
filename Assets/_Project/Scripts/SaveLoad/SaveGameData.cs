using System;

namespace CoHonSu.Foundation.SaveLoad
{
    [Serializable]
    public sealed class SaveGameData
    {
        public string playerId = "local-player";
        public int foundationVersion = 1;
    }
}
