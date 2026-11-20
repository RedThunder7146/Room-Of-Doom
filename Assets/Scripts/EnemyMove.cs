using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float speed;
    public Transform target;
    public float minDist;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (target == null)
        {

            if (GameObject.FindWithTag("Player") != null)
            {
                target = GameObject.FindWithTag("Player").GetComponent<Transform>();
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        


        transform.LookAt(target);


        float distance = Vector3.Distance(transform.position, target.position);


        if (distance < minDist)
            transform.position += transform.forward * speed * Time.deltaTime;

    }
}
