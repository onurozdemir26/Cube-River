using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPlayer : MonoBehaviour
{
    [SerializeField] PlayerManager playerManager;

    private Rigidbody rb;

    [SerializeField]bool isGrounded;
    
    int maxPlatform = 0;

    // Start is called before the first frame update
    void Start()
    {
        rb= GetComponent<Rigidbody>();
        GetComponent<Renderer>().material = playerManager.collectedObjMat;

        playerManager.collidedList.Add(gameObject);


    }
     void Update()
    {
        //if (transform.position.z > 82)
        //{
        //    gameOverScreen.Setup(maxPlatform);
        //}
    }

    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.CompareTag("Ground")) {
            Grounded();
        }
        

    }
   /* private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Hole"))
        {
            GameOverScreen();
        }
    }

    */


    void Grounded() {
        isGrounded=true;
        playerManager.playerState = PlayerManager.PlayerState.Move;
        rb.useGravity=false;
        rb.constraints=RigidbodyConstraints.FreezeAll;

        Destroy(this,1);
    }
    /*void GameOverScreen()
    {
        gameOverScreen.gameObject.SetActive(true);

    }
    */
    
}
