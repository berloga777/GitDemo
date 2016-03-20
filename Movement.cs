using UnityEngine;

//прототип движения змейки, по осям x,y,z

[RequireComponent(typeof(CharacterController))]
public class Movement : MonoBehaviour
{
    //скорость по умолчанию
    public float speed = 8;
    private CharacterController _controller;

    public void Start()
    {
        _controller = GetComponent<CharacterController>();
    }

    public void Update()
    {
        float y = 0;
        float x = 0;
        float z = 0;                      
                                                                           
        if (Input.GetKey(KeyCode.W)) z = 1;
        if (Input.GetKey(KeyCode.S)) z = -1;

        if (Input.GetKey(KeyCode.UpArrow)) y = 1;
        if (Input.GetKey(KeyCode.DownArrow)) y = -1;

        if (Input.GetKey(KeyCode.RightArrow)) x = -1;
        if (Input.GetKey(KeyCode.LeftArrow)) x = 1;

        _controller.Move(transform.forward * speed * Time.deltaTime * y);
        _controller.Move(transform.right * speed * Time.deltaTime * x);
        _controller.Move(transform.up * speed * Time.deltaTime * z);
    }
}
