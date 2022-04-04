using System.Collections;
using UnityEngine;
using TMPro;
public class DialogueManager : MonoBehaviour
{
    public TextMeshProUGUI text;
    private DialogueContainer current;
    private int counter;
    private int max;
    public void LoadContainer(DialogueContainer NEW){
        current = NEW;
        max = NEW.dialogues.Length;
        counter = 0;
    }
    public void StartNewDialogue(){
        text.text = "";
        DisplayNext();
    }
    public void DisplayNext(){
        if (counter < max){
            StartCoroutine(SpawnNext());
        }
        else{
            EndDialogue();
        }
    }
    public void EndDialogue(){
        text.text="";
    }

    IEnumerator SpawnNext(){
        text.alpha = 0;
        text.text = current.dialogues[counter];
        counter++;
        while (text.alpha != 1){
            text.alpha += 0.05f;
            yield return new WaitForSeconds(0.15f);
        }
    }
}
