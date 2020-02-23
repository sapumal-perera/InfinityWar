using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class command : MonoBehaviour
{
    public Transform brick;

    // Start is called before the first frame update
    void Start()
    {
      
            for (int x = -200; x < 200; x++)
            {
            Instantiate(brick, new Vector3(x, 0.5f, -200), Quaternion.identity);
            //cube.transform.position = new Vector3(x, 1, 1);
                
            }
        for (int z = -200; z < 200; z++)
        {
           
            Instantiate(brick, new Vector3(-200, 0.5f, z), Quaternion.identity);
         
            
        }
        for (int z = -200; z < 200; z++)
        {
            Instantiate(brick, new Vector3(200, 0.5f, z), Quaternion.identity);
        
           
        }
        for (int x = -200; x < 200; x++)
        {
            Instantiate(brick, new Vector3(x, 0.5f, 200), Quaternion.identity);
          
        }

        for (int x = -200; x < 200; x++)
        {
            Instantiate(brick, new Vector3(x, 1.5f, -200), Quaternion.identity);
          //  cube.transform.position = new Vector3(x, 1, 1);

        }
        for (int z = -200; z < 200; z++)
        {

           Instantiate(brick, new Vector3(-200, 1.5f, z), Quaternion.identity);


        }
       for (int z = -200; z < 200; z++)
       {
            Instantiate(brick, new Vector3(200, 1.5f, z), Quaternion.identity);


       }
       for (int x = -200; x < 200; x++)
        {
           Instantiate(brick, new Vector3(x, 1.5f, 200), Quaternion.identity);

       }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
