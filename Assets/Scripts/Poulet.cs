using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Poulet : MonoBehaviour
{
    [SerializeField] private float vitesseMarche;
    [SerializeField] private float vitesseTourner;
    bool mange;
    float mag;
    bool automange;
    float[] compteurdeux = new float[9];


    private Animator animationPoulet;
    CharacterController controleur;
    // Start is called before the first frame update
    void Start()
    {
        animationPoulet = GetComponent<Animator>();
        controleur = GetComponent<CharacterController>();
        automange = false;

    }

    // Update is called once per frame
    void Update()
    {

    


  

        

        float horizontal = Input.GetAxis("Horizontal") * Time.deltaTime ;
        float vertical = Input.GetAxis("Vertical") * Time.deltaTime * vitesseMarche;


        Vector3 deplacement = new Vector3(0, 0, vertical);
        deplacement = transform.TransformDirection(deplacement);






        //calcul nouvelles positions
        //float positionX = transform.position.x + horizontal;
        //float positionZ = transform.position.z + vertical;

        //Vector3 nouvellePosition = new Vector3(positionX, transform.position.y, positionZ);

        Vector3 nouvellePosition = transform.position + deplacement;
        float distance = Vector3.Distance(nouvellePosition, Vector3.zero);

        transform.Rotate(Vector3.up, horizontal * vitesseTourner);

      //  Debug.Log(distance);


        
        
        if (distance < 22.5f)
        {
            controleur.Move(deplacement);
        }


        bool entreeAxeHorizontal = !Mathf.Approximately(horizontal, 0f);
        bool entreeAxeVertical = !Mathf.Approximately(vertical, 0f);


        Vector3 descendre = Vector3.down * 9.81f * Time.deltaTime;
        controleur.Move(descendre);

      

        if (entreeAxeHorizontal || entreeAxeVertical)
        {
            animationPoulet.SetBool("Walk", true);
        }
        else
        {
            animationPoulet.SetBool("Walk", false);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            animationPoulet.SetBool("Eat", true);
          

        } 
        else
        {

            animationPoulet.SetBool("Eat", false);

        }
        if (animationPoulet.GetBool("Eat"))
        {
            mange = true;

        }
        else 
        {
            mange = false;

        }


        if (Input.GetKey(KeyCode.X))
        {
            automange = true;
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            vitesseMarche = 10;
           vitesseTourner = 120;
            animationPoulet.SetBool("Walk", false);
            animationPoulet.SetBool("Run", true);
        }
        else
        {
            vitesseMarche = 5;
            vitesseTourner = 100;
            animationPoulet.SetBool("Run", false);

        }

    }

 //Le spaghetti code commence ici


    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.layer == 8 && mange)
        {


            compteurdeux[0] += Time.deltaTime;
            Debug.Log(compteurdeux[0]);

            if (compteurdeux[0] > 2)
            {
                Destroy(other.gameObject);
            }


        }


        if (other.gameObject.layer == 9 && mange)
        {


            compteurdeux[1] += Time.deltaTime;
            Debug.Log(compteurdeux[1]);

            if (compteurdeux[1] > 2)
            {
                Destroy(other.gameObject);
            }


        }


        if (other.gameObject.layer == 10 && mange)
        {


            compteurdeux[2] += Time.deltaTime;
            Debug.Log(compteurdeux[2]);

            if (compteurdeux[2] > 2)
            {
                Destroy(other.gameObject);
            }


        }


        if (other.gameObject.layer == 11 && mange)
        {


            compteurdeux[3] += Time.deltaTime;
            Debug.Log(compteurdeux[3]);

            if (compteurdeux[3] > 2)
            {
                Destroy(other.gameObject);
            }


        }


        if (other.gameObject.layer == 12 && mange)
        {


            compteurdeux[4] += Time.deltaTime;
            Debug.Log(compteurdeux[4]);

            if (compteurdeux[4] > 2)
            {
                Destroy(other.gameObject);
            }


        }


        if (other.gameObject.layer == 13 && mange)
        {


            compteurdeux[5] += Time.deltaTime;
            Debug.Log(compteurdeux[5]);

            if (compteurdeux[5] > 2)
            {
                Destroy(other.gameObject);
            }


        }


        if (other.gameObject.layer == 14 && mange)
        {


            compteurdeux[6] += Time.deltaTime;
            Debug.Log(compteurdeux[6]);

            if (compteurdeux[6] > 2)
            {
                Destroy(other.gameObject);
            }


        }

        if (other.gameObject.layer == 15 && mange)
        {


            compteurdeux[7] += Time.deltaTime;
            Debug.Log(compteurdeux[7]);

            if (compteurdeux[7] > 2)
            {
                Destroy(other.gameObject);
            }


        }

        if (other.gameObject.layer == 16 && mange)
        {


            compteurdeux[8] += Time.deltaTime;
            Debug.Log(compteurdeux[8]);

            if (compteurdeux[8] > 2)
            {
                Destroy(other.gameObject);
            }


        }




        if (other.gameObject.layer == 8 || other.gameObject.layer == 9 || other.gameObject.layer == 10 || other.gameObject.layer == 11 || other.gameObject.layer == 12 || other.gameObject.layer == 13 || other.gameObject.layer == 14 || other.gameObject.layer == 15 || other.gameObject.layer == 16)
        {

            if (automange)
            {

                Destroy(other.gameObject);
            }
        }




    }





}
