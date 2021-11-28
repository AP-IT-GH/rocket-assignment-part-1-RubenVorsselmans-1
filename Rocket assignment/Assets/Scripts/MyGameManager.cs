using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyGameManager : MonoBehaviour
{
    public GameObject Player;
    public GameObject mainCanvas;
    public GameObject gameOverCanvas;
    private Health health;

    public enum GameStates
    {
        Playing, Gameover
    }

    public GameStates gameState = GameStates.Playing;
    // Start is called before the first frame update
    void Start()
    {
        if (Player == null)
        {
            Player = GameObject.FindWithTag("Player");
        }
        health = Player.GetComponent<Health>();
        mainCanvas.SetActive(true);
        gameOverCanvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        switch (gameState)
        {
            case GameStates.Playing:
                if (!health.isAlive)
                {
                    gameState = GameStates.Gameover;
                    mainCanvas.SetActive(false);
                    gameOverCanvas.SetActive(true);
                }
                break;
        }
    }
}
