using UnityEngine;

namespace Eloi.IntegerLobby
{
    public class StaticIntMono_PushServerToUnity : MonoBehaviour
    {

        public void PushIntegerServerToUnity(int value) {

            StaticIntegerLobby.PushIntegerServerToUnity(value);
        }

    }

}
