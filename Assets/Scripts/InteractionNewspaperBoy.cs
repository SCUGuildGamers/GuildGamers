using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionNewspaperBoy : Interactable
{
    public Pair<string, string>[] Sentences;

    void Start(){
        _eventManager = FindObjectOfType<EventManager>();
        Sentences = new Pair<string, string>[] {
            new Pair<string, string>("Newspaper Boy", "Extra! Extra!"),
            new Pair<string, string>("Newspaper Boy", "Trash monster attacks Bay Gulf Beach! Read all about it! ")};
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
