using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    private int pointsToWin;
    private int currentPoints;
    public GameObject myPieces;
    // Start is called before the first frame update
    void Start()
    {
        pointsToWin = myPieces.transform.childCount;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentPoints >= pointsToWin)
        {
            transform.GetChild(0).gameObject.SetActive(true);
            transform.GetChild(1).gameObject.SetActive(false);

            if (transform.GetChild(0).gameObject)
            {
                int milliseconds = 2000;
                Thread.Sleep(milliseconds);

                SceneManager.LoadSceneAsync(2);
            }
        }
    }

    public void AddPoints()
    {
        currentPoints++;
    }
}
