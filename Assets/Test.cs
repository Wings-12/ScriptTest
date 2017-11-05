using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

    void Hello()
    {
        Debug.Log("Hello, UnityChan");
    }

    void Googbye()
    {
        Debug.Log("Goodbye, UnityChan");
    }

    int Add(int a, int b)
    {
        int c = a + b;
        return c;
    }
    public class Boss
    {
        int hp = 100;
        int power = 25;

        public void Attack()
        {

        }

        public void Defence()
        {

        }
    }


	// Use this for initialization
	void Start () {

        // Debug.Log("Hello, World");
        //int score;
        //score = 150;
        //Debug.Log(score);
        //int a = 3;
        //int b = 4;
        //int c = a + b;
        //Debug.Log(c);
        //int money = 200;
        //if (money > 100)
        //{

        //}
        //int money = 50;
        //if (money > 100)
        //{
        //    Debug.Log("ポーションを買う");
        //}
        //else if (money < 30)
        //{
        //    Debug.Log("武器を売る");
        //}
        //else
        //{
        //    Debug.Log("現状を鑑みてよく考える");
        //}
        //　三項演算子の使い方
        //int money = 200;
        //int val = (money == 200) ? -100 : 200;
        //Debug.Log(val);
        // if if else文で同じ処理を書く
        //int money = 200;
        //if (money == 200)
        //{
        //    int val = -100;
        //    Debug.Log(val);
        //}
        //else
        //{
        //    int val = 200;
        //    Debug.Log(val);
        //}
        //int a = 3;
        //if (a == 3)
        //{
        //    int b = 5;
        //Debug.Log(b);
        //}
        //for (int i = 0; i < 5; i++)
        //{
        //    Debug.Log(i);
        //}
        //// 1から9までの整数を足すプログラム
        //int sum = 0;
        //for (int i = 1; i <= 10; i++)
        //{
        //    sum += i;
        //}
        //Debug.Log(sum);
        //int[] harrican = new int[10];
        //int[] ArrayKun = { 30, 20, 50, 10, 80, 15, 60, 100 };
        //for (int i = 0; i < ArrayKun.Length; i++)
        //{
        //    if (ArrayKun[i] >= 50)
        //    {
        //        Debug.Log(ArrayKun[i]);
        //    }
        //}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
