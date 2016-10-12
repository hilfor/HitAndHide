using UnityEngine;
using System.Collections;

public enum PlayerSide
{
    RED,
    BLUE
}

[RequireComponent(typeof(ChangeUI))]
public class PlayerMonitor : MonoBehaviour
{

    public PlayerSide playerSide;

    private ChangeUI changeUIComponent;

    void Start()
    {
        changeUIComponent = (ChangeUI)gameObject.GetComponent<ChangeUI>();
    }

    public void SetPlayerSide(PlayerSide playerSide)
    {
        this.playerSide = playerSide;
        changeUIComponent.ChangeUi(playerSide);
    }

}
