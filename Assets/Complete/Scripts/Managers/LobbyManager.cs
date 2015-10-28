using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Complete
{
    public class LobbyManager : MonoBehaviour
    {
        List<int> meow = new List<int>();
        public GameObject playerPrefab;
        private List<int> playersNotInstantiatedNumbers = new List<int>();
        public int amountOfPlayers = 4;

        public static LobbyManager instance;

        void Awake()
        {
            instance = this;
            for (int i = 0; i < amountOfPlayers; i++)
            {
                playersNotInstantiatedNumbers.Add(i);
            }
            
        }
        void Update()
        {
            //Everyone is ready. and some1 pressed start.
            //Start the game

            CheckForPlayerInput();
        }
        void CheckForPlayerInput()
        {
            foreach (var notInstantiatedNumber in playersNotInstantiatedNumbers)
            {
                if (Input.GetButtonDown("Fire" + notInstantiatedNumber))
                {
                    var clone = Instantiate(playerPrefab);

                    clone.GetComponent<Player>().JustGotInstantiated(notInstantiatedNumber);

                    playersNotInstantiatedNumbers.Remove(notInstantiatedNumber);
                    break;
                }
            }
        }

        public void APlayerLeft(int playerNumber)
        {
            //If a player left. then delete that playerprefab.
            playersNotInstantiatedNumbers.Add(playerNumber);
        }
    }
}
