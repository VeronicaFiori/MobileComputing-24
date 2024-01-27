using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [Header("Movement stuff")]
    public float moveSpeed;
    public Vector2 directionToMove;

    [Header("LifeTime")]
    public float lifeTime;
    private float lifeTimeSeconds;
    public Rigidbody2D myRigidBody;
    // Start is called before the first frame update
    void Start()
    {
        myRigidBody= GetComponent<Rigidbody2D>();
        lifeTimeSeconds = lifeTime;
    }

    // Update is called once per frame
    void Update()
    {
        lifeTimeSeconds -= Time.deltaTime;
        if(lifeTimeSeconds <= 0)
        {
            Destroy(this.gameObject);
        }
    }
    public void Launch(Vector2 initialvel)
    {
        myRigidBody.velocity = initialvel*moveSpeed;
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(this.gameObject);
    }
}
