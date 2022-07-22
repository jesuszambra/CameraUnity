using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    //Posición de la cámara
    public Transform posCamera;
    public Vector3 Forward, Up, Player; 
    public Vector3 Resultante;
    public float p=1.0f;
    public float q=1.0f;
   public float y;
   
    
    // Start is called before the first frame update
    void Start()
    {
        //Rots = transform.rotation;
        Player = transform.position;
        Up = transform.up;
        Forward = transform.forward;
       
    }

    // Update is called once per frame
    void Update()
    {
       
        Player = transform.position;
        Up = transform.up;
        Forward = transform.forward;   

        Resultante = Player + Up * p - Forward * q;
        posCamera.position = Resultante;


        
    }
}
