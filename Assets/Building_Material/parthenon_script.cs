using System.Linq;
using UnityEngine;

public class parthenon_script : MonoBehaviour {

    public GameObject cubePrefab;
    public GameObject cylinderPrefab;

    public float floorWidth = 5.0f;
    public float floorDepth = 10.0f;
    public float floorHeight = 0.25f;
    public float pillarRadius = 0.2f;
    public float pillarHeight = 2.0f;
    public float pillarCountWidth = 6.0f;
    public float pillarCountDepth = 10.0f;
    public float roofHeight = 1.0f;
    public string floorMaterial = "Floor";
    public string pillarMaterial = "Pillar";
    public string roofMaterial = "Roof";


    [ContextMenu("Build")]
    void Builder()
    {
        Debug.LogFormat("Destroy All Previous Children\n");
        foreach (Transform t in transform.Cast<Transform>().ToArray())
        {
            DestroyImmediate(t.gameObject);
        }

        Debug.LogFormat("Now Building Floors\n");

        //Material.Create

        var newfloorObject1=Instantiate(cubePrefab,transform);
        var floor1st = newfloorObject1.transform;
        floor1st.localScale = new Vector3(floorWidth,floorHeight,floorDepth);
        floor1st.localPosition = new Vector3(0, 0, 0);

        var newfloorObject2 = Instantiate(cubePrefab, transform);
        var floor2nd = newfloorObject2.transform;
        floor2nd.localScale = new Vector3(floorWidth*0.9f, floorHeight, floorDepth*0.9f);
        floor2nd.localPosition = new Vector3(0, floorHeight, 0);

        var newfloorObject3 = Instantiate(cubePrefab, transform);
        var floor3rd = newfloorObject3.transform;
        floor3rd.localScale = new Vector3(floorWidth*0.81f, floorHeight, floorDepth*0.81f);
        floor3rd.localPosition = new Vector3(0, floorHeight*2.0f, 0);

        var newPillarObject = Instantiate(cylinderPrefab,transform);

    }

}
