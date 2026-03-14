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
    }
}