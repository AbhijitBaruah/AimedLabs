using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FadeAlpha : MonoBehaviour
{
    [SerializeField] float fadeSpeed=0.3f;

    [SerializeField] bool isPanel=true;

    private bool fadeIn=false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   

        if(GameManager._instance.GetClicked() && !fadeIn){
            fadeIn=true;
        }
        if(fadeIn){

            FadeIn(this.gameObject);
        }
        
    }

    void FadeIn(GameObject obj){

        if(isPanel){
       Color objectColor=obj.GetComponent<Image>().color;
       float fadeAmount= objectColor.a + (fadeSpeed*Time.deltaTime);
       objectColor = new Color(objectColor.r,objectColor.g,objectColor.b,fadeAmount);
        obj.GetComponent<Image>().color=objectColor;

        if(objectColor.a>=1){

            fadeIn=false;

        }


    }

    else{

        Color objectColor=obj.GetComponent<Text>().color;
       float fadeAmount= objectColor.a + (fadeSpeed*Time.deltaTime);
       objectColor = new Color(objectColor.r,objectColor.g,objectColor.b,fadeAmount);
        obj.GetComponent<Text>().color=objectColor;

        if(objectColor.a>=1){

            fadeIn=false;

        }


    }



    }
}
