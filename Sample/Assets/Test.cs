using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Debug.Log("Hellow World");

        float height1 = 160.0f;
        float height2;
        height2 = height1;
        Debug.Log(height2);

        string name;
        name = "kuribara";
        Debug.Log(name);

        int a = 1;
        int b = 2;
        int answer;
        answer = a + b;
        Debug.Log(answer);

        string str1 = "happy ";
        string str2 = "birthday";
        str1 += str2;
        Debug.Log(str1);

        int helpNum = 1;
        if (helpNum == 1)
        {
            Debug.Log("HPが50回復");
        }

        int hp = 30;
        if (hp >= 100)
        {
            Debug.Log("攻撃！");
        }
        else if(hp >= 50)
        {
            Debug.Log("防御！");
        }
        else
        {
            Debug.Log("回復！");
        }

        int i;
        for (i = 0; i < 5; i++)
        {
            Debug.Log(i);
        }

        for (i = 0; i < 10; i += 2)
        {
            Debug.Log(i);
        }

        for (i = 3; i <= 5; i++)
        {
            Debug.Log(i);
        }

        for (i = 3; i > 0; i--)
        {
            Debug.Log(i);
        }

        int sum = 0;

        for (i = 0; i < 10; i += 2)
        {
            sum += i;
        }
        Debug.Log(sum);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
