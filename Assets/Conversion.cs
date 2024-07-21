using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Conversion : MonoBehaviour
{
    public Text numberText;

    void Start()
    {
        // Как избежать ошибок

        string numberString = "123 Привет";
        int number;
        bool access = int.TryParse(numberString, out number); // При успешном преобразовании "access" выведет true / иначе false

        if (access) // Если access вывел нам true
        {
            numberText.text = number.ToString(); // при успешном преобразовании
        }
        else // иначе
        {
            numberText.text = "Преобразование НЕ произошло";
        }
    }

    
    void Update()
    {
        
    }
}
