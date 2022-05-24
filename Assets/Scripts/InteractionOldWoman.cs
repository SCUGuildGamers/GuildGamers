using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionOldWoman : Interactable
{
<<<<<<< Updated upstream
    void Start(){
        Pair<string, string>[] Sentences = new Pair<string, string>[] {
            new Pair<string, string>("", "(This women appears to be crocheting a suspiciously net like object)"),
            new Pair<string, string>("Old Woman", "Eh-hee, hello there, kiddo. Would you like a sweet, sweetie?"),
            new Pair<string, string>("", "(She hands you a cookie before you get the chance to respond.)"),
            new Pair<string, string>("", "(Obtained the Bone-shaped Biscuit!)"),
            new Pair<string, string>("", "(Is this… a dog biscuit?)"),
            new Pair<string, string>("Ancient Edna", "Awww, aren’t you adorable? Go on and eat up, now. It’s store-bought with Grandma’s love.")};
=======
    public Pair<string, string>[] Sentences;

    void Start(){
        _eventManager = FindObjectOfType<EventManager>();
        Sentences = new Pair<string, string>[] {
            new Pair<string, string>("", "(This woman appears to be crocheting a suspiciously net like object)"),
            new Pair<string, string>("Ancient", "Eh-hee, hello there, kiddo. Would you like a sweet, sweetie?"),
            new Pair<string, string>("", "(She hands you a cookie before you get the chance to respond.)"),
            new Pair<string, string>("", "(Obtained the Bone-shaped Biscuit!)"),
            new Pair<string, string>("", "(Is this… a dog biscuit?)"),
            new Pair<string, string>("Ancient Edna", "Awww, aren’t you adorable? Go on and eat up, now. It’s store-bought with Grandma’s love."),
            new Pair<string, string>("Ancient Edna", "Welp, back to crocheting for little old granny. Yessiree."),
            new Pair<string, string>("Ancient Edna", "What’s that? Oh, you want my crochet? To fight monsters in the ocean?"),
            new Pair<string, string>("Ancient Edna", "Oh children have such wild imaginations these days."),
            new Pair<string, string>("Ancient Edna", "It's made of fabric made of recycled materials so it shouldn’t break if there is, say, a giant trash monster that you may have to fight."),
            new Pair<string, string>("Ancient Edna", "I have plenty more to make another one."),
            new Pair<string, string>("", "Obtained the crocheted net!")};
>>>>>>> Stashed changes
        lines = new Dialogue(Sentences);
        Vector3 pos = transform.position;
        pos.y += 1.6f;
        indicatorplaceholder.transform.position = pos;
        indicatorplaceholder.gameObject.SetActive(false);
    }
<<<<<<< Updated upstream
=======

    public override bool Interact()
    {
        if (_eventManager.Net == false){
            _eventManager.Net = true;
            _eventManager.Biscuit = true;
            Trigger.SayDialogue(lines);
            Sentences = new Pair<string, string>[] {
                new Pair<string, string>("", "(This woman appears to be crocheting a suspiciously net like object)"),
                new Pair<string, string>("Ancient", "Eh-hee, hello there, kiddo. Would you like a sweet, sweetie?"),
                new Pair<string, string>("", "(She hands you a cookie before you get the chance to respond.)"),
                new Pair<string, string>("", "(Obtained the Bone-shaped Biscuit!)"),
                new Pair<string, string>("", "(Is this… a dog biscuit?)"),
                new Pair<string, string>("Ancient Edna", "Awww, aren’t you adorable? Go on and eat up, now. It’s store-bought with Grandma’s love."),
                new Pair<string, string>("Ancient Edna", "Welp, back to crocheting for little old granny. Yessiree.")};
            lines = new Dialogue(Sentences);
            return true;
        } else {
            _eventManager.Biscuit = true;
            Trigger.SayDialogue(lines);
            return true;
        }
    }

>>>>>>> Stashed changes
}
