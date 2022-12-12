using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class StartTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string path = "Assets/Resources/Employees.json";
        if (FileExists(path))
        {
            JsonReader jsonReader = new JsonReader();
            jsonReader.list11(path);

        }


    }






     bool FileExists(string FileName)
    {


        if (FileName == null || FileName.Length == 0)
            return false;
        //{
        //    throw new ArgumentNullException("FileName");
        //}

        // Check to see if the file exists.
        FileInfo fInfo = new FileInfo(FileName);

        // You can throw a personalized exception if
        // the file does not exist.
        if (!fInfo.Exists)
            return false;

        //{
        //    throw new FileNotFoundException("The file was not found.", FileName);
        //}
        return true;


    }


}
