using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VibrateChair : MonoBehaviour
{
   
   
   [SerializeField] float duration=5f;
   
   
    private Animator animator;
     private float Timer;

    
    
    void Start()
    {
        animator=GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Timer+=Time.deltaTime;


        if(Timer>duration){

            animator.SetTrigger("Vibrate");
            Timer=0.0f;
            
            
        }


        
    }


    void OnMouseDown(){


        GameManager._instance.SetClicked(true);
    }
}
