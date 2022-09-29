using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Axe_Attack : MonoBehaviour
{
    bool attacking = false;
    float attacktimerBase = 100;
    float attacktimer = 0;
    
   
    
    // Start is called before the first frame update
    void Start()
    {
       attacktimer = attacktimerBase;

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && !attacking)
        {
            attacking = true;
           
        }

        if(attacking)
        {
           if(attacktimer > 0)
            {
                Rotate(200);
                attacktimer -= 1;
                Debug.Log(attacktimer);
            }
           if(attacktimer <= 0)
            {
                attacking = false;
                attacktimer = attacktimerBase;

            }
        }

    }

  
    private void Rotate(float rotationThisFrame)
    {
        transform.Rotate(Vector3.down * rotationThisFrame * Time.deltaTime);

    }
}
