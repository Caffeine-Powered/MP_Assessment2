using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ChangeScene : MonoBehaviour
{
private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Token")
        {
            //gameObject.GetComponent<AudioSource>().PlayOneShot(zombiesAudio);
            SceneManager.LoadSceneAsync(1);
        }
    }
}
