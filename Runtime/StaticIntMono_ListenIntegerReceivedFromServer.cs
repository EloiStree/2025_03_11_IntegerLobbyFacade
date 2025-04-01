using System;
using UnityEngine;
using UnityEngine.Events;

namespace Eloi.IntegerLobby
{
    public class StaticIntMono_ListenIntegerReceivedFromServer : MonoBehaviour
    {

        public int m_receivedInteger;
        public UnityEvent<int> m_onIntegerReceivedFromServer;
        public UnityEvent<string> m_onIntegerReceivedFromServerAsString;
        public bool m_catchException;


        private void OnEnable()
        {
            StaticIntegerLobby.AddListenerServerToUnity(NotifyServerToUnity);
        }

        private void OnDisable()
        {

            StaticIntegerLobby.AddListenerServerToUnity(NotifyServerToUnity);
        }

        private void NotifyServerToUnity(int obj)
        {
            if (m_catchException)
            {
                m_receivedInteger = obj;
                try
                {
                    m_onIntegerReceivedFromServer.Invoke(obj);
                    m_onIntegerReceivedFromServerAsString.Invoke(obj.ToString());
                }
                catch (Exception e)
                {

                    Debug.LogWarning(e.Message + ":" + e.StackTrace);

                }
            }
            else
            {

                m_receivedInteger = obj;
                m_onIntegerReceivedFromServer.Invoke(obj);
                m_onIntegerReceivedFromServerAsString.Invoke(obj.ToString());
            }
        }

    }



}
