using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
public class IA : MonoBehaviour
{
    public GameObject target;
    public GameObject esqueleto;
    public float distanciaMaxima,distanciaMinima;
    public Text puntaje;
    private float tiempo;

    void Update()
    {
        float distancia = Vector3.Distance(target.GetComponent<Transform>().position, esqueleto.GetComponent<Transform>().position);
        Debug.Log(distancia);
        if (distancia >distanciaMaxima)
        //   8 <  5
        {
            //DETENER
            esqueleto.GetComponent<Animator>().SetBool("caminar", false);
            esqueleto.GetComponent<NavMeshAgent>().isStopped = true;
            esqueleto.GetComponent<NavMeshAgent>().ResetPath();
        }
        else if(distancia <distanciaMaxima && distancia >distanciaMinima)
        {
            //CAMINAR
            esqueleto.GetComponent<Animator>().SetBool("caminar", true);
            esqueleto.GetComponent<NavMeshAgent>().SetDestination(target.GetComponent<Transform>().position);
        }
        else if(distancia <distanciaMinima){
            esqueleto.GetComponent<Animator>().SetTrigger("atacar");
            esqueleto.GetComponent<NavMeshAgent>().isStopped = true;
            esqueleto.GetComponent<NavMeshAgent>().ResetPath();
            if(tiempo<Time.time){
                tiempo = Time.time + .5f;
                float puntos = float.Parse(puntaje.text)-10;
                puntaje.text = "" + puntos;
            }
        }
    }
}


//diastancia sea 10< disantai 
