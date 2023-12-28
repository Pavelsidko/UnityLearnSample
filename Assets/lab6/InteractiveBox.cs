using UnityEngine;

public class InteractiveBox : MonoBehaviour
{
    public InteractiveBox next;

    public void AddNext(InteractiveBox box)
    {
        next = box;
        Debug.DrawLine(transform.position, next.transform.position, Color.red);
    }

    private void Update()
    {
        if (next != null)
        {
            Debug.DrawLine(transform.position, next.transform.position, Color.red);
            RaycastHit hit;
            if (Physics.Linecast(transform.position, next.transform.position, out hit))
            {
                ObstacleItem obstacle = hit.collider.GetComponent<ObstacleItem>();
                if (obstacle != null)
                {
                    obstacle.GetDamage(Time.deltaTime);
                }
          
            }
        }

    }
}
