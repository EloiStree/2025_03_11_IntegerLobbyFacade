using System;

namespace Eloi.IntegerLobby
{
    /// <summary>
    /// Allow to interact with the lobby of the current game from any where in the code
    /// </summary>
    public class StaticIntegerLobby
    {

        public static void AddListenerForServerIntegerReceived(Action<int> onIntegerReceivedFromServerNotification)
        {
            m_onIntegerReceivedFromServerNotification += onIntegerReceivedFromServerNotification;
        }
        public static void RemoveListenerForServerIntegerReceived(Action<int> onIntegerReceivedFromServerNotification)
        {
            m_onIntegerReceivedFromServerNotification -= onIntegerReceivedFromServerNotification;
        }

        public static void AddListenerToRelayAtServer(Action<int> onIntegerPushToServerRequest)
        {
            m_onIntegerPushToServerRequest += onIntegerPushToServerRequest;
        }
        public static void RemoveListenerToRelayAtServer(Action<int> onIntegerPushToServerRequest)
        {
            m_onIntegerPushToServerRequest -= onIntegerPushToServerRequest;
        }

        public static Action<int> m_onIntegerPushToServerRequest;
        public static Action<int> m_onIntegerReceivedFromServerNotification;
        public static void NotifyIntegerReceivedFromServer(int integerValue)
        {
            if (m_onIntegerReceivedFromServerNotification != null)
                m_onIntegerReceivedFromServerNotification.Invoke(integerValue);
        }

        public static void PushIntegerToLobbyServer(int integerValue)
        {
            if (m_onIntegerPushToServerRequest != null)
                m_onIntegerPushToServerRequest.Invoke(integerValue);
        }
    }

}
