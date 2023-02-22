using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.Debug;

public abstract class PlayerScript : MonoBehaviour
{

    string s = "сиииссссссснннннннррри";
    
    public float Speed = 3.0f;
    public int VictoryPoint;
    [SerializeField] GameObject _win;
    public abstract void Move(float x, float y, float z);


    private void FixedUpdate()
    {
        char c = 'и';
        int i = s.CharCount(c);
        Victory();
        Debug.Log(i);
        CollectionList.listCollection();
    }


    public void Victory()
    {
        if (VictoryPoint == 5)
        {
            Time.timeScale = 0.0f;
            Log("Победа");
            _win = GameObject.Find("Win");
            _win.GetComponent<Text>().text = "ПОБЕДА!";
        }
    }


}
