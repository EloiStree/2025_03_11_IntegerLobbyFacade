using System;
using UnityEngine;
using UnityEngine.Events;

namespace Eloi.IntegerLobby
{


    public class IntLobbyMono_PushIntegerSample : MonoBehaviour
    {

        public UnityEvent<int> m_onIntegerPush;
     
        public int m_inspectorValue = 31418;
        public int m_minValueRange = 0;
        public int m_maxValueRange = 100;

        public void PushIntegerValueToAllLobby(int integerValue)
        {
            m_onIntegerPush.Invoke(integerValue);
        }

        [ContextMenu("Push Inspector Value")]
        public void PushInspectorValue()
        {
            PushIntegerValueToAllLobby(m_inspectorValue);
        }
        [ContextMenu("Push Inspector Random Range")]
        public void PushInspectorRandomRange()
        {
            PushIntegerValueToAllLobby(UnityEngine.Random.Range(m_minValueRange, m_maxValueRange));
        }
        [ContextMenu("Push Integer 0")]
        public void PushInteger_0() => PushIntegerValueToAllLobby(0);
        [ContextMenu("Push Integer 1")]
        public void PushInteger_1() => PushIntegerValueToAllLobby(1);
        [ContextMenu("Push Integer 42")]
        public void PushInteger_42() => PushIntegerValueToAllLobby(42);
        [ContextMenu("Push Integer 100")]
        public void PushInteger_100() => PushIntegerValueToAllLobby(100);
        [ContextMenu("Push Integer 2501")]
        public void PushInteger_2501() => PushIntegerValueToAllLobby(2501);
        [ContextMenu("Push randdom 0 1")]
        public void PushRandom0to1() => PushIntegerValueToAllLobby(UnityEngine.Random.Range(0, 2));
        [ContextMenu("Push randdom 0 10")]
        public void PushRandom0to10() => PushIntegerValueToAllLobby(UnityEngine.Random.Range(0, 11));
        [ContextMenu("Push randdom 0 100")]
        public void PushRandom0to100() => PushIntegerValueToAllLobby(UnityEngine.Random.Range(0, 101));

    }

}
