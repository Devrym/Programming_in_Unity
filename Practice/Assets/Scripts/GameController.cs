using Geekbrains;
using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public sealed class GameController : MonoBehaviour
{
    public PlayerType PlayerType = PlayerType.Ball;
    public Text _finishGameLabel;
    private ListExecuteObject _interactiveObject;
    private DisplayEndGame _displayEndGame;
    private DisplayBonuses _displayBonuses;
    private DisplayGoodGame _displayGoodGame;
    private int _countBonuses;
    private CameraScript _cameraController;
    private InputController _inputController;
    private Reference _reference;


    private void Awake()
    {
        _interactiveObject = new ListExecuteObject();
        _reference = new Reference();
        PlayerScript player = null;
        if (PlayerType == PlayerType.Ball)
        {
            player = _reference.PlayerBall;
        }

        _cameraController = new CameraScript(player.transform,_reference.MainCamera.transform);
        _interactiveObject.AddExecuteObject(_cameraController);
        if (Application.platform == RuntimePlatform.WindowsEditor)
        {
            _inputController = new InputController(player);
            _interactiveObject.AddExecuteObject(_inputController);
        }


        _displayEndGame = new DisplayEndGame(_reference.EndGame);
        _displayGoodGame = new DisplayGoodGame(_reference.Bonuse);
        

        foreach (var o in _interactiveObject)
        {
            if (o is BadBonus badBonus)
            {
                badBonus.OnCaughtPlayerChange += CaughtPlayer;
                badBonus.OnCaughtPlayerChange += _displayEndGame.GameOver;
            }
        }

        foreach (var o in _interactiveObject)
        {
            if (o is GoodBonus goodBonus)
            {
                goodBonus.OnPointChange += AddBonuse;
            }
        }

        //_reference.RestartButton.onClick.AddListener(RestartGame);
        _reference.RestartButton.gameObject.SetActive(false);

    }

    public void RestartGame()
    {
        SceneManager.LoadScene(sceneBuildIndex: 0);
        Time.timeScale = 1.0f;
    }

    private void CaughtPlayer(string value, Color args)
    {
        _reference.RestartButton.gameObject.SetActive(true);
        Time.timeScale = 0.0f;
    }

    private void AddBonuse(int value)
    {
        _countBonuses += value;
        //_displayBonuses.Display(_countBonuses);
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
            interactiveObject.Execute();
        }


        //for (var i = 0; i < _interactiveObject.Length; i++)
        //{
        //    var interactiveObject = _interactiveObject[i];
        //    if (interactiveObject == null)
        //    {
        //        continue;
        //    }
        //    if (interactiveObject is IFly fly)
        //    {
        //        fly.Fly();
        //    }
        //    if (interactiveObject is IFlicker flicker)
        //    {
        //        flicker.Flicker();
        //    }
        //    if (interactiveObject is IRotation rotation)
        //    {
        //        rotation.Rotation();
        //    }
        //}
    }
}
