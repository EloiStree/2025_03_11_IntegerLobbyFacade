using System;
using UnityEngine;

namespace Eloi.IntegerLobby
{
    public class IntegerLobbyFacadeStaticRelayMono: MonoBehaviour
    {
        public IntegerLobbyFacadeMono m_facade;
        public int m_lastClientToLobby;
        public int m_lastLobbyToClient;

        private void Reset()
        {
            m_facade =GetComponentInParent<IntegerLobbyFacadeMono>();
        }
        public void OnEnable()
        {
            StaticIntegerLobby.AddListenerToRelayAtServer(ClientToServer);
            m_facade.AddListenerForReceivedLobbyInteger(ServerToClient);
            m_facade.AddListenerToLobbyInteger(DebugPushInteger);
        }
        private void DebugPushInteger(int value)
        {
            m_lastClientToLobby = value;
        }
        private void ServerToClient(int value)
        {
            m_lastLobbyToClient = value;
            StaticIntegerLobby.NotifyIntegerReceivedFromServer(value);
        }

        private void ClientToServer(int value)
        {
            m_lastClientToLobby = value;
            m_facade.PushIntegerToLobbyServer(value);
        }

        public void OnDisable()
        {
            StaticIntegerLobby.RemoveListenerToRelayAtServer(ClientToServer);
            m_facade.RemoveListenerForReceivedLobbyInteger(ServerToClient);
        }
    }

}
