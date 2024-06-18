using UnityEngine;

public class RadialTrigger : MonoBehaviour
{
    private float nextCheckTime = 0;

    [SerializeField]
    private float checkInterval = 0.5f;

    [SerializeField]
    private float boundaryRadius = 1;

    [SerializeField]
    private Transform target;

    [SerializeField]
    private float distanceFromTarget;

    private bool isInsideBoundary = false;

    private void Update()
    {
        if (Time.time > nextCheckTime)
        {
            nextCheckTime = Time.time + checkInterval;
            CheckByDistance(target.position);
        }
    }

    private void CheckByDistance(Vector3 targetPosition)
    {
        distanceFromTarget = Vector3.Distance(target.position, transform.position);
        isInsideBoundary = distanceFromTarget <= boundaryRadius;
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, 1);

        if (target)
        {
            if (nextCheckTime == 0)
            {
                CheckByDistance(target.position);
            }
            
            Gizmos.color = isInsideBoundary ? Color.red : Color.green;
            Gizmos.DrawLine(transform.position, target.position);
        }
    }
}