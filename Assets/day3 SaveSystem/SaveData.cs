using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class SaveData
{
    private static SaveData _current;

    public static SaveData Current => _current ??= new SaveData(); //jeżeli _current jest nullem, robimy z niego nowy savedata i zwracamy

    public int playerExp = 100;

    public Vector3 playerPosition;
    public Quaternion playerRotation;

}

// duza ilosc obiektow
// event przed save wstawiający do listy obiekty które chca byc zapisane
// zapisanie ich danych
// niedzialajacy przyklad
[Serializable]
public class UnitData
{
    public int unitId;
    public Vector3 playerPosition;
    public Quaternion playerRotation;
}