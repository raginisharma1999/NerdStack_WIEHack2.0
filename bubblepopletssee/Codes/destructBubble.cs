using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using System;
public class destructBubble : MonoBehaviour
{
    // Start is called before the first frame update
    public Renderer rend;
   
    void Start()
    {
       //displays the bubbles on screen
        rend = GetComponent<Renderer>();
        rend.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
       
        
    }

 

    public AudioSource myFx;
    public AudioClip clickFx;
    

    void OnMouseDown()
    {
        myFx.PlayOneShot(clickFx); //plays soothing sound effect
         rend.enabled = false;  //makes the bubble invisible

       



    }

   
}

