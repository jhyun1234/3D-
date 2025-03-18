using System.Globalization;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Hello World");
        int age = 30;
        Debug.Log(age);

        float height1 = 170.2f;
        float height2;
        height2= height1;

        Debug.Log(height2);


        string name;
        name = "CJH";
        Debug.Log(name);

        float result;
        result = 1 + 2.5f;
        Debug.Log(result);

        float result2;
        result2 = 1.3f - 5.7f;
        Debug.Log(result2);

        float result3;
        result3 = 3.2f * 12.7f;
        Debug.Log(result3);

        float result4;
        result4 = 3.3f / 2.3f;
        Debug.Log(result4);

        int n1 = 123;
        int n2 = 456;
        int result5;
        result5 = n1 + n2; ;
        Debug.Log(result5);

        int result6 = 10;
        result6 += 5;
        Debug.Log(result6);

        int result7 = 20; // ㅈㄵㄵㄵㄴ 많이씀
        result7++;
        Debug.Log(result7);
        // 선증가 ++result; , 후증가 result++; 

        int num1 = 2;
        int num2;

        num2 = num1++;
        num2 = ++num1;

        num1++;
        num2 = num1;// 현업에서는 이렇게 많이 함
        Debug.Log(num2);

        int num3 = 5;
        num3--;
        --num3;
        Debug.Log(num3);

        string str1 = "Hello ";
        string str2 = "World";
        string message1;

        message1 = str1 + str2;

        Debug.Log(message1);

        string str3 = "Hi ";
        int num4 = 10;
        string strnum = num4.ToString(); // 문자열로 바꿔주는 함수를 사용해야함 무조건 이렇게 사용
        string message2;
        message2 = str3 + num4; // 문자열 자체가 됨 하지만 이렇게 사용하지 않을려고 노력함
        Debug.Log(message2);





    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
