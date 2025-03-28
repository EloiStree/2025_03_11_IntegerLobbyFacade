using System;
using UnityEngine;
using UnityEngine.Events;

namespace Eloi.IntegerLobby
{
    public class StaticIntMono_ListenIntegerSendToServer : MonoBehaviour
    {
        public int m_sendInteger;
        public UnityEvent<int> m_onIntegerSendToServer;
        public UnityEvent<string> m_onIntegerSendToServerAsString;
        public bool m_catchException;

        private void OnEnable()
        {
            StaticIntegerLobby.AddListenerUnityToServer(NotifyUnityToServer);
        }

        private void OnDisable()
        {

            StaticIntegerLobby.RemoveListenerUnityToServer(NotifyUnityToServer);
        }

        private void NotifyUnityToServer(int obj)
        {
            if (m_catchException)
            {
                m_sendInteger = obj;
                try
                {
                    m_onIntegerSendToServer.Invoke(obj);
                    m_onIntegerSendToServerAsString.Invoke(obj.ToString());
                }
                catch (Exception e)
                {

                    Debug.LogWarning(e.Message + ":" + e.StackTrace);

                }
            }
            else {
            
                m_sendInteger = obj;
                m_onIntegerSendToServer.Invoke(obj);
                m_onIntegerSendToServerAsString.Invoke(obj.ToString());
            }
        }
    }



}
