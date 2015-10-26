using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Complete
{
    public class LobbyManager : MonoBehaviour
    {
        List<int> meow = new List<int>();
        private int number = 0;
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

            //if (Input.GetButtonDown("Start" + playerNumber))
            //    GameManager.instance.StartGame();

            //If a new players joins add them to the list

                CheckForPlayerInput();
        }
        void CheckForPlayerInput()
        {
            foreach (var item in playersNotInstantiatedNumbers)
            {
                if (Input.GetButtonDown("fire" + item))
                {
                    var clone = Instantiate(playerPrefab);

                    clone.GetComponent<Player>().JustGotInstantiated(number);
                    playersNotInstantiatedNumbers.Remove(item);
                }
            }
            //if(Input.GetButtonDown("fire" + number))
            //{
                
            //    var clone = Instantiate(playerPrefab);

            //    clone.GetComponent<Player>().JustGotInstantiated(number);

            //    number++;
            //    //TODO Add a player with their number. so you can diffenriate what they do.
            //}
        }

        public void APlayerLeft()
        {
            //TODO
            //If a player leaves. reduce the number
            //If a player left. then delete that playerprefab.
        }
    }
}
