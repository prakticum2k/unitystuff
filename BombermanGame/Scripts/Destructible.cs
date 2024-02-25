using UnityEditor;
using UnityEngine;

public class Destructible : MonoBehaviour
{
    public float destructionTime = 1f;

    public void Start()
    {
        Destroy(gameObject, destructionTime);
    }

}
