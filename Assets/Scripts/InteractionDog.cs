using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionDog : Interactable
{
    public Pair<string, string>[] Sentences;

    void Start(){
        _eventManager = FindObjectOfType<EventManager>();
        Sentences = new Pair<string, string>[] {
            new Pair<string, string>("Dog", "Ruff!"),
            new Pair<string, string>("", "(The dog’s collar says Biscuit.)"),
            new Pair<string, string>("", "(Biscuit seems to really like the stick)")};
        lines = new Dialogue(Sentences);
        Vector3 pos = transform.position;
        pos.y += 1.6f;
        indicatorplaceholder.transform.position = pos;
        indicatorplaceholder.gameObject.SetActive(false);
    }

    public override bool Interact()
    {
        if (_eventManager.Biscuit == true){
            _eventManager.Biscuit = false;
            Sentences = new Pair<string, string>[] {
                new Pair<string, string>("Dog", "Ruff!"),
                new Pair<string, string>("", " (The dog’s collar says Biscuit.)"),
                new Pair<string, string>("", "(Biscuit is sniffing the bone-shaped biscuit you got from Ancient Edna)"),
                new Pair<string, string>("", "(You hold out the bone-shaped biscuit)"),
                new Pair<string, string>("", "(Biscuit happily takes the delicious treat)"),
                new Pair<string, string>("Biscuit", "Ruff! <3"),
                new Pair<string, string>("", "(Biscuit runs away and drops the stick on the ground)"),
                new Pair<string, string>("", "(The stick is covered in Biscuit’s slobber, but you think this will make a fine net handle)"),
                new Pair<string, string>("", "(You obtained the stick!)")};
            _eventManager.Stick = true;
            lines = new Dialogue(Sentences);
            Trigger.SayDialogue(lines);
            return true;
        } else {
            Trigger.SayDialogue(lines);
            return true;
        }
    }

}
