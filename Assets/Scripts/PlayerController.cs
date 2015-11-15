using UnityEngine;
using System.Collections;

public class PlayerController : Photon.MonoBehaviour {


    public GameObject bullet;
    public Transform gunNozzle;

    private string bulletPrefabName;
    void Start()
    {
        bulletPrefabName = bullet.name;
    }
    
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButton(0))
        {
            PhotonNetwork.Instantiate(bulletPrefabName, gunNozzle.position,gunNozzle.rotation, 0);
        }
	}
}
