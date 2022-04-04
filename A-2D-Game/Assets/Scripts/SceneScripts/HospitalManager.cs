using UnityEngine;

public class HospitalManager : MonoBehaviour
{
    public DialogueContainer reference;
    public DialogueManager manager;
    int doido = 0;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)){
            switch (doido){
                case 0:  manager.LoadContainer(reference);manager.StartNewDialogue();doido++;break;
                case 1: manager.DisplayNext();doido++;break;
                default:doido++;break;
            }

        }
        
    }
}
