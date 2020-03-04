using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryToggle : MonoBehaviour
{
    private Canvas CanvasObject; // Assign in inspector

    void Start()
    {
        CanvasObject = GetComponent<Canvas>();
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.I))
        {
            CanvasObject.enabled = !CanvasObject.enabled;
        }
    }
}
