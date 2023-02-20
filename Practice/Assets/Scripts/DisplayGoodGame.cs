using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayGoodGame : MonoBehaviour
{
    //private Text _finishGameLabel;
    //public DisplayGoodGame(Text finishGameLabel)
    //{
    //    _finishGameLabel = finishGameLabel;
    //    _finishGameLabel.text = String.Empty;
    //}
    //public void GameOver()
    //{
    //    _finishGameLabel.text = "Вы ускорены!";

    //}

    private Text _finishGameLabel;
    public DisplayGoodGame(GameObject goodGame)
    {
        _finishGameLabel = goodGame.GetComponentInChildren<Text>();
        _finishGameLabel.text = String.Empty;
    }
    public void GameOver(string name, Color color)
    {
        _finishGameLabel.text = $"Вы ускорены!";
    }
}
