using UnityEngine;

public class MS_ : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5.0f;

    void Start()
    {
        Debug.Log("MS_Mover script has started.");
        PrintInstructions();
    }

    void Update()
    {
        MovePlayer();
    }

    void PrintInstructions()
    {
        Debug.Log("Welcome to the game!");
        Debug.Log("Use WASD or arrow keys to move the Dodgy.");
        Debug.Log("Don't bump into walls!");
    }

    void MovePlayer()
    { 
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float yValue = 0.0f;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        transform.Translate(xValue, yValue, zValue);
    }
}
