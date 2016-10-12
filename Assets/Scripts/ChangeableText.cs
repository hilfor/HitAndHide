using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class ChangeableText : MonoBehaviour, IChangeableUI
{
    public Text changeableTextElement;
    public void ChangeUi(PlayerSide playerSide)
    {
        switch (playerSide)
        {
            case PlayerSide.BLUE:
                changeableTextElement.text = "Blue";
                break;
            case PlayerSide.RED:
                changeableTextElement.text = "Red";
                break;
        }
    }
}
