using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveObjectBaseOnInput : MonoBehaviour
{
    public InputField inputField;

    void Update()
    {
        if (inputField.text != "") // ���� ������� ������ inputField ������ �� ������, ��
        {
            float position;

            if (float.TryParse(inputField.text, out position)) // ���������� ������������� ����� � ������� (�� ���� �� float)
            {
                transform.position = new Vector3(position, transform.position.y, transform.position.z);
            }
        }
    }
}
