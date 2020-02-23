using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public Transform bullet;
    public Transform target;
    public float speed = 200;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (target)
        {
            float dist = Vector3.Distance(target.position, transform.position);
           // print("Distance to other: " + dist);
            if (dist < 10f) {
                Transform instaantiateprojecttile = Instantiate(bullet, transform.position, transform.rotation) ;
        
                // instaantiateprojecttile.velocity = transform.TransformDirection(new Vector3( target.position.x, 0, target.position.z));
            }
        }
    }
}
