using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieDeath : MonoBehaviour
{
    public Animator animator;
    public AudioClip zombiesDeathAudio;
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
        if(other.tag == "Shoot")
        {
            gameObject.GetComponent<AudioSource>().PlayOneShot(zombiesDeathAudio);
            animator.SetTrigger("Death");
        }
    }
}


