using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestTrigger : MonoBehaviour
{
    private QuestManager qm;
    public int questNumber;

    public bool startQuest;
    public bool endQuest;

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
            if (!qm.questsCompleted[questNumber])
            {
                if (startQuest && !qm.quests[questNumber].gameObject.activeSelf)
                {
                    qm.quests[questNumber].gameObject.SetActive(true);
                    qm.quests[questNumber].StartQuest();
                }
                if (endQuest && qm.quests[questNumber].gameObject.activeSelf)
                {
                    qm.quests[questNumber].EndQuest();
                }
            }
        }    
    }
}
