using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NemicoLanciatore : UomoDiPietra
{

    public GameObject projectile;
    public float delay;
    private float delaySeconds;
    public bool can = true;

    public void Update()
    {
        delaySeconds -= Time.deltaTime;
        if (delaySeconds <= 0)
        {
            can = true;
            delaySeconds = delay;
        }
    }
    public override void CheckDistance()
    {
        if (Vector3.Distance(target.position, transform.position) <= chaseRadius
         && Vector3.Distance(target.position, transform.position) > attackRadius)
        {
            if (currentState == EnemyState.idle || currentState == EnemyState.walk
                && currentState != EnemyState.stagger)
            {
                if (can)
                {
                    Vector3 tempVector = target.transform.position - transform.position;
                    GameObject current = Instantiate(projectile, transform.position, Quaternion.identity);
                    current.GetComponent<Projectile>().Launch(tempVector);
                    can = false;
                    ChangeState(EnemyState.walk);
                    anim.SetBool("wakeUp", true);
                }
            }
        }
        else if (Vector3.Distance(target.position, transform.position) > chaseRadius)
        {
            anim.SetBool("wakeUp", false);
        }
    }
}
