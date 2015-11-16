using UnityEngine;
using System.Collections;

public enum PlayerSide
{
    RED,
    BLUE
}

public class PlayerMonitor : MonoBehaviour
{

    public PlayerSide playerSide;
    public GameObject[] changeableUiObjects;

    void Start()
    {

    }

    public void SetPlayerSide(PlayerSide playerSide)
    {
        this.playerSide = playerSide;
    }

    void FixedUpdate()
    {

        switch (playerSide)
        {
            case PlayerSide.BLUE:
                SetBlueUI();
                break;
            case PlayerSide.RED:
                SetRedUI();
                break;
        }

    }

    void SetRedUI()
    {

    }

    void SetBlueUI()
    {

    }



}
