using UnityEngine;

public class HelloWorld : MonoBehaviour
{
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
    }
}