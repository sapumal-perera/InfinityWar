using UnityEngine;
using System.Collections;

public class Unit : MonoBehaviour
{
    const float minPathUpdateTime = .2f;
    const float pathUpdateMoveThreshold = .5f;

    public Transform target;
    public Transform secondTarget;
    private Transform currentTarget;
    public Transform player;
    float speed = 20;
    Vector3[] path;
    int targetIndex;

    void Start()
    {
        currentTarget = target;
        StartCoroutine (UpdatePath());
    }

    public void OnPathFound(Vector3[] newPath, bool pathSuccessful)
    {
        if (pathSuccessful)
        {
            path = newPath;
            targetIndex = 0;
            StopCoroutine("FollowPath");
            StartCoroutine("FollowPath");
        }
    }
    IEnumerator UpdatePath()
    {
        if (Time.timeSinceLevelLoad < .3f)
        {
            yield return new WaitForSeconds(.3f);
        }
        PathRequestManager.RequestPath(transform.position, currentTarget.position, OnPathFound);
        float sqrMoveThreshold = pathUpdateMoveThreshold * pathUpdateMoveThreshold;
        Vector3 targetPosOld = currentTarget.position;
        while (true)
        {
            yield return new WaitForSeconds(minPathUpdateTime);
            if((currentTarget.position - targetPosOld).sqrMagnitude > sqrMoveThreshold) {
                PathRequestManager.RequestPath(transform.position, currentTarget.position, OnPathFound);
                targetPosOld = currentTarget.position;
            }
           
        }
    }

    IEnumerator FollowPath()
    {
        Vector3 currentWaypoint = path[0];
        while (true)
        {
            if (transform.position == currentWaypoint)
            {
                targetIndex++;
                if (targetIndex >= path.Length)
                {
                    yield break;
                }
                currentWaypoint = path[targetIndex];
            }

            transform.position = Vector3.MoveTowards(transform.position, currentWaypoint, speed * Time.deltaTime);
            if(Vector3.Distance(player.position, transform.position) < 100f)
            {
                currentTarget = player;

            }
            else { 
            if (target)
            {
                float dist = Vector3.Distance(target.position, transform.position);
               // print("Distance to 1: " + dist);
                if (dist < 50.5f)
                {
                    currentTarget = secondTarget;
                }
            }

            if (secondTarget) {
                float dist2 = Vector3.Distance(secondTarget.position, transform.position);
             //   print("Distance to 2: " + dist2);
                if (dist2 < 50.5f)
                {
                    currentTarget = target;
                }
            }
            }
            yield return null;

        }
    }

    public void OnDrawGizmos()
    {
        if (path != null)
        {
            for (int i = targetIndex; i < path.Length; i++)
            {
                Gizmos.color = Color.black;
               // Gizmos.DrawCube(path[i], Vector3.one);

                if (i == targetIndex)
                {
                   // Gizmos.DrawLine(transform.position, path[i]);
                }
                else
                {
                   // Gizmos.DrawLine(path[i - 1], path[i]);
                }
            }
        }
    }
}
