using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class apanharItens : MonoBehaviour
{
    public ItemObject casco, velaFrente, velaMeio, velaTras;
    public InventoryObject inventory;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void catchItem()
    {
        if (gameObject.name == "PirateShip_hull (Clone)")
        {
            inventory.AddItem(casco, 1);
        }
        else if (gameObject.name == "PirateShip_main sale (Clone)")
        {
            inventory.AddItem(velaMeio, 1);
        }
        else if (gameObject.name == "PirateShip_front_sale 1 (Clone)")
        {
            inventory.AddItem(velaFrente, 1);
        }
        else if (gameObject.name == "PirateShip_back_sale (Clone)")
        {
            inventory.AddItem(velaTras, 1);
        }

        Destroy(gameObject.transform.parent);

    }
}
