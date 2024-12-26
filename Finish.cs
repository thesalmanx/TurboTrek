using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Finish : MonoBehaviour
{
    //public GameManager gameManager;
     void OnTriggerEnter()
    {
        //gameManager.completeLevel();
        FindObjectOfType<GameManager>().completeLevel();
    }

}
