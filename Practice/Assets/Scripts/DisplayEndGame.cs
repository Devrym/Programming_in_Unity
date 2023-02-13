using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayEndGame : MonoBehaviour
{
    //private Text _finishGameLabel;
    //public DisplayEndGame(Text finishGameLabel)
    //{
    //    _finishGameLabel = finishGameLabel;
    //    _finishGameLabel.text = String.Empty;
    //}
    //public void GameOver()
    //{
    //    _finishGameLabel.text = "Вы замедлены!";
    //}

    private Text _finishGameLabel;
    public DisplayEndGame(GameObject endGame)
    {
        _finishGameLabel = endGame.GetComponentInChildren<Text>();
        _finishGameLabel.text = String.Empty;
    }
    public void GameOver(string name, Color color)
    {
        _finishGameLabel.text = $"Вы замедлены!{name}{color}";
    }
}
