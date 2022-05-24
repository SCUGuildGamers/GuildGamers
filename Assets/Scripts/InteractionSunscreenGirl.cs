using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionSunscreenGirl : Interactable
{
    public Pair<string, string>[] Sentences;

    void Start(){
        _eventManager = FindObjectOfType<EventManager>();
        Sentences = new Pair<string, string>[] {
            new Pair<string, string>("Girl", "Ew, you’re not wearing ocean-safe sunscreen?"),
            new Pair<string, string>("Girl", "What? You’re not wearing sunscreen? Well, you’re on thin ice, buddy."),
            new Pair<string, string>("Girl", "You know who else is on thin ice? The polar bears in the arctic."),
            new Pair<string, string>("Girl", "Not that you care. Of course you don’t."),
            new Pair<string, string>("Girl", "What? You do care about this stupidly important world around you? Well slap on some ocean-safe sunscreen, bub!"),
            new Pair<string, string>("Girl", "Here, lemme hit you with some! Don’t even try to run away."),
            new Pair<string, string>("", "(You’re now wearing ocean-safe sunscreen.)")};
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
