using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Text;

public class PositionCSVRecorder : MonoBehaviour
{
    [SerializeField]
    private Transform m_target;

    private List<Vector3> Coordinates = new List<Vector3>();

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyUp(KeyCode.A))
            WriteCSV();

        Coordinates.Add(m_target.position);
    }

    private void WriteCSV()
    {
        var sw = new StreamWriter(Application.dataPath+"/Coordinates.csv", true, Encoding.GetEncoding("Shift_JIS"));

        foreach(Vector3 coordinate in Coordinates)
            sw.WriteLine($"{coordinate.x},{coordinate.y},{coordinate.z}");        
    }
}
