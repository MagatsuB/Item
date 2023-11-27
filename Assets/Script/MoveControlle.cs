using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class MoveControlle : MonoBehaviour
{
    CharacterController _controller;
    [SerializeField] Vector3 _move;
    [SerializeField] float _speed;

    // Start is called before the first frame update
    void Start()
    {
        _controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        _controller.Move(new Vector3(_move.x, _controller.velocity.y, _move.y)* _speed *Time.deltaTime);
    }

    public void SetMove(InputAction.CallbackContext value)
    {
        _move = value.ReadValue<Vector3>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coletavel"))
        {

        }
    }
}
