using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : Interactable
{
    public Pair<string, string>[] Sentences;

    void Start(){
        _eventManager = FindObjectOfType<EventManager>();
        Sentences = new Pair<string, string>[] {
            new Pair<string, string>("Dolphin Whisperer", "The dolphins… They are speaking to me from the depths below! They are whispering in their wild, mysterious ways! Yes! Yes! The dolphins!"),
            new Pair<string, string>("", "(Dolphins…?)"),
            new Pair<string, string>("Dolphin Whisperer", "whisperer: They are gossiping…They are talking about you a lot. Ohoho."),
            new Pair<string, string>("Dolphin Whisperer", " By Poseidon, they thank you for your service to the oceans and seas! The dolphins bless you on your journey here and beyond!"),
            new Pair<string, string>("", "(Suddenly you hear a voice beamed into your mind.)"),
            new Pair<string, string>("", "A Dolphin appears near the shore"),
            new Pair<string, string>("Dolphin", "(Land-dweller. Your services to the ocean deep are most appreciated. The strange material has harmed our younglings; our limbs were entangled in plastic.)"),
            new Pair<string, string>("Dolphin", "(Bless you, land-dweller. For you, we will choose not to wage war against humanity and annihilate your kin.)"),
            new Pair<string, string>("", "(What?)"),
            new Pair<string, string>("Dolphin Whisperer", "I think they’re saying they like you! Ohoho!"),
            new Pair<string, string>("", "(You’re going to pretend you just imagined that.)")};
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
