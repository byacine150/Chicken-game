using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Comptermonstres : MonoBehaviour
{

    private GameObject[] grains;

    // Start is called before the first frame update
    void Start()
    {
        grains = GameObject.FindGameObjectsWithTag("Grains");
        Debug.Log("Il y a " + grains.Length + " grains");
    }

    // Update is called once per frame
    void Update()
    {
        int Score = 0;

        for (int i = 0; i < grains.Length; i++)
        {
            if (grains[i] == null)
            {
                Score++;
            }
        }





        if (Score == grains.Length)
        {
            SceneManager.LoadScene("Victoire");
        }
    }
}
