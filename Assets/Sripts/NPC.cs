using UnityEngine;
using UnityEngine.AI;

public class NPC : MonoBehaviour
{
    public NavMeshAgent aiAgent;
    public float speed = 3.5f;
    public Transform[] target;
    Transform targetPoint;
    float distance;

 /// [Header("Animaciones")]
 /// public Animator animator;
 /// public string walkingAnim;


    void Start()
    {
        targetPoint = target[Random.Range(0, target.Length)];
     ///animator.Play(walkingAnim);
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(transform.position, targetPoint.position);
        if(distance < 2f)
        {
            targetPoint = target[Random.Range(0, target.Length)];
        }
        aiAgent.SetDestination(targetPoint.position);
        aiAgent.speed = speed;
    }
}
