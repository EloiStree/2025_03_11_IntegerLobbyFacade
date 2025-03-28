using System;
using UnityEngine;
using UnityEngine.Events;

namespace Eloi.IntegerLobby
{
    public class StaticIntMono_PushUnityToServer : MonoBehaviour
    {
        public void  PushIntegerUnityToServer(int value) { 
        
            StaticIntegerLobby.PushIntegerUnityToServer(value);
        }
    }

}
