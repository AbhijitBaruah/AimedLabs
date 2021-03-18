using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager _instance;

    private bool clicked=false;

    [SerializeField] GameObject Furniture;
 

    public void SetClicked(bool b){


        clicked=b;
    }

    public bool GetClicked(){

        return clicked;
    }

    void Awake()
    {
        if(_instance==null){

            _instance=this;
        }   
    }

    // Update is called once per frame
    void Update()
    {
     if(clicked){

         Furniture.SetActive(false);     }   
    }
}
