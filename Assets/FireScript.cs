using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireScript : MonoBehaviour
{
    // Start is called before the first frame update
   [SerializeField] private GameObject bullet;
   [SerializeField] private Transform spawnPoint;
   [SerializeField] private float bulletSpeed = 10f;


   public void FireBullet()
   {
    GameObject spawndBullet = Instantiate(bullet, spawnPoint.position, spawnPoint.rotation);
    spawndBullet.GetComponent<Rigidbody>().velocity = spawnPoint.forward * bulletSpeed;
    Destroy(spawndBullet, 5f);
   }

    // Update is called once per frame
    void Update()
    {
        
    }
}
