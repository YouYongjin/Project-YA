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

    public void FixedAttack()
    {
        if (timer <= 0f)
        {
            enemyHP -= 10;
            timer = 1f;
            Debug.Log("����");
            testOBJ.SetActive(false);
        }
    }
}
