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
            Debug.Log("Meow. and my player number is: " + myNumber);
        }

        void Update()
        {
            //If a player presses the leave button then say that to lobbymanager
            if(Input.GetButtonDown("Leave" + myNumber))
            {
                LobbyManager.instance.APlayerLeft(myNumber);
                Destroy(gameObject);
            }
        }
    }
}
