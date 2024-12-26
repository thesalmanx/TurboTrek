using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class Collision : MonoBehaviour
{
    public GameObject completeLevelUI;
    private static int count = 25;
    public Text score;
    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
            if (collision.collider.tag == "Obstacle")
            {
            Debug.Log("We hit!!");
                   count--;
                score.text = count.ToString("0");
            }
    }
    void Update()
    {

    }
}
