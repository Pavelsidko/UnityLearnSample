using UnityEngine;
using UnityEngine.Events;

public class ObstacleItem : MonoBehaviour
{
    public float currentValue = 1f;
    public UnityEvent onDestroyObstacle;
    private Renderer render;

    private void Start()
    {
        render = GetComponent<Renderer>();
    }

    public void GetDamage(float value)
    {
        currentValue -= value;
        if (currentValue <= 0)
        {
            onDestroyObstacle.Invoke();
            Destroy(gameObject);
        }
        else
        {
            render.material.color = Color.Lerp(Color.red, Color.white, currentValue);
        }
    }
}
