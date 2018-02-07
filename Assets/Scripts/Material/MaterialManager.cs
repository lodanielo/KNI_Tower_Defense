﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MaterialManager : MonoBehaviour {



    private static MaterialManager instance;
    public static MaterialManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = GameObject.FindObjectOfType<MaterialManager>();
            }
            return instance;
        }
    }

    [SerializeField]
    private Material[] materials;


    private float value_Gold;
    private float value_Silver;
    private float value_Bronze;
    private float value_Money;

    [SerializeField]
    private Text text_gold;
    [SerializeField]
    private Text text_silver;
    [SerializeField]
    private Text text_bronze;
    [SerializeField]
    private Text text_money;

    public float Value_Gold
    {
        get
        {
            return value_Gold;
        }
        set
        {
            value_Gold = value;
            text_gold.text = value_Gold.ToString();
        }
    }

    public float Value_Silver
    {
        get
        {
            return value_Silver;
        }
        set
        {
            value_Silver = value;
            text_silver.text = value_Silver.ToString();
        }
    }

    public float Value_Bronze
    {
        get
        {
            return value_Bronze;
        }
        set
        {
            value_Bronze = value;
            text_bronze.text = value_Bronze.ToString();
        }
    }

    public float Value_Money
    {
        get
        {
            return value_Money;
        }
        set
        {
            value_Money = value;
            text_money.text = value_Money.ToString();
        }
    }


    // Use this for initialization
    void Start () {
     value_Gold=0;
     value_Silver=0;
     value_Bronze=0;
     value_Money = 0;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void AddMaterial(Material material)
    {
            if(material.nameMaterial=="GOLD")
            {
                Value_Gold += material.value;
            }
            if (material.nameMaterial == "SILVER")
            {
                Value_Silver += material.value;
            }
            if (material.nameMaterial == "BRONZE")
            {
                Value_Bronze += material.value;
            }
            if(material.nameMaterial=="MONEY")
            {
                Value_Money += material.value; 
            }
    }


    public GameObject InstantiateMaterial()
    {
        int index = Random.Range(0, materials.Length);
        return materials[index].prefabMaterial;
    }
}
