using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCollider : MonoBehaviour
{
    public GameObject test;
    private BoxCollider otherCollider;
    public int damageValue;
    //  public SphereCollider otherSphere;
    // public SphereCollider sphereCollider;
    public bool colliding = false;
    // Start is called before the first frame update
    void Start()
    {
        otherCollider = test.GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        //The four corners of this box
        Vector3 min = GetComponent<BoxCollider>().bounds.min;
        Vector3 max = GetComponent<BoxCollider>().bounds.max;

        Vector3 otherMin = otherCollider.bounds.min;
        Vector3 otherMax = otherCollider.bounds.max;

        bool collides = !(max.x < otherMin.x || min.x > otherMax.x ||
         max.y < otherMin.y || min.y > otherMax.y ||
         max.z < otherMin.z || min.z > otherMax.z);

        if (collides)
        {
            Debug.Log("bullet hits");
            scoreCounter.ScoreCount.pointCount += damageValue;
        }
        else
        {
         //  Debug.Log("no bullet collisions");
        }
    }
}
