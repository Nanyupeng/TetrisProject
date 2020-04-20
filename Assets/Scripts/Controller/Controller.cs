using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    [HideInInspector]
    public Model model;//获取model 的引用
    [HideInInspector]
    public View view;//获取View的引用
    void Awake()
    {
        model = GameObject.FindGameObjectWithTag("Model").GetComponent<Model>();
        view = GameObject.FindGameObjectWithTag("View").GetComponent<View>();

    }
    void Start()
    {

    }

    void Update()
    {

    }
}
