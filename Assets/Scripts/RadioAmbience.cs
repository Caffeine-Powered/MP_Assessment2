using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioAmbience : MonoBehaviour
{
    public AudioClip radioAmbience;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            gameObject.GetComponent<AudioSource>().PlayOneShot(radioAmbience);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            gameObject.GetComponent<AudioSource>().Stop();
        }
    }
}
