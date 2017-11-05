using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

    //void Hello()
    //{
    //    Debug.Log("Hello, UnityChan");
    //}

    //void Googbye()
    //{
    //    Debug.Log("Goodbye, UnityChan");
    //}

    //int Add(int a, int b)
    //{
    //    int c = a + b;
    //    return c;
    //}

    public class Boss
    {
        private int hp = 100;
        private int power = 25;
        //・int型の変数mpを宣言し、53で初期化してください
        private int mp = 53;
        //・mpを消費して魔法攻撃をするMagic関数を作ってください
        public void Magic()
        {
            //・Magic関数内でmpを5減らし、
            mp -= 5;
            //コンソールに
            //「魔法攻撃をした。残りMPは〇〇。」と表示してください。mpが足りない場合、
            if (mp > 0)
            {
            Debug.Log("魔法攻撃をした。残りMPは" + mp + "。");
            }
            //「MPが足りないため魔法が使えない。」と表示してください
            else
            {
                Debug.Log("MPが足りないため魔法が使えない。");
            }
        }

        public void Attack()
        {
            Debug.Log(this.power + "のダメージを与えた");
        }

        public void Defence(int damage)
        {
            Debug.Log(damage + "のダメージを受けた");
            this.hp -= damage;
        }
    }


    // Use this for initialization
    void Start () {
        //    下記の条件を満たしてください

        //要素の個数が5の、int型の配列arrayを宣言して好きな値で初期化してください
        int[] array = { 7, 8, 9, 10, 11 };
        //配列の各要素の値を順番に表示してください
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }
        //for文を使い、配列の各要素の値を逆順に表示してください
        for (int j = array.Length -1; 0 <= j; j--) 
            //　　　　　　↑array.Length -1のように
            //配列の数が変わってもいちいち
            //書き直さなくてもよいようにするためにはどうすればいいのか考える
        {
            Debug.Log(array[j]);
        }

        Boss kabigon = new Boss();
        kabigon.Magic();
        kabigon.Magic();
        kabigon.Magic();
        kabigon.Magic();
        kabigon.Magic();
        kabigon.Magic();
        kabigon.Magic();
        kabigon.Magic();
        kabigon.Magic();
        kabigon.Magic();
        kabigon.Magic();
        kabigon.Magic();
        kabigon.Magic();
        kabigon.Magic();
        kabigon.Magic();
        kabigon.Magic();
        kabigon.Magic();
        kabigon.Magic();
        kabigon.Magic();
        kabigon.Magic();
        kabigon.Magic();



        //Boss lastboss = new Boss();

        //lastboss.Attack();
        //lastboss.Defence(3);

        //Boss midboss = new Boss();
        //midboss.Attack();
        //midboss.Defence(5);

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
