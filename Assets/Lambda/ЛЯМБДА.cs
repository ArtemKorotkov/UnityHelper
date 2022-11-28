using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ЛЯМБДА : MonoBehaviour
{
    private int _currentdemage = 10;
    public bool isAlive { get => _currentdemage > 0; } //аналогично return только значительно короче

    private int _nubre = 25;
    void Start()
    {
        print(Returnint());
        ReturnPrint();
        print(multiplier(11));
        print(isAlive);
        print(multiplier2int(Returnint(), Returnint()));

        LamdaExample();
    }
    public static void LamdaExample()
    {
        int i = 9;
        string s = i == 10 ? " i = 10" : $"i != 10; i = {i}";
        

        string a = "aa";
        a ??= "qq"; // если a == null тогда a = "qq"

        a = null;
        s = a ?? "qwet"; // если операнд слева = null (a) тогда вернуть операнд справа("qwet")


    }


    //объявление более коротких методов
    private int Returnint() => 25 * _nubre;

    private void ReturnPrint() => print("Hello");

    private int multiplier(int number) => number * Returnint();

    private int multiplier2int(int int1, int int2) => int1 * int2;

}
