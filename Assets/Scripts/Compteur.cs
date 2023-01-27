using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Compteur : MonoBehaviour
{
    [SerializeField] public Text compteur;
    
    // Start is called before the first frame update
    void Start()
    {

            
    }

    // Update is called once per frame
    void Update()
    {

        compteur.text = GameObject.FindGameObjectsWithTag("Grains").Length.ToString();
    }
}
