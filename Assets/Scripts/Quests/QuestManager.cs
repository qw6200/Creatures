using System.Collections;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    public QuestObject[] quests;
    public bool[] questsCompleted;

    public DialogManager dm;
    public string itemCollected;

    // Start is called before the first frame update
    void Start()
    {
        questsCompleted = new bool[quests.Length];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ShowQuestText(string questText)
    {
        dm.dialogLines = new string[1];
        dm.dialogLines[0] = questText;
         
        dm.currentLine = 0;
        dm.ShowDialog();
    }
}
