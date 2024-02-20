using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // ���� ������ ��Ȯ���� �����Ƿ� ����
    //public int hpForce;
    public float attackForce;
    public float timer;

    public float enemyHP;
    // Enemy ���� ü��

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

    // �ʴ� ���� �׽�Ʈ
    public void FixedAttack()
    {
        //if (timer <= 0f)
        //{
        //    enemyHP -= 10;
        //    Debug.Log("����");
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
            Debug.Log("����");
            timer = timer + 1f;
            testOBJ.SetActive(false);
        }
    }
}
