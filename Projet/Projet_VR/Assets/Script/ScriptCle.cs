using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptCle : MonoBehaviour
{
    public void OnTriggerEnter(Collider other){
        if(other.tag == "cle"){
            SceneManager.LoadScene("Escape");
        }
    }
}
