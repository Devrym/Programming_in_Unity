using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public sealed class GameController : MonoBehaviour
{
    public Text _finishGameLabel;
    private InteractiveObject[] _interactiveObject;
    private DisplayEndGame _displayEndGame;
    private DisplayGoodGame _displayGoodGame;
    private void Awake()
    {
        _interactiveObject = FindObjectsOfType<InteractiveObject>();
        _displayEndGame = new DisplayEndGame(_finishGameLabel);
        _displayGoodGame= new DisplayGoodGame(_finishGameLabel);
        foreach (var o in _interactiveObject)
        {
            if (o is BadBonus badBonus)
            {
                badBonus.CaughtPlayerBad += CaughtPlayer;
                badBonus.CaughtPlayerBad += _displayEndGame.GameOver;
            }
        }

        foreach (var o in _interactiveObject)
        {
            if (o is GoodBonus goodBonus)
            {
                goodBonus.CaughtPlayerGood += CaughtPlayer;
                goodBonus.CaughtPlayerGood += _displayGoodGame.GameOver;
            }
        }
    }

    private void CaughtPlayer()
    {
        //Time.timeScale = 0.0f;
    }

    private void Update()
    {
        for (var i = 0; i < _interactiveObject.Length; i++)
        {
            var interactiveObject = _interactiveObject[i];
            if (interactiveObject == null)
            {
                continue;
            }
            if (interactiveObject is IFly fly)
            {
                fly.Fly();
            }
            if (interactiveObject is IFlicker flicker)
            {
                flicker.Flicker();
            }
            if (interactiveObject is IRotation rotation)
            {
                rotation.Rotation();
            }
        }
    }
}
