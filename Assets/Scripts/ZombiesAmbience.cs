using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombies_Audio : MonoBehaviour
{
    public AudioClip ZombiesAudio
;
    
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
            gameObject.GetComponent<AudioSource>().PlayOneShot(ZombiesAudio);
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
