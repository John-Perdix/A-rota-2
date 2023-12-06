using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Colisao : MonoBehaviour
{
    public GameObject main;
    public GameObject front;
    public GameObject back;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("main"))
        {
            main.transform.position = new Vector2 (0,0); 
            Debug.Log("fsdfds");
        }
    }
}
