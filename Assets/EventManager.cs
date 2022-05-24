using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public Dialogue lines;
    public DialogueTrigger Trigger;

    public Pair<string, string>[] Sentences;

    public bool Biscuit;
    public bool Net;
    public bool Stick;
    public bool Loop;
    public bool SuperNet;

    void Start()
    {
        Biscuit = false;
        Net = false;
        Stick = false;
        Loop = false;
        SuperNet = false;

        Sentences = new Pair<string, string>[] {
            new Pair<string, string>("", "(It looks like you have all the pieces you need.)"),
            new Pair<string, string>("", " *Construction sounds*"),
            new Pair<string, string>("", "(After a lot of hard work, it appears you made something that resembles a net. It should be good enough to pick up trash)"),
            new Pair<string, string>("", "(Obtained a Super Totally Biodegradable Net!)")};
        lines = new Dialogue(Sentences);
    }

    void Update(){
        if (Loop && Net && Stick){
            Trigger.SayDialogue(lines);
            Loop = false;
            Net = false;
            Stick = false;
            SuperNet = true;
        }
    }

}
