using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfDonutScript : MonoBehaviour
{
    public float speed = 3f;
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Rotate(speed * Time.deltaTime / 0.01f,  0f, 0f, Space.Self); //Engeli rotasyonla x ekseninde döndürme işlemi
    }
}
