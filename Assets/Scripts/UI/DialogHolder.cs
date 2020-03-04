using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogHolder : MonoBehaviour
{
    public string dialog;
    private DialogManager dm;

    public string[] dialogLines;

    // Start is called before the first frame update
    void Start()
    {
        dm = FindObjectOfType<DialogManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            if (Input.GetKeyUp(KeyCode.Space))
            {
                //dm.ShowBox(dialog);
                if (!dm.dialogActive)
                {
                    dm.dialogLines = dialogLines;
                    dm.currentLine = 0;
                    dm.ShowDialog();
                }
                if (transform.parent.GetComponent<VillagerMovement>() != null)
                {
                    transform.parent.GetComponent<VillagerMovement>().canMove = false;
                }
            }
        }
    }
}
