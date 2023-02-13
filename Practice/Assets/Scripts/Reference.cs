using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Reference
{
    private PlayerBall _playerBall;
    private Camera _mainCamera;
    private GameObject _bonuse;
    private GameObject _endGame;
    private Canvas _canvas;
    private GameObject _restartButton;

    public Canvas Canvas
    {
        get
        {
            if (_canvas == null)
            {
                _canvas = Object.FindObjectOfType<Canvas>();
            }
            return _canvas;
        }
    }

    public GameObject RestartButton
    {
        get
        {
            if (_restartButton == null)
            {
                var gameObject = Resources.Load<GameObject>("RestartButton");
                _restartButton = Object.Instantiate(gameObject, Canvas.transform);
            }
            return _restartButton;
        }
    }

    public GameObject Bonuse
    {
        get
        {
            if (_bonuse == null)
            {
                var gameObject = Resources.Load<GameObject>("BonusText");
                _bonuse = Object.Instantiate(gameObject, Canvas.transform);
            }
            return _bonuse;
        }
    }
    public GameObject EndGame
    {
        get
        {
            if (_endGame == null)
            {
                var gameObject = Resources.Load<GameObject>("EndText");
                _endGame = Object.Instantiate(gameObject, Canvas.transform);
            }
            return _endGame;
        }
    }
    public PlayerBall PlayerBall
    {
        get
        {
            if (_playerBall == null)
            {
                var gameObject = Resources.Load<PlayerBall>("Player");
                _playerBall = Object.Instantiate(gameObject);
            }
            return _playerBall;
        }
    }
    public Camera MainCamera
    {
        get
        {
            if (_mainCamera == null)
            {
                _mainCamera = Camera.main;
            }
            return _mainCamera;
        }
    }
}