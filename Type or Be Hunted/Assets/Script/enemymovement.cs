using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemymovement : MonoBehaviour
{
    [Header("Main Setting")]
    public Animator anim;
    public float lookRadius = 13f;
    public UnityEngine.AI.NavMeshAgent enemy;
    private GameObject[] gameObjects;
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        enemy = GetComponent<UnityEngine.AI.NavMeshAgent>();
        
        gameObjects = GameObject.FindGameObjectsWithTag("Player");
        if (gameObjects.Length == 0)
        {
            Debug.Log("No game objects are tagged with 'Player'");
        }
        else{
            Debug.Log("Game Object Name =" + gameObjects[0]);
            player = gameObjects[0];
        }
    }

    // Update is called once per frame
    void Update()
    {

        float distance = Vector3.Distance(player.transform.position, transform.position);
        Vector3 temp = player.transform.position;
        if (distance <= lookRadius)
        {
            temp.y =  transform.position.y;
            transform.LookAt(temp);
            enemy.SetDestination(player.transform.position);
            if (temp != Vector3.zero  )
            {
                anim.SetBool("Seek",true);
            }
            else {
                anim.SetBool("Seek",false);
            }
        }
        if (distance <= 5f)
        {
            anim.SetBool("Attack",true);
        }
        else {
            anim.SetBool("Attack",false);
        }
    }

<<<<<<< HEAD


    void OnCollisionEnter(Collision collision)
    {
        Rigidbody rb = collision.collider.GetComponent<Rigidbody>();
        if(collision.gameObject.tag == TagObject){
            gameManager.TakeDamage(10);
            SoundManager.instance.Hit();
            Vector3 direction=player.transform.position - transform.position;
            direction.y = 0;
            rb.AddForce(direction.normalized*knockbackStrength, ForceMode.Impulse);
        }
    }

=======
>>>>>>> parent of 79a76f3 (knockback dll)
    /*private void OnTriggerEnter(Collider hit)
    {
        if (hit.tag == "Player")
        {
            hit.GetComponent<HealthBar>().TakeDamage(5);
        }
    }*/
}
