using UnityEngine;
using System.Collections;

public class PlayerController : Photon.MonoBehaviour
{


    public GameObject bullet;
    public Transform gunNozzle;
    public bool waitForReload = true;

    private bool reloading = false;
    private float reloadTime = 0f;
    private string bulletPrefabName;
    void Start()
    {
        bulletPrefabName = bullet.name;
    }

    // Update is called once per frame
    void Update()
    {
        if (!reloading)
        {
            if (Input.GetMouseButton(0))
            {
                //PhotonNetwork.Instantiate(bulletPrefabName, gunNozzle.position,gunNozzle.rotation, 0);
                GameObject spawnedBullet = (GameObject)Instantiate(bullet, gunNozzle.position, gunNozzle.rotation);
                if (waitForReload)
                {
                    reloadTime = spawnedBullet.GetComponent<BulletController>().reloadTime;
                    StartCoroutine("WaitForReload");
                }
            }
        }
    }

    IEnumerator WaitForReload()
    {
        reloading = true;
        yield return new WaitForSeconds(reloadTime);
        reloading = false;
    }
}
