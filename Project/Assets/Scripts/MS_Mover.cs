using UnityEngine;

public class MS_ : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("MS_Mover script has started.");
    }

    // Update is called once per frame
    void Update()
    {
        float xValue = Input.GetAxis("Horizontal");
        float yValue = 0.0f;
        float zValue = Input.GetAxis("Vertical");

        transform.Translate(xValue, yValue, zValue);
    }
}
