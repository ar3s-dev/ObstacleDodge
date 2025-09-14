using UnityEngine;

public class MS_ : MonoBehaviour
{
    float xValue = 0.0f;
    float yValue = 0.01f;
    float zValue = 0.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("MS_Mover script has started.");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(xValue, yValue, zValue);
    }
}
