using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] PlayerManager playerManager;
    [SerializeField] float movementSpeed;
    [SerializeField] float controlSpeed;
    
    [SerializeField] bool isTouching;
    float touchPosX;
    Vector3 direction;
    public LevelUp gameOverScreen;
    int maxPlatform = 0;

    void Start()
    {

    }


    void Update()
    {
        GetInput();
        if (transform.position.z > 90)
        {
            gameOverScreen.Setup(maxPlatform);
        }
    }

    private void FixedUpdate()
    {

        if (playerManager.playerState == PlayerManager.PlayerState.Move)
        {
            transform.position += Vector3.forward * movementSpeed * Time.fixedDeltaTime;
        }
        if (isTouching)
        {
            touchPosX += SimpleInput.GetAxis("Horizontal") * controlSpeed * Time.fixedDeltaTime;
        }

        transform.position = new Vector3(touchPosX, transform.position.y, transform.position.z);
    }

    void GetInput()
    {
        if (SimpleInput.GetMouseButton(0))
        {
            isTouching = true;
        }
        else
        {
            isTouching = false;
        }
    }

    
}
