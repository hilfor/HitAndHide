using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class ChangeableColor : MonoBehaviour, IChangeableUI
{
    public Image imageElement;

    public void ChangeUi(PlayerSide playerSide)
    {
        switch (playerSide)
        {
            case PlayerSide.BLUE:
                imageElement.color = Color.blue;
                break;
            case PlayerSide.RED:
                imageElement.color = Color.red;
                break;
        }
    }
}
