using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[SerializeField]
public class Person : MapC{

}

[SerializeField]
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
    public Prop[] props;
}