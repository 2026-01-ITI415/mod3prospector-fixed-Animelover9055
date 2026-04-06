using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum eCardStateGolf { drawpile, mine, target, discard }

public class CardGolf : Card
{
    [Header("Dynamic: CardGolf")]
    public eCardStateGolf state = eCardStateGolf.drawpile;

    public List<CardGolf> hiddenBy = new List<CardGolf>();
    public int layoutID;
    public JsonLayoutSlot layoutSlot;

    override public void OnMouseUpAsButton()
    {
        base.OnMouseUpAsButton();
    }
}
