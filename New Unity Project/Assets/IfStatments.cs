using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatments : MonoBehaviour
{
    public float HotChocolateTemp = 90.0f;
    public float HotLimitTemp = 75.0f;
    public float ColdLimitTemp = 39.0f;
    public int PlayerLife = 100;
    public int EnemyAttack = 25;
    public int WeakerEnemy = 10;
    public int EnemyLife = 50;
    public int PlayerAttack = 10;

    void Update()
    {
       if(Input.GetKeyDown(KeyCode.Space))
           TempratureTest();
       HotChocolateTemp -= Time.deltaTime * 5f;

       if (Input.GetKeyDown(KeyCode.A))
       {
           Battle();
           PlayerLife -= EnemyAttack;
       }

       if (Input.GetKeyDown(KeyCode.W))
       {
           Battle();
           PlayerLife -= WeakerEnemy;
       }

       if (Input.GetKeyDown(KeyCode.H))
       {
           Battle();
           EnemyLife -= PlayerAttack;
       }
    }

    void TempratureTest()
    {
        if (HotChocolateTemp > HotLimitTemp)
        {
            print("TOO HOT!");
        }
        else if (HotChocolateTemp < ColdLimitTemp)
        {
            print("Too cold..");
        }
        else
        {
            print("Just right!");
        }
    }

    void Battle()
    {
        if(PlayerLife >= EnemyAttack)
            print("Player is still alive.");
        else
        {
            print("Player died.");
        }
        if(EnemyLife >= PlayerAttack)
           print("Enemy is still alive.");
        else
        {
            print("Enemy died.");
        }
    }
}
