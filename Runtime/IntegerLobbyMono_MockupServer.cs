using UnityEngine;
using UnityEngine.Events;

namespace Eloi.IntegerLobby
{
    public class IntegerLobbyMono_MockupServer : MonoBehaviour
    {

        public UnityEvent<int> m_onRelayIntegerReceived;
        public IntegerLobbyFacadeMono[] m_onLobbyInSceneToRelayTo;
        public int[] m_integerReceivedHistory = new int[10];

        public void PushIntegerValueToAllLobby(int integerValue)
        {
            for (int i = m_integerReceivedHistory.Length - 1; i > 0; i--)
            {
                m_integerReceivedHistory[i] = m_integerReceivedHistory[i - 1];
            }
            m_integerReceivedHistory[0] = integerValue;

            m_onRelayIntegerReceived.Invoke(integerValue);
            foreach (var item in m_onLobbyInSceneToRelayTo)
            {
                if (item == null)
                    continue;
                item.NotifyIntegerReceivedFromServer(integerValue);
            }


        }
    }

}
