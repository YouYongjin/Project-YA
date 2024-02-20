using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // 아직 컨셉이 명확하지 않으므로 제외
    //public int hpForce;
    public float attackForce;
    public float timer;

    public float enemyHP;
    // Enemy 가상 체력

    public GameObject testOBJ;

    void Start()
    {
        attackForce = 0f;
        timer = 1f;
        enemyHP = 100;
    }

    // Update is called once per frame
    void Update()
    {
        AttackTimer();
        FixedAttack();

        Debug.Log(timer);
    }

    public void AttackTimer()
    {
        timer -= Time.deltaTime;
    }

    // 초당 공격 테스트
    public void FixedAttack()
    {
        //if (timer <= 0f)
        //{
        //    enemyHP -= 10;
        //    Debug.Log("공격");
        //    timer = timer + 1f;
        //    testOBJ.SetActive(false);
        //}

        if(timer >= 0.9f)
        {
            testOBJ.SetActive(true);
        }
        else if(timer <= 0f)
        {
            enemyHP -= 10;
            Debug.Log("공격");
            timer = timer + 1f;
            testOBJ.SetActive(false);
        }
    }
}
