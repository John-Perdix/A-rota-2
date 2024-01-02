using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ColectedPieces : MonoBehaviour
{
    private int pointsToWin;
    private int currentPoints;
    // Start is called before the first frame update
    void Start()
    {
        currentPoints = 0;
        pointsToWin = 8;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentPoints >= pointsToWin)
        {
            transform.GetChild(0).gameObject.SetActive(true);
            transform.GetChild(1).gameObject.SetActive(false);
                int milliseconds = 2000;
                Thread.Sleep(milliseconds);

                SceneManager.LoadSceneAsync(3);
        }
    }

    public void AddPointsPieces()
    {
        currentPoints++;
        Debug.Log("+1");
    }
}
