using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loop : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // While
        /*
        int enemyHealth = 100;
        int attackCounter = 1;

        while(attackCounter <= 3) {
            Debug.Log("Attack ke-" + attackCounter);
            enemyHealth = enemyHealth - 10;
            Debug.Log("Enemy damaged, enemy health:" + enemyHealth);
            attackCounter++;
        }
        Debug.Log("Attack selesai");
        */

        // For
        int enemyHealth = 100;
        for (int atkCount = 1 ; atkCount <= 3 ; atkCount++) {
            Debug.Log("Attack ke-" + atkCount);
            enemyHealth = enemyHealth - 10;
            Debug.Log("Enemy got damaged, current health: " + enemyHealth);
        }
        Debug.Log("Attack selesai");
    }
}
