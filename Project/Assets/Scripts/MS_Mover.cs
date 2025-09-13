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
        transform.Translate(0.01f, 0, 0);
    }
}
