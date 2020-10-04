using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;


public class PluginTester : MonoBehaviour
{
    private const string DLL_NAME = "InClassActivity";

    [StructLayout(LayoutKind.Sequential)]

    struct Vector2D
    {
        public float x;
        public float y;
    }

    [DllImport(DLL_NAME)]

    private static extern int GetID();

    [DllImport(DLL_NAME)]
    private static extern void SetID(int id);


    [DllImport(DLL_NAME)]
    private static extern Vector2D GetPosition();


    [DllImport(DLL_NAME)]
    private static extern void SetPosition(float x, float y);

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S))
        {
            SetID(555);

            Debug.Log(GetID());

            SetPosition(3.4f , 5.7f);

            Debug.Log(GetPosition().x);
            Debug.Log(GetPosition().y);

        }
    }
}
