using CoHonSu.Foundation.Core;
using UnityEngine;

namespace CoHonSu.Foundation.Debugging
{
    public sealed class FoundationDebugPanel : MonoBehaviour
    {
        private GameRuntimeState runtimeState;

        public void Bind(GameRuntimeState state)
        {
            runtimeState = state;
        }

        private void OnGUI()
        {
            if (runtimeState == null)
            {
                return;
            }

            GUILayout.BeginArea(new Rect(16f, 16f, 280f, 120f), GUI.skin.box);
            GUILayout.Label("CoHonSu Foundation v0.1");
            GUILayout.Label($"Phase: {runtimeState.Phase}");
            GUILayout.Label($"Player: {runtimeState.PlayerId}");
            GUILayout.Label($"Loaded Save: {runtimeState.HasLoadedSave}");
            GUILayout.EndArea();
        }
    }
}
