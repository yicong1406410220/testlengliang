using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[SerializeField]
public class Person : MapC{

}

public class MapC
{
    public string name;
    public string imagePath;
    public string nature;
}

[SerializeField]
public class Prop : MapC
{

}

[SerializeField]
public class MuchCard
{
    public Person[] persons;
    public Prop[] Props;
}