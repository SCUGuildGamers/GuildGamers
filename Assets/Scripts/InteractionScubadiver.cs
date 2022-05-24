using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionScubadiver : Interactable
{
    public Pair<string, string>[] Sentences;

    void Start(){
        _eventManager = FindObjectOfType<EventManager>();
        Sentences = new Pair<string, string>[] {
            new Pair<string, string>("Scuba Diver", "Blub Blub Blub!"),
            new Pair<string, string>("", "(You have a feeling that this conversation would be better on shore…)")};
        lines = new Dialogue(Sentences);
        Vector3 pos = transform.position;
        pos.y += 1.6f;
        indicatorplaceholder.transform.position = pos;
        indicatorplaceholder.gameObject.SetActive(false);
    }

    public override bool Interact()
    {
        Trigger.SayDialogue(lines);
        return true;
    }

}
