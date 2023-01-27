using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ContactPoulet : MonoBehaviour
{

    private GameObject Poulet;
    bool modechasseur;
    // Start is called before the first frame update
    void Start()
    {
        Poulet = GameObject.Find("Poulet");
        modechasseur = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Z))
        {
            modechasseur = true;
        }

       
        

    }

   
    public void OnTriggerEnter(Collider other)
    {


        if (other.gameObject == Poulet)
        {
            if (modechasseur == true) 
            { 
                        Destroy(gameObject);

            }

            if (modechasseur == false)
            {
                SceneManager.LoadScene("Defaite");
            }
        }


    }
}
