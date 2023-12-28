using UnityEngine;

public class InteractiveRaycast : MonoBehaviour
{
    public GameObject prefab;
    private InteractiveBox currentBox;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.CompareTag("InteractivePlane"))
                {
                    Vector3 position = hit.point + hit.normal * (prefab.transform.localScale.y / 2);
                    GameObject boxObject = Instantiate(prefab, position, Quaternion.identity);
                }
                else
                {
                    InteractiveBox box = hit.collider.GetComponent<InteractiveBox>();
                    if (box != null)
                    {
                        if (currentBox == null)
                        {
                            currentBox = box;
                        }
                        else
                        {
                            currentBox.AddNext(box);
                            currentBox = null;
                        }
                    }
                }
            }
        }
        else if (Input.GetMouseButtonDown(1))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                InteractiveBox box = hit.collider.GetComponent<InteractiveBox>();
                if (box != null)
                {
                    Destroy(box.gameObject);
                }
            }
        }
    }
}
