using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace scoreCounter
{

    public class ScoreCount : MonoBehaviour
    {
        public static int pointCount;
        public Transform player;
        public  Text points;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            points.text = "Score: " + pointCount.ToString();
        }
    }
}