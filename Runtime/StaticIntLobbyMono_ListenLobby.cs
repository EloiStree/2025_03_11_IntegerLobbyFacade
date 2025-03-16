using UnityEngine;
using UnityEngine.Events;

namespace Eloi.IntegerLobby
{
    public class StaticIntLobbyMono_ListenLobby : MonoBehaviour
    {
        public int m_lastReceivedValue = 0;
        public UnityEvent<int> m_onIntegerReceivedFromLobby;
        public bool m_catchException = false;
        public void OnEnable()
        {
            StaticIntegerLobby.AddListenerForServerIntegerReceived(RelayToUnityEvent);
        }
        public void OnDisable()
        {
            StaticIntegerLobby.RemoveListenerForServerIntegerReceived(RelayToUnityEvent);
        }
        private void RelayToUnityEvent(int value)
        {
            m_lastReceivedValue = value;
            if (m_catchException)
            {
                try
                {
                    m_onIntegerReceivedFromLobby?.Invoke(value);
                }
                catch (System.Exception e)
                {
                    Debug.LogWarning("Error in " + this + " : " + e,this.gameObject);
                }
            }
            else
            {
                m_onIntegerReceivedFromLobby?.Invoke(value);
            }
            
        }
    }

}
