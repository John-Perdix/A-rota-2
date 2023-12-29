using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class apanharItens : MonoBehaviour
{
    public ItemObject Casco, velaFrente, velaMeio, velaTras;
    public InventoryObject inventory;

    private int pointsToWin;
    private int currentPoints;

    // Start is called before the first frame update
    void Start()
    {
        
        if (currentPoints >= pointsToWin)
        {
            transform.GetChild(0).gameObject.SetActive(true);
            transform.GetChild(1).gameObject.SetActive(false);

            if (transform.GetChild(0).gameObject)
            {
                int milliseconds = 2000;
                Thread.Sleep(milliseconds);

                SceneManager.LoadSceneAsync(3);
            }
        }
    }

    public void AddPointsItems()
    {
        currentPoints++;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void catchItem()
    {
        Debug.Log("GameObject Name: " + gameObject.name);
        if (gameObject.name == "catchObjectCasco")
        {
            //inventory.AddItem(Casco, 1);
            Destroy(gameObject.transform.parent.gameObject);
            GameObject.Find("PointsHandler").GetComponent<ColectedPieces>().AddPointsPieces();
            Debug.Log("PirateShip_hull destroyed");
        }
        else if (gameObject.name == "catchObjectMeio")
        {
            //inventory.AddItem(velaMeio, 1);
            Destroy(gameObject.transform.parent.gameObject);
            GameObject.Find("PointsHandler").GetComponent<ColectedPieces>().AddPointsPieces();
        }
        else if (gameObject.name == "catchObjectFrente")
        {
            //inventory.AddItem(velaFrente, 1);
            Destroy(gameObject.transform.parent.gameObject);
            GameObject.Find("PointsHandler").GetComponent<ColectedPieces>().AddPointsPieces();
        }
        else if (gameObject.name == "catchObjectTras")
        {
            //inventory.AddItem(velaTras, 1);
            Destroy(gameObject.transform.parent.gameObject);
            GameObject.Find("PointsHandler").GetComponent<ColectedPieces>().AddPointsPieces();
        }

        //Destroy(gameObject.transform.parent);
        //Destroy(gameObject.transform.parent.gameObject);

    }
}
