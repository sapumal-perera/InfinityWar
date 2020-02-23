using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public Transform player;
    public Transform bullet;
    public Transform smallBullet;
    public float speed = 200;
    Vector3 playerPlace;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        playerPlace.y = transform.position.y + 3;
        playerPlace.x = transform.position.x;
        playerPlace.z = transform.position.z;
        if (Input.GetKeyDown(KeyCode.Space))
        {
          //  bullet.AddForce(0, 0, 3000);
            Transform instaantiateprojecttile = Instantiate(bullet, playerPlace, transform.rotation);
           // instaantiateprojecttile. = transform.TransformDirection(new Vector3(0, 0, speed));
            // bullet.rotation.Set(0.174f, 92.842f, 90.2f, 0f);

        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            //  bullet.AddForce(0, 0, 3000);
            Transform instaantiateprojecttile = Instantiate(smallBullet, playerPlace, transform.rotation);
          //  instaantiateprojecttile.velocity = transform.TransformDirection(new Vector3(0, 0, speed));
            // bullet.rotation.Set(0.174f, 92.842f, 90.2f, 0f);

        }
    }
}
