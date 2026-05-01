using UnityEngine;

namespace CoHonSu.Foundation.Data
{
    [CreateAssetMenu(
        fileName = "FoundationConfig",
        menuName = "CoHonSu/Foundation Config")]
    public sealed class FoundationConfig : ScriptableObject
    {
        [SerializeField] private string projectDisplayName = "Cơ Hồn Sư: Linh Ấn Tranh Đấu";
        [SerializeField] private string foundationVersion = "0.1.0";
        [SerializeField] private bool offlineSinglePlayer = true;

        public string ProjectDisplayName => projectDisplayName;
        public string FoundationVersion => foundationVersion;
        public bool OfflineSinglePlayer => offlineSinglePlayer;
    }
}
