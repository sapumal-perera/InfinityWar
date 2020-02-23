using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveByForce : MonoBehaviour
{
    public Rigidbody player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.A))
        {

            player.AddForce(0, 0, 20);
        }
    }
}
