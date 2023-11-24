using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu(menuName = "Data/itemInfor", fileName = "itemInforData")]
[SerializeField]
public class ItemInformation : ScriptableObject
{
    public List<ItemConfig> listItemConfig = new List<ItemConfig>();
  
  
}

[Serializable]
public class ItemConfig
{
    public string name;
    public Sprite image;
}
