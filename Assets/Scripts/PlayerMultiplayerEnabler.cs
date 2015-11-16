using UnityEngine;

using Photon;
using System.Collections;

public class PlayerMultiplayerEnabler :  Photon.MonoBehaviour{

    public Component[] enableOnLocal;


	// Use this for initialization
	void Start () {
        
	
        if (photonView.isMine)
        {
            if (enableOnLocal.Length > 0)
            {
                foreach (Component enableThis in enableOnLocal)
                {
                    if (enableThis is Behaviour)
                        (enableThis as Behaviour).enabled = true;
                    else if (enableThis is Collider)
                        (enableThis as Collider).enabled = true;
                    else if (enableThis is Renderer)
                        (enableThis as Renderer).enabled = true;
                }
            }
        }
	}
	
}
