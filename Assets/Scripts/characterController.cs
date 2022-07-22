using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterController : MonoBehaviour
{
    //Atributo
    public Animator animator;
    //Vectores de Dirección
    
    //public Vector3 resultante;
  
    
    

    // Start is called before the first frame update
    void Start()
    {
        animator = this.GetComponent<Animator>();  

      
        
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
         
        
       // resultante = player + up * p - forward * q;

        if(Input.GetKeyUp(KeyCode.UpArrow))
        {
            animator.SetBool("isWalkink", false);
        }
        if(Input.GetKeyUp(KeyCode.DownArrow))
        {
            animator.SetBool("isBackWards", false);
        }
        if(Input.GetKeyUp(KeyCode.RightArrow))
        {
            animator.SetBool("isRight", false);
        }
        if(Input.GetKeyUp(KeyCode.LeftArrow))
        {
            animator.SetBool("isLeft", false);
        }

      
        

        //Girar a la derecha
        if(Input.GetKey(KeyCode.UpArrow))
        {
            animator.SetBool("isWalkink", true);
        }
        if(Input.GetKey(KeyCode.DownArrow))
        {
            animator.SetBool("isBackWards", true);
        }
        if(Input.GetKey(KeyCode.RightArrow))
        {
            animator.SetBool("isRight", true);
        }
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            animator.SetBool("isLeft", true);
        }
        //Girar a la izquierda
        

        
    }
}
