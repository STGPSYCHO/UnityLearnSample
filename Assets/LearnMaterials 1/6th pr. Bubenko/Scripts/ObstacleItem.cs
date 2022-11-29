using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UIElements;

public class ObstacleItem : MonoBehaviour
{
    private Renderer rend;
    private float changeSpeed = 0.2f;

    [Range(0f, 1f)]
    [SerializeField]
    private float currentValue;
    private Color currentColor;
    //private static float damage = 0.005f;

    //[SerializeField]
    private UnityEvent onDestroyObstacle;

    [SerializeField]
    [ContextMenu("Сделать дамаг")]
    public void GetDamage(float value)//  Доделать , чтобы сюда приходило значение.
    {
        currentValue -= value;
        transform.GetComponent<Renderer>().material.color = Color.Lerp(currentColor, Color.red, 1-currentValue);
        if (currentValue <= 0.01f)
        {
            onDestroyObstacle.Invoke();
        }
    }

    void Start()
    {
        currentColor = transform.GetComponent<Renderer>().material.color;
        onDestroyObstacle = new UnityEvent();
        onDestroyObstacle.AddListener(() => Destroy(gameObject, 1));
    }
}
