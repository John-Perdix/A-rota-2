using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Draggable : MonoBehaviour
{
    public bool IsDragging;
    private Collider2D _collider;
    private DragController _dragController;



    void Start()
    {
       // _collider = GetComponent<Collider2D>();
       // _dragController = FindObjectOfType<DragController>();
    }

    /* void OnTriggerEnter2D(Collider2D other){
        Draggable collidedDraggable = other.GetComponent<Draggable>();

        if(collidedDraggable != null && _dragController.LastDragged.gameObject == gameObject)
        {
            ColliderDistance2D colliderDistance2D = other.Distance(_collider);
            Vector3 diff = new Vector3(colliderDistance2D.normal.x, colliderDistance2D.normal.y) * colliderDistance2D.distance;
            transform.position -= diff;
            
        }
    } */


    //void OnTriggerEnter2D(Collider2D other)
   // {
       /*Draggable collidedDraggable = other.GetComponent<Draggable>();

        if (collidedDraggable != null && _dragController != null && _dragController.LastDragged != null && _dragController.LastDragged.gameObject == gameObject)
        {
             ColliderDistance2D colliderDistance2D = other.Distance(_collider);
             Vector3 diff = new Vector3(colliderDistance2D.normal.x, colliderDistance2D.normal.y) * colliderDistance2D.distance;
             transform.position -= diff; 
         }*/

       
  //  }
}
