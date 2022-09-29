using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Axe_Attack : MonoBehaviour
{
    bool attacking = false;
   
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && !attacking)
        {
            
            attacking = true;
            hit();
        }


    }

    void hit()
    {
        while (transform.rotation.x > 0);
        Rotate(600);
    }
    private void Rotate(float rotationThisFrame)
    {
        transform.Rotate(Vector3.down * rotationThisFrame * Time.deltaTime);
        attacking = false;
        Debug.Log("is working");

    }
}
