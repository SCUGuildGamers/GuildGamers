using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionDisgruntledLocal : Interactable
{
    public Pair<string, string>[] Sentences;

    void Start(){
        _eventManager = FindObjectOfType<EventManager>();
        Sentences = new Pair<string, string>[] {
            new Pair<string, string>("Old Man", "*sigh* I remember when I could just sit on the beach and breathe in that fresh ocean breeze… "),
            new Pair<string, string>("Old Man", "Now I can’t sit for more than a minute without a plastic bag blowing into my face, or even find a spot to sit that isn’t covered in garbage."),
            new Pair<string, string>("Old Man", "I understand these resorts are bringing in money for us locals, but can’t they just have a little decency and pick up their trash?")};
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
