using UnityEngine;

[System.Serializable]
public class MobAttributes {
    [SerializeField] string AttributeName;
    [SerializeField] int currentValue;
    [SerializeField] int baseValue;

    [SerializeField] Icon icon;
    [SerializeField] AttributesTypes attribute;

    //Do we want them in Emun for faster ref
    public string Name
    {
        get { return AttributeName; }
        set { AttributeName = value; }
    }

    public int BaseValue
    {
        get { return baseValue; }
        set { baseValue = value; }
    }

    public void AddToBaseValue(int amt)
    {
        baseValue += amt;
     }

    public int CurrentAttributeValue
    {
        get { return currentValue; }
        set { currentValue = value; }
    }

    public void AddToCurrent(int amt)
    {
        currentValue += amt;
    }

}
