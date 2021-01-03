using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 playerVelocity;
    private bool groundedPlayer;
    [SerializeField] public float playerSpeed = 10f; 
    [SerializeField] private float jumpHeight = 1f;
    [SerializeField] private float gravityValue = -15f;
    private float initialSpeed;
    private float powerUpTime = 5f;

    private void Start()
    {
        initialSpeed = playerSpeed;
        controller = gameObject.AddComponent<CharacterController>();
    }

    void Update()
    {
        if(transform.position.y < 0)
        {
            ManageScreens.gameOver = true;
        }

        if (playerSpeed != initialSpeed)
        {
            if (powerUpTime > 0)
            {
                powerUpTime -= Time.deltaTime;
                
            }
            else
            {
                Debug.Log("Power up time has run out!");
                powerUpTime = 5f;
                playerSpeed = initialSpeed;
            }
        }
        
        groundedPlayer = controller.isGrounded;
        if (groundedPlayer && playerVelocity.y < 0)
        {
            playerVelocity.y = 0f;
        }

        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        controller.Move(move * Time.deltaTime * playerSpeed);

        if (move != Vector3.zero)
        {
            gameObject.transform.forward = move;
        }

        // Changes the height position of the player..
        if (Input.GetButtonDown("Jump") && groundedPlayer)
        {
            playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
        }

        playerVelocity.y += gravityValue * Time.deltaTime;
        controller.Move(playerVelocity * Time.deltaTime);
    }

    private void CountDownPowerUp()
    {
        
    }
}