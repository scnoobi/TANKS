using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Complete
{
    public class LobbyManager : MonoBehaviour
    {
        List<int> meow = new List<int>();
        void Update()
        {
            //Everyone is ready. and some1 pressed start.
            //Start the game

            //if (Input.GetButtonDown("Start" + playerNumber))
            //    GameManager.instance.StartGame();

            //If a new players joins add them to the list
            meow.Add(meow.Count - 1);
        }
    }
}
