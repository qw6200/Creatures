using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestObject : MonoBehaviour
{
    public int questNumber;
    public QuestManager qm;

    public string startText;
    public string endText;

    public bool isItemQuest;
    public string targetItem;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isItemQuest)
        {
            if (qm.itemCollected == targetItem)
            {
                qm.itemCollected = null;
                EndQuest();
            }
        }
    }
    public void StartQuest()
    {
        qm.ShowQuestText(startText);
    }
    public void EndQuest()
    {
        qm.ShowQuestText(endText);
        qm.questsCompleted[questNumber] = true;
        gameObject.SetActive(false);

    }
}
