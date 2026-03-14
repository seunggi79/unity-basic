using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;

public class HelloWorld : MonoBehaviour
{

    enum ProjectileKind
    {
        Arrow,
        Bullet,
        Missile
    }
    void Start()
    {
        int x = 0;
        int y = 2;
        x = 1;

        Debug.Log(x + y);

        long a = 123456789012345;
        long b = 1L;

        Debug.Log(a * b);

        float c = 12345678901234567;
        float d = 12345678900000000;

        Debug.Log((c==d).ToString());

        string s = "abcdefg";
        string t = "hijkl";

        Debug.Log(s + t);

        // ?? : null 값이면 다음거 실행
        string str = null;
        string str2 = "abc";
        string str3 = str ?? str2; // str이 null 이라면 str2
        Debug.Log(str3);

        // ??= str이 null 인경우 다음 값을 넣는다
        str3 = str ??= str2;
        Debug.Log(str3);


        // switch문
        string groupName = "카라";
        switch (groupName)
        {
            case "르세라핌":
                Debug.Log("르세라핌");
                break;
            case "뉴진스":
                Debug.Log("뉴진스");
                break;
            case "카라":
                Debug.Log("카라");
                break;

        }

        // 배열
        int[] arr = new int[3] {1, 2, 3 }; // C# 배열은 객체다

        // 2차원 배열
        int[,] arr2 = new int[4, 6];

        // List
        List<string> names = new List<string>(5);
        names.Add("James"); // 뒤에 추가
        names.Insert(0, "hong"); // index에 추가
        names.RemoveAt(1);
        names.Remove("James");
        for (int i = 0; i < names.Count; i++) // .Count
        {

        }

        Debug.Log(names.Contains("hong")); // 있으면 true
        Debug.Log(names.IndexOf("hong")); // 있으면 index 출력 없으면 -1
        names.Clear(); // 지우기


        // 딕셔너리(키 : 값)
        Dictionary<string, string> cities = new Dictionary<string, string>();
        // Add
        Debug.Log(cities.ContainsKey("키")); // 키 있으면 true
        Debug.Log(cities.ContainsValue("값")); // 값 있으면 true

        // foreach  
        int[] arr3 = new int[3] { 1, 2, 3 };
        foreach (int numer in arr3)
        {


        }

        // call by reference
        

    }
}