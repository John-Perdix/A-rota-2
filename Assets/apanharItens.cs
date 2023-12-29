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
        if (gameObject.name == "Slot Variant (Clone)")
        {
            inventory.AddItem(casco, 1);
        }
        else if (gameObject.name == "Slot (Clone)")
        {
            inventory.AddItem(velaMeio, 1);
        }
        else if (gameObject.name == "Slot Variant 1 (Clone)")
        {
            inventory.AddItem(velaFrente, 1);
        }
        else if (gameObject.name == "Slot Variant 2 (Clone)")
        {
            inventory.AddItem(velaTras, 1);
        }

        Destroy(gameObject.transform.parent);

    }
}
