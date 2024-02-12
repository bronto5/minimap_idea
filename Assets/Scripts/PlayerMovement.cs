using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float playerSpeed;
    [SerializeField] float playerTurnSpeed;

    Vector2 moveVector;
    Vector3 m_EulerAngleVelocity;

    Rigidbody m_Rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {
        m_Rigidbody.velocity = transform.forward * moveVector.y * playerSpeed;
        transform.Rotate (0,moveVector.x * playerTurnSpeed,0, Space.Self);

       
    }

    public void OnMove(InputValue inputValue)
    {
        moveVector = inputValue.Get<Vector2>();
    }
}
