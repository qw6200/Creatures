using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestItem : MonoBehaviour
{
    public int questNumber;
    private QuestManager qm;

    public string itemName;

    // Start is called before the first frame update
    void Start()
    {
        qm = FindObjectOfType<QuestManager>();   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            if (!qm.questsCompleted[questNumber] && qm.quests[questNumber].gameObject.activeSelf)
            {
                qm.itemCollected = itemName;
                gameObject.SetActive(false);
            }
        }    
    }
}
