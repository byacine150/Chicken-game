using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Fox : MonoBehaviour
{

    private GameObject poulet;

    [SerializeField] private Transform[] objectifs;

    private int indiceObjectifs;

    private NavMeshAgent agentAI;

    private Animator animationFox;
    // Start is called before the first frame update
    void Start()
    {
        animationFox = GetComponent<Animator>();
        poulet = GameObject.Find("Poulet");
        agentAI = GetComponent<NavMeshAgent>();
        indiceObjectifs = 0;
        agentAI.SetDestination(objectifs[indiceObjectifs].position);
      

    }

    // Update is called once per frame
    void Update()

    {

      

        if (!agentAI.pathPending && agentAI.remainingDistance <= agentAI.stoppingDistance)
        {
            indiceObjectifs = (indiceObjectifs + 1) % objectifs.Length;
            agentAI.SetDestination(objectifs[indiceObjectifs].position);
         




        }









        bool pouletVisible = Utilitaires.ProieVisible(gameObject, poulet, 5.0f, 80.0f, new Vector3(0, 1, 1));




        if (pouletVisible)
        
        {
            agentAI.SetDestination(poulet.transform.position);

            Debug.Log("Je te vois ");
            Debug.Log("Je te vois ");
            Debug.Log("Je te vois ");
            Debug.Log("Je te vois ");
            Debug.Log("Je te vois ");
            Debug.Log("Je te vois ");
            Debug.Log("Je te vois ");
            Debug.Log("Je te vois ");
        }

        else
        {

            if (!agentAI.pathPending && agentAI.remainingDistance <= agentAI.stoppingDistance)
            {
                indiceObjectifs = (indiceObjectifs + 1) % objectifs.Length;
                agentAI.SetDestination(objectifs[indiceObjectifs].position);





            }

        }


    }

   

}
