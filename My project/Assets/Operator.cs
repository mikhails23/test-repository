using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Operator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Aritmethics
        /*
        int op1 = 4, op2 = 2, op3 = 3, result;

        result = op1 + op2;
        Debug.Log(op1 + " + " + op2 + " = " + result);

        result = op1 - op2;
        Debug.Log(op1 + " - " + op2 + " = " + result);

        result = op1 * op2;
        Debug.Log(op1 + " * " + op2 + " = " + result);

        result = op1 / op2;
        Debug.Log(op1 + " / " + op2 + " = " + result);

        result = op1 % op3;
        Debug.Log(op1 + " % " + op3 + " = " + result);

        result = op1 + op2 * op3;
        Debug.Log(op1 + " + " + op2 + " * " + op3 + " = " + result);

        result = (op1 + op2) * op3;
        Debug.Log("(" + op1 + " + " + op2 + ") * " + op3 + " = " + result);
        */

        // Increment
        /*
        int preInc = 1, postInc = 1;

        Debug.Log(++preInc);

        Debug.Log(postInc++);
        Debug.Log(postInc);
        */

        // Decrement
        /*
        int preDec = 2, postDec = 2;

        Debug.Log(--preDec);

        Debug.Log(postDec--);
        Debug.Log(postDec);
        */

        // Comparison
        /*
        int op1 = 4, op2 = 2;
        bool result;

        result = op1 < op2;
        Debug.Log(op1 + " < " + op2 + " = " + result);

        result = op1 > op2;
        Debug.Log(op1 + " > " + op2 + " = " + result);

        result = op1 <= op2;
        Debug.Log(op1 + " <= " + op2 + " = " + result);

        result = op1 >= op2;
        Debug.Log(op1 + " >= " + op2 + " = " + result);

        result = op1 == op2;
        Debug.Log(op1 + " == " + op2 + " = " + result);

        result = op1 != op2;
        Debug.Log(op1 + " != " + op2 + " = " + result);
        */

        // Conditional
        int op1 = 4, op2 = 2, op3 = 4;
        bool result;

        result = op1 <= op3 && op1 != op3;
        Debug.Log(op1 + " <= " + op3 + " && " + op1 + " != " + op3 + " = " + result);

        result = op1 >= op3 || op1 == op2;
        Debug.Log(op1 + " >= " + op3 + " || " + op1 + " == " + op2 + " = " + result);

        result = !(op1 < op3);
        Debug.Log("!(" + op1 + " < " + op3 + ") = " + result);

    }

}
