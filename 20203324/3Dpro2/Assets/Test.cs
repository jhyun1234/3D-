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

        int result7 = 20; // ���������� ���̾�
        result7++;
        Debug.Log(result7);
        // ������ ++result; , ������ result++; 

        int num1 = 2;
        int num2;

        num2 = num1++;
        num2 = ++num1;

        num1++;
        num2 = num1;// ���������� �̷��� ���� ��
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
        string strnum = num4.ToString(); // ���ڿ��� �ٲ��ִ� �Լ��� ����ؾ��� ������ �̷��� ���
        string message2;
        message2 = str3 + num4; // ���ڿ� ��ü�� �� ������ �̷��� ������� �������� �����
        Debug.Log(message2);





    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
