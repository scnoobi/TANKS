using UnityEngine;
using System.Collections;

namespace Complete
{
    public class Player : MonoBehaviour
    {

        private int myNumber;


        public void JustGotInstantiated(int myPlayerNumber)
        {
            myNumber = myPlayerNumber;
        }

        void Update()
        {
            //If a player presses the leave button then say that to lobbymanager
            if(Input.GetButtonDown("leave" + myNumber))
            {
                LobbyManager.instance.APlayerLeft();
            }
        }
    }
}
