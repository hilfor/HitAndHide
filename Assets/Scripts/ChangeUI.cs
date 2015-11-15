using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class ChangeUI : MonoBehaviour, IChangeableUI {

    public Text[] changeableTextObjects;
    public IChangeableUI[] changeableComponentsObjects;
    

    public void ChangeUi(PlayerSide playerSide)
    {
        foreach(Text changeableText in changeableComponentsObjects)
        {
            switch (playerSide)
            {
                case PlayerSide.RED:
                    changeableText.text = "RED";
                    break;
                case PlayerSide.BLUE:
                    changeableText.text = "BLUE";
                    break;
            }
        }

        foreach(IChangeableUI changeableComponent in changeableComponentsObjects)
        {
            changeableComponent.ChangeUi(playerSide);
        }
    }

}
