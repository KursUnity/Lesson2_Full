using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Conversion : MonoBehaviour
{
    public Text numberText;

    void Start()
    {
        // ��� �������� ������

        string numberString = "123 ������";
        int number;
        bool access = int.TryParse(numberString, out number); // ��� �������� �������������� "access" ������� true / ����� false

        if (access) // ���� access ����� ��� true
        {
            numberText.text = number.ToString(); // ��� �������� ��������������
        }
        else // �����
        {
            numberText.text = "�������������� �� ���������";
        }
    }

    
    void Update()
    {
        
    }
}
