using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionSandcastle : Interactable
{
    public Pair<string, string>[] Sentences;

    void Start(){
        _eventManager = FindObjectOfType<EventManager>();
        Sentences = new Pair<string, string>[] {
            new Pair<string, string>("", "(It’s a sandcastle.)"),
            new Pair<string, string>("", "(It uses little plastic pieces for a door and windows. A tiny flag is fashioned out of a stick and a food wrapper.)"),
            new Pair<string, string>("", "You see something written on the ground in front of the sandcastle)"),
            new Pair<string, string>("", "(“Property of Maya, no one enters the Super Awesome Unicorn Rainbow Castle Ranch without my permission. Out swimming, will return in...”)"),
            new Pair<string, string>("", "(You can’t discern the rest since it looks like someone stepped on it.)")};
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
