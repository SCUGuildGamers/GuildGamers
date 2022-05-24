using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionUpbeatGuy : Interactable
{
    public Pair<string, string>[] Sentences;

    void Start(){
        _eventManager = FindObjectOfType<EventManager>();
        Sentences = new Pair<string, string>[] {
            new Pair<string, string>("Guy", "Hey, I’m sure you’re excited to hear this NPC dialogue…"),
            new Pair<string, string>("Guy", "But first, a word from our sponsor."),
            new Pair<string, string>("Guy", "Today's dialogue is sponsored by Maiden Darkness Myths!"),
            new Pair<string, string>("Guy", "Currently almost twenty users have downloaded Maiden Darkness Myths over the last ten years, and it's one of the most impressive games in its class with detailed low poly models and smooth sixty frames per minute animations!"),
            new Pair<string, string>("Guy", "Use the referral code NPC for up to 20% off your monthly subscription!"),
            new Pair<string, string>("", "(You feel oddly convinced to download this game once you get back home…)")};
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
