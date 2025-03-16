using NUnit.Framework;
using System;
using UnityEngine;
using UnityEngine.Events;

namespace Eloi.IntegerLobby
{
    public class IntegerLobbyFacadeMono : MonoBehaviour
    {

        [SerializeField] UnityEvent<int> m_onIntegerPushToServer;
        [SerializeField] UnityEvent<int> m_onIntegerReceivedFromServer;
        [SerializeField] int m_lastReceivedInteger = 0;
        [SerializeField] int m_lastPushedInteger = 0;
        public void PushIntegerToLobbyServer(int integerValue)
        {
            m_lastPushedInteger = integerValue;
            m_onIntegerPushToServer?.Invoke(integerValue);
        }

        public void NotifyIntegerReceivedFromServer(int integerValue)
        {
            m_lastReceivedInteger = integerValue;
            m_onIntegerReceivedFromServer?.Invoke(integerValue);
        }

        public void RemoveListenerForReceivedLobbyInteger(Action<int> notifyIntegerReceivedFromServer)
        {
            if (notifyIntegerReceivedFromServer == null)
                return;
            m_onIntegerReceivedFromServer.RemoveListener(notifyIntegerReceivedFromServer.Invoke);
        }

        public void AddListenerForReceivedLobbyInteger(Action<int> notifyIntegerReceivedFromServer)
        {
            if (notifyIntegerReceivedFromServer == null)
                return;
            m_onIntegerReceivedFromServer.AddListener(notifyIntegerReceivedFromServer.Invoke);
        }

        public void AddListenerToLobbyInteger(Action<int> debugPushInteger)
        {
            if (debugPushInteger == null)
                return;
            m_onIntegerPushToServer.AddListener(debugPushInteger.Invoke);
        }
    }

}
