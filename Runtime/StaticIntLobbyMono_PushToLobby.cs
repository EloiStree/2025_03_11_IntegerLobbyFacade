using UnityEngine;

namespace Eloi.IntegerLobby
{
    /// <summary>
    /// Allow to interact with the lobby of the current game from any where in the game
    /// </summary>
    public class StaticIntLobbyMono_PushToLobby : MonoBehaviour
    {
        public int m_lastPushedValue = 0;

        [ContextMenu("Push Inspector Value")]
        public void PushInspectorValue()
        {
            PushToLobby(m_lastPushedValue);
        }

        public void PushToLobby(int value)
        {
            StaticIntegerLobby.PushIntegerToLobbyServer(value);
            m_lastPushedValue = value;
        }
        public void PushToLobby(string value)
        {
            int valueInt = 0;
            if (int.TryParse(value, out valueInt))
            {
                PushToLobby(valueInt);
            }
        }
    }

}
