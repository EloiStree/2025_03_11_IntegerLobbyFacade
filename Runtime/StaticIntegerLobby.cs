using System;
using UnityEngine;

namespace Eloi.IntegerLobby
{


    /// <summary>
    /// Allow to interact with the lobby of the current game from any where in the code
    /// </summary>
    public class StaticIntegerLobby
    {
        public static int m_lastIntegerUnityToServer;
        public static Action<int> m_onUnityToServerInteger;

        public static int m_lastIntegerServerToUnity;
        public static Action<int> m_onServerToUnityInteger;


        public static void PushIntegerServerToUnity(int integerValue)
        {
            if (m_onServerToUnityInteger != null)
                m_onServerToUnityInteger.Invoke(integerValue);
        }
       

        public static void PushIntegerUnityToServer(int integerValue)
        {
            if (m_onUnityToServerInteger != null)
                m_onUnityToServerInteger.Invoke(integerValue);


        }



        public static void AddListenerServerToUnity(Action<int> listener)
        {
            m_onServerToUnityInteger += listener;
        }
        public static void RemoveListenerServerToUnity(Action<int> listener)
        {
            m_onServerToUnityInteger -= listener;
        }

        public static void AddListenerUnityToServer(Action<int> listener)
        {
            m_onUnityToServerInteger += listener;

        }
        public static void RemoveListenerUnityToServer(Action<int> listener)
        {
            m_onUnityToServerInteger -= listener;
        }

    }

}
