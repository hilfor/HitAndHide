using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class ChangeUI : MonoBehaviour, IChangeableUI
{

    //public GameObject[] changeableObjects;
    //private ArrayList changeableComponentsObjects = new ArrayList();
    private IChangeableUI[] changeableComponentsObjects;

    void Start()
    {
        //changeableComponentsObjects = new ArrayList();
        //foreach (GameObject changeableObj in changeableObjects)
        //{
        //    changeableComponentsObjects.Add(changeableObj);
        //}
    }

    public void setChangeableObjects(IChangeableUI[] cComponents)
    {
        changeableComponentsObjects = cComponents;
    }

    public void ChangeUi(PlayerSide playerSide)
    {
        foreach (IChangeableUI changeableComponent in changeableComponentsObjects)
        {
            changeableComponent.ChangeUi(playerSide);
        }
    }

}
