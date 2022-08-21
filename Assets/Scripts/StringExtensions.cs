using System;
using UnityEngine;

public static class StringExtensions
{
    public static string FirstLetterToUpper(this string obj)
    {
        if (obj.Length == 0)
        {
            return "";
        }

        return char.ToUpper(obj[0]) + obj.Substring(1).ToLower();
    }

    public static string FirstLettersToUpper(this string obj)
    {
        if (obj.Length == 0)
        {
            return "";
        }

        string[] words = obj.Split(" ");

        obj = null;

        for (int i = 0; i < words.Length; i++)
        {
            obj += words[i].FirstLetterToUpper();

            if (i < words.Length - 1)
            {
                obj += " ";
            }
        }

        return obj;
    }

    public static KeyCode ToKeyCode(this string obj)
    {
        if (obj.Length == 0)
        {
            return KeyCode.None;
        }

        return (KeyCode)Enum.Parse(typeof(KeyCode), obj.FirstLettersToUpper());
    }
}