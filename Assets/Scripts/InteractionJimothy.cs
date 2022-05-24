using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionJimothy : Interactable
{
    public Pair<string, string>[] Sentences;

    void Start(){
        _eventManager = FindObjectOfType<EventManager>();
        Sentences = new Pair<string, string>[] {
            new Pair<string, string>("Li’l Jimothy", "Hey duder, I got these totally sick snatched down the house swaggert rubber bands here."),
            new Pair<string, string>("Li’l Jimothy", "Glitter, matte, metallic, I got ‘em all…  I’ve spent my entire 4th year in elementary school trading them."),
            new Pair<string, string>("Li’l Jimothy", "Almost every variety known to humankind!! And maybe even alienkind.. "),
            new Pair<string, string>("Li’l Jimothy", "That’s my favorite one, by the way, this alien-shaped one… "),
            new Pair<string, string>("", "(... These bands appear quite silly.)"),
            new Pair<string, string>("Li’l Jimothy", "Oh, shucks! Jeepers! The alien band broke… Are you kidding me? This was my rarest one! Well, it’s absolute bunk now. You can keep it, I have gazillions more."),
            new Pair<string, string>("", "(It appears after a lot of stretching and solidification, this could make a good loop for your net.)"),
            new Pair<string, string>("", "(Obtained the loop!)")};
        lines = new Dialogue(Sentences);
        Vector3 pos = transform.position;
        pos.y += 1.6f;
        indicatorplaceholder.transform.position = pos;
        indicatorplaceholder.gameObject.SetActive(false);
    }

    public override bool Interact()
    {
        if (_eventManager.Loop == false){
            _eventManager.Loop = true;
            Trigger.SayDialogue(lines);
            Sentences = new Pair<string, string>[] {
            new Pair<string, string>("Li’l Jimothy", "Hey duder, I got these totally sick snatched down the house swaggert rubber bands here."),
            new Pair<string, string>("Li’l Jimothy", "Glitter, matte, metallic, I got ‘em all…  I’ve spent my entire 4th year in elementary school trading them."),
            new Pair<string, string>("Li’l Jimothy", "Almost every variety known to humankind!! And maybe even alienkind.. "),
            new Pair<string, string>("", "(... These bands appear quite silly.)")};
            lines = new Dialogue(Sentences);
            return true;
        } else {
            Trigger.SayDialogue(lines);
            return true;
        }
    }

}
