using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapCreator : MonoBehaviour
{
    public int rowCount = 10;
    public int columCount = 10;
    public int scale = 1;
    public GameObject gridPrefab;
    public Vector3 leftBottomLocation = new Vector3(0, 0, 0);

    // Start is called before the first frame update
    void Awake()
    {
        if (gridPrefab)
        {
            Geneategrid();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    void Geneategrid()
    {
        for (int i = 0; i < columCount; i++)
        {
            for (int j = 0; j < rowCount; j++)
            {
                GameObject obj = Instantiate(gridPrefab, new Vector3(leftBottomLocation.x+scale*i, leftBottomLocation.y, leftBottomLocation.z+scale *j), Quaternion.identity);
                obj.transform.SetParent(gameObject.transform);
                obj.GetComponent<GridStats>().x = i;
                obj.GetComponent<GridStats>().y = j;

            }
        }
    }
}
