using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameCondition : MonoBehaviour
{

    public bool hasWon = false;
    public bool hasLost = false;

    private void Update()
    {
        if (GameManager.Instance.currentScore == 5)
        {
            hasWon = true;
        }
        else if (GameManager.Instance.currentHP == 0)
        {
            hasLost = true;
        }

        WinGameCon();
        LoseGameCon();

    }
    private void WinGameCon()
    {
        if (hasWon == true)
        {

            Debug.Log("Player has Won the game!");
            Time.timeScale = 0;
        }
    }

    private void LoseGameCon()
    {
        if (hasLost == true)
            {

                Debug.Log("Player have lost, Game Over.");
                Time.timeScale = 0;
            }
    }

}
